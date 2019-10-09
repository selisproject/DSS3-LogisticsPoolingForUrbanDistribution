// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.Web;
using System.Web.Http;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using DSS3_LogisticsPoolingForUrbanDistribution.Hubs;
using DSS3_LogisticsPoolingForUrbanDistribution.BO;
using DSS3_LogisticsPoolingForUrbanDistribution.DAL;
using zAppDev.DotNet.Framework.Web.UI;
using log4net;
using log4net.Config;
using AppCode;
using Autofac;
using Autofac.Integration.WebApi;
using CacheManager.Core;
using DSS3_LogisticsPoolingForUrbanDistribution.Web.Code;
using zAppDev.DotNet.Framework.Logging;
using System.Security.Authentication;
using System.Security;
using zAppDev.DotNet.Framework.Workflow;
using zAppDev.DotNet.Framework.Identity.Model;
using zAppDev.DotNet.Framework.Mvc;

namespace DSS3_LogisticsPoolingForUrbanDistribution.Web
{
    internal class CustomViewEngine : RazorViewEngine
    {
        public CustomViewEngine()
        {
            var viewLocations = new[]
            {
                "~/Views/{0}.cshtml"
            };
            PartialViewLocationFormats = viewLocations;
            ViewLocationFormats = viewLocations;
        }
    }

    public class Global : HttpApplication
    {
        public void Application_Start(object sender, EventArgs e)
        {
            System.Web.Helpers.AntiForgeryConfig.UniqueClaimTypeIdentifier = System.Security.Claims.ClaimTypes.Name;
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new CustomViewEngine());
            XmlConfigurator.Configure();
            var config = GlobalConfiguration.Configuration;
            config.MapHttpAttributeRoutes();
            config.EnsureInitialized();
            LogManager.GetLogger(GetType()).Info("Application start!");
            var dbMigrator = new DatabaseMigrator();
            if (dbMigrator.ShouldRun)
            {
                if (!dbMigrator.CanConnectToDatabase())
                {
                    throw new Exception("Cannot connect to the database. Please check your connection string and ensure the database exists.");
                }
                if (!dbMigrator.Run())
                {
                    throw new Exception("Failed to Upgrade the Database using the pending Migrations. Please, see the Log file for further details.");
                }
            }
            new AccessLogManager().Run();
            RegisterRoutes(RouteTable.Routes);
            RuntimePredicateBuilder.RequiredAssembliesPaths = new List<string>()
            {
                Server.MapPath("bin\\DSS3_LogisticsPoolingForUrbanDistribution.Backend.dll"),
                               Server.MapPath("bin\\DSS3_LogisticsPoolingForUrbanDistribution.Web.dll"),
                               Server.MapPath("bin\\zAppDev.DotNet.Framework.dll")
            };
            WebFormResources.ClearResources = true;
            Utilities.InitXssEncoder();
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            if (!Session.IsNewSession) return;
            ScheduleThread.CheckScheduleThreadStatus(HttpContext.Current);
            ScheduleThread.NumberOfSessions++;
            LogManager.GetLogger(GetType()).InfoFormat("Session: {0} started, user:{1} (Number Of Sessions: {2})",
                    Session.SessionID,
                    User.Identity.Name,
                    ScheduleThread.NumberOfSessions);
            EventsHub.RaiseSessionStart();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            var accessError = HttpContext.Current?.Response?.Headers[nameof(SecurityException)];
            if (!string.IsNullOrWhiteSpace(accessError))
            {
                BaseViewPage<int>.SendSecurityErrorReponse(accessError);
            }
        }

        protected void Application_PostAuthorizeRequest()
        {
            var userCreationError = HttpContext.Current.Response.Headers[nameof(AuthenticationException)];
            if (!string.IsNullOrWhiteSpace(userCreationError))
            {
                BaseViewPage<int>.SendApplicationUserCreationErrorReponse(userCreationError);
            }
            if (HttpContext.Current.Request.Url.AbsolutePath.Contains("/FormAPIs/"))
            {
                HttpContext.Current.SetSessionStateBehavior(SessionStateBehavior.Required);
            }
        }

        private void UserAccessCheck()
        {
            try
            {
                EventsHub.RaiseUserAuthenticating(HttpContext.Current.User.Identity.Name);
            }
            catch (Exception e)
            {
                BaseViewPage<int>.SendSecurityErrorReponse(e.InnerException == null ? e.Message : e.InnerException.Message);
            }
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            // Get the exception object.
            var exc = Server.GetLastError();
            // Log the exception and notify system operators
            LogManager.GetLogger(GetType()).Error($"Error in: {HttpContext.Current?.Request?.Url}", exc);
            // Raise the ApplicationError Event
            EventsHub.RaiseApplicationError(exc);
            // Clear the error from the server
            Server.ClearError();
        }

        protected void Session_End(object sender, EventArgs e)
        {
            zAppDev.DotNet.Framework.Identity.IdentityHelper.RemoveUserSession(Session?.SessionID);
            ScheduleThread.NumberOfSessions--;
            LogManager.GetLogger(GetType()).InfoFormat("Session: {0} expired/ended. {1} remaining.", Session.SessionID, ScheduleThread.NumberOfSessions);
        }

        public void Application_End(object sender, EventArgs e)
        {
            EventsHub.RaiseApplicationEnd();
            ScheduleThread.StopScheduleThread();
            ScheduleThread.NumberOfSessions = 0;
            LogManager.GetLogger(GetType()).Info("Application end!");
        }

        private static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
        }
    }
}