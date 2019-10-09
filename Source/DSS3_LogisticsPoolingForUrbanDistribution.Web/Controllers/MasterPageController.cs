// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using AppCode;
using DSS3_LogisticsPoolingForUrbanDistribution.BO;
using DSS3_LogisticsPoolingForUrbanDistribution.UI.ViewModels.MasterPage;
using Identity = zAppDev.DotNet.Framework.Identity;
using log4net;
using Newtonsoft.Json;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using zAppDev.DotNet.Framework.Configuration;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Identity;
using zAppDev.DotNet.Framework.Identity.Model;
using zAppDev.DotNet.Framework.Linq;
using zAppDev.DotNet.Framework.Mvc;
using zAppDev.DotNet.Framework.Utilities;

namespace DSS3_LogisticsPoolingForUrbanDistribution.UI.Controllers.MasterPage
{

    [RoutePrefix("MasterPage")]
    public class MasterPageController : ControllerBase<MasterPageViewModel, MasterPageViewModelDTO>
    {
        public MasterPageController()
        {
            _logger = log4net.LogManager.GetLogger(typeof(MasterPageController));
            if (ViewModelDTOBase.DTOHelper == null)
            {
                ViewModelDTOBase.DTOHelper = new DTOHelper();
            }
        }
        public MasterPageController(MasterPageViewModel m) : this()
        {
            model = m;
        }

        [HttpGet]
        [Route("DebugPage")]
        public ActionResult DebugPage()
        {
            return View("DebugPage", 0);
        }


        public void SetModel(MasterPageViewModel m)
        {
            @model = m;
        }


        public override void CommitAllFiles()
        {
        }

        public override void CommitAllFilesLegacy()
        {
        }

        public override void ClearPendingFiles()
        {
        }






        [HttpGet]

        [Route("GetViewDTO")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public ContentResult GetViewDTO(int hash)
        {
            return Content(GetViewFromViewDTOsDicSerialized(hash));
        }

        [HttpPost]

        [Route("UpdateInstance")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public ActionResult UpdateInstance()
        {
            return PrepareUpdateInstanceResult(typeof(MasterPageViewModel));
        }

        [HttpPost]

        [Route("_Raise")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public ActionResult _Raise()
        {
            return _RaiseEvent();
        }


        [HttpGet]
        [Route("DownloadFileByPath")]
        [CustomControllerActionFilter(HasDefaultResultView=true)]
        public FileContentResult DownloadFileByPath(string path, string defaultPath = null)
        {
            if (IdentityHelper.GetCurrentIdentityUser() == null) return null;
            if (string.IsNullOrWhiteSpace(path) && string.IsNullOrWhiteSpace(defaultPath))
            {
                throw new ApplicationException("Please provide a path.");
            }
            return FileHelper.PendingDownloadInstance.DownloadByPath(path, defaultPath);
        }

        [HttpGet]

        [Route("_GetDbErrors")]
        [CustomControllerActionFilter(HasDefaultResultView=true)]
        public ActionResult _GetDbErrors()
        {
            var __result = Json(new
            {
                Errors = zAppDev.DotNet.Framework.Data.MiniSessionManager.UpdateDbErrors,Script = zAppDev.DotNet.Framework.Data.MiniSessionManager.UpdateDbScript
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }
        [HttpGet]

        [Route("_Ping")]
        [CustomControllerActionFilter(HasDefaultResultView=true)]
        public ActionResult _Ping()
        {
            return Content("pong");
        }

        #region Controller Actions
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName="Render", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("Render")]
        public ActionResult Render()

        {
            @model = new MasterPageViewModel();
            return null;
        }

        [CustomControllerActionFilter(FillDropDownInitialValues=true, ActionName="Render", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("_API_Render")]
        public ActionResult _API_Render()

        {
            @model = new MasterPageViewModel();
            PushToHistory();
            var redirectInfo = ExecuteRender();
            return redirectInfo;
        }

        [CustomControllerActionFilter(ActionName="SignOut", ClaimType = ClaimTypes.ControllerAction)]
        [HttpPost]
        [Route("SignOut")]
        public ActionResult SignOut()

        {
            var _data = _LoadViewModel();
            var redirectInfo = ExecuteSignOut();
            return redirectInfo;
        }

        #endregion
        #region Controller Actions Implementation
        /*<ControllerActionImplementation:Render:1/>*/
        public ActionResult ExecuteRender()
        {
            ActionResult _result = null;
            @model.Title = BaseViewPage<string>.GetResourceValue("MasterPage", "RES_PAGETITLE_Render").ToString();
            return _result;
        }
        /*<ControllerActionImplementation:SignOut:1/>*/
        public ActionResult ExecuteSignOut()
        {
            ActionResult _result = null;
            zAppDev.DotNet.Framework.Identity.IdentityHelper.SignOut();
            _result = GetRedirectInfo("SignInPage", "Load", new  RouteValueDictionary(new {  }));
            return _result;
        }
        #endregion

        public override ActionResult PreActionFilterHook(bool causesValidation, bool listenToEvent, string actionName)
        {
            System.Web.HttpContext.Current.Items["_currentControllerAction"] = actionName;
            if (listenToEvent) return null;
            return null;
        }
        public override ActionResult PostActionFilterHook(bool hasDefaultResultView, bool fillDropDownInitialValues = false)
        {
            if (HasClientResponse())
            {
                viewDTO.ClientResponse = GetClientResponse();
            }
            else
            {
                var _modelDTO = new MasterPageViewModelDTO(@model);
                viewDTO.Model = _modelDTO;
            }
            if (!hasDefaultResultView)
            {
                var __result = Json(new
                {
                    Type = "Data",Data = viewDTO.Serialize()
                }, JsonRequestBehavior.AllowGet);
                __result.MaxJsonLength = int.MaxValue;
                return __result;
            }
            return View("MasterPage");
        }

        #region Data Validations


        private ActionResult GetFailedDataValidationsResult()
        {
            try
            {
                RunDataValidations();
                if (!viewDTO.DataValidationsHaveFailed) return null;
                var __result = Json(new
                {
                    Type = "RuleEvaluation",Data = viewDTO.Serialize()
                }, JsonRequestBehavior.AllowGet);
                __result.MaxJsonLength = int.MaxValue;
                return __result;
            }
            catch (Exception e)
            {
                _logger.Error("!!! DANGER: Error while evaluating Data Validations !!!", e);
                log4net.LogManager.GetLogger(this.GetType()).Error("Form: MasterPage, Action: " + System.Web.HttpContext.Current.Items["_currentControllerAction"], e);
                //throw;
                return null;
            }
        }
        public List<RuleResult> RunDataValidations()
        {
            return viewDTO.RuleEvaluations.DataValidations;
        }

        #endregion
    }
}
