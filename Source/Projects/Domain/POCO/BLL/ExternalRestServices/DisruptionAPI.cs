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
    public class DisruptionAPIRestService
    {
        public static string BaseUrl
        {
            get
            {
                var baseUrl = System.Configuration.ConfigurationManager.AppSettings["externalapis:DisruptionAPI:baseurl"];
                if (string.IsNullOrWhiteSpace(baseUrl))
                {
                    baseUrl = "http://localhost";
                }
                if (!string.IsNullOrWhiteSpace(baseUrl) && !baseUrl.EndsWith("/"))
                {
                    baseUrl += "/";
                }
                return baseUrl;
            }
        }

        public static void Disrupt(string order_id)
        {
            System.Func<string> getUrl = () =>
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
                return null;
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
                ExtraHeaderData = new System.Collections.Generic.Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) {   },
                LogAccess = false,
                IsCachingEnabled = false,
                ApiName = "DisruptionAPI",
                Operation = "Disrupt",
                PostType = PostType.JSON
            };
            Func<ServiceConsumptionContainer, object> _invocation = (_httpResponse) =>
            {
                RestServiceConsumer.Consume<object>(_options, _httpResponse);
                return null;
            };
            var _consumer = new ServiceConsumer<object>(_invocation);
            _consumer.Invoke(_options);
        }
        public static void Continue(string order_id)
        {
            System.Func<string> getUrl = () =>
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
                return null;
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
                ExtraHeaderData = new System.Collections.Generic.Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) {   },
                LogAccess = false,
                IsCachingEnabled = false,
                ApiName = "DisruptionAPI",
                Operation = "Continue",
                PostType = PostType.JSON
            };
            Func<ServiceConsumptionContainer, object> _invocation = (_httpResponse) =>
            {
                RestServiceConsumer.Consume<object>(_options, _httpResponse);
                return null;
            };
            var _consumer = new ServiceConsumer<object>(_invocation);
            _consumer.Invoke(_options);
        }

    }
}