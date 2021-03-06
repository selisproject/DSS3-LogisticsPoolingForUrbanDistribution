// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

using zAppDev.DotNet.Framework.Services;
using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace DSS3_LogisticsPoolingForUrbanDistribution.BLL.ExternalRestServices
{
    public class Optimizer_MapotempoRestService
    {
        public static string BaseUrl
        {
            get
            {
                var baseUrl = System.Configuration.ConfigurationManager.AppSettings["externalapis:Optimizer_Mapotempo:baseurl"];
                if (string.IsNullOrWhiteSpace(baseUrl))
                {
                    baseUrl = "http://optimizer.mapotempo.com/0.1/";
                }
                if (!string.IsNullOrWhiteSpace(baseUrl) && !baseUrl.EndsWith("/"))
                {
                    baseUrl += "/";
                }
                return baseUrl;
            }
        }

        public static DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.Optimizer_Mapotempo.Optimizer_MapotempoRoot job(string id, string api_key)
        {
            System.Func<string> getUrl = () =>
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
                return "vrp/jobs" + "/" + id + "?api_key=" + api_key;
            };
            var _operationRelativeUrl = getUrl.Invoke().Trim();
            if (_operationRelativeUrl?.StartsWith("/") == true && BaseUrl?.EndsWith("/") == true)
            {
                _operationRelativeUrl = _operationRelativeUrl.TrimStart('/');
            }
            var _targetUrl = BaseUrl + _operationRelativeUrl;
            var _options = new RestServiceConsumptionOptions
            {
                Url = _targetUrl,
                Verb = RestHTTPVerb.GET,
                ExtraHeaderData = new System.Collections.Generic.Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    { "Accept", "application/json"
                    }
                },
                LogAccess = false,
                IsCachingEnabled = false,
                ApiName = "Optimizer_Mapotempo",
                Operation = "job"
            };
            Func<ServiceConsumptionContainer, DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.Optimizer_Mapotempo.Optimizer_MapotempoRoot> _invocation = (_httpResponse) =>
            {
                var _returnedItem = RestServiceConsumer.Consume<DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.Optimizer_Mapotempo.Optimizer_MapotempoRoot>(_options, _httpResponse);
                return zAppDev.DotNet.Framework.Utilities.Common.SafeCast<DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.Optimizer_Mapotempo.Optimizer_MapotempoRoot>(_returnedItem);
            };
            var _consumer = new ServiceConsumer<DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.Optimizer_Mapotempo.Optimizer_MapotempoRoot>(_invocation);
            return _consumer.Invoke(_options);
        }
        public static DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.Optimizer_Mapotempo.Optimizer_MapotempoRoot submit(DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.Optimizer_Mapotempo.VrpProblem a01VrpSubmit, string api_key)
        {
            System.Func<string> getUrl = () =>
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
                return "vrp/submit" + "?api_key=" + api_key;
            };
            var _operationRelativeUrl = getUrl.Invoke().Trim();
            if (_operationRelativeUrl?.StartsWith("/") == true && BaseUrl?.EndsWith("/") == true)
            {
                _operationRelativeUrl = _operationRelativeUrl.TrimStart('/');
            }
            var _targetUrl = BaseUrl + _operationRelativeUrl;
            var _options = new RestServiceConsumptionOptions
            {
                Url = _targetUrl,
                Verb = RestHTTPVerb.POST,
                ExtraHeaderData = new System.Collections.Generic.Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    { "Accept", "application/json"
                    }
                },
                LogAccess = false,
                IsCachingEnabled = false,
                ApiName = "Optimizer_Mapotempo",
                Operation = "submit",
                PostType = PostType.JSON,
                Data = a01VrpSubmit, FormData = new Dictionary<string, object> {{"a01VrpSubmit",a01VrpSubmit}}
            };
            Func<ServiceConsumptionContainer, DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.Optimizer_Mapotempo.Optimizer_MapotempoRoot> _invocation = (_httpResponse) =>
            {
                var _returnedItem = RestServiceConsumer.Consume<DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.Optimizer_Mapotempo.Optimizer_MapotempoRoot>(_options, _httpResponse);
                return zAppDev.DotNet.Framework.Utilities.Common.SafeCast<DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.Optimizer_Mapotempo.Optimizer_MapotempoRoot>(_returnedItem);
            };
            var _consumer = new ServiceConsumer<DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.Optimizer_Mapotempo.Optimizer_MapotempoRoot>(_invocation);
            return _consumer.Invoke(_options);
        }

    }
}