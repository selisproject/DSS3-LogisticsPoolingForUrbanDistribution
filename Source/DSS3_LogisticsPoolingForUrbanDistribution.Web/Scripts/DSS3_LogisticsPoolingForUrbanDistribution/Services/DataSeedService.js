// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var DSS3_LogisticsPoolingForUrbanDistribution;
(function (DSS3_LogisticsPoolingForUrbanDistribution) {
    var Services;
    (function (Services) {
        /**
         * Client for 'DataSeed' Service
         */
        var DataSeedServiceClient = (function () {
            function DataSeedServiceClient() {
            }
            /**
            * test notes
            */
            DataSeedServiceClient.Orders = function (orders) {
                var _data = orders;
                return axios.post(window._context.siteRoot + DataSeedServiceClient.baseUrl + "Orders", _data);
            };
            /**
            *
            */
            DataSeedServiceClient.InitRegionalAgents = function () {
                var _data = { params: {} };
                return axios.get(window._context.siteRoot + DataSeedServiceClient.baseUrl + "InitRegionalAgents", _data);
            };
            /**
            *
            */
            DataSeedServiceClient.Change = function () {
                var _data = { params: {} };
                return axios.get(window._context.siteRoot + DataSeedServiceClient.baseUrl + "change", _data);
            };
            /**
            *
            */
            DataSeedServiceClient.TestGoogleAPI = function () {
                var _data = { params: {} };
                return axios.get(window._context.siteRoot + DataSeedServiceClient.baseUrl + "googleAPI", _data);
            };
            /**
            *
            */
            DataSeedServiceClient.initWarehouse = function () {
                var _data = { params: {} };
                return axios.get(window._context.siteRoot + DataSeedServiceClient.baseUrl + "warehouse", _data);
            };
            /**
            *
            */
            DataSeedServiceClient.testOrderGenerator = function () {
                var _data = { params: {} };
                return axios.get(window._context.siteRoot + DataSeedServiceClient.baseUrl + "testordergenerator", _data);
            };
            /**
            *
            */
            DataSeedServiceClient.testReflection = function () {
                var _data = { params: {} };
                return axios.get(window._context.siteRoot + DataSeedServiceClient.baseUrl + "testreflection", _data);
            };
            /**
            *
            */
            DataSeedServiceClient.TruckPosistions = function () {
                var _data = { params: {} };
                return axios.get(window._context.siteRoot + DataSeedServiceClient.baseUrl + "TruckPosistions", _data);
            };
            return DataSeedServiceClient;
        }());
        /**
         * Base url for 'DataSeed' Service
         */
        DataSeedServiceClient.baseUrl = "/api/DataSeed/";
        Services.DataSeedServiceClient = DataSeedServiceClient;
    })(Services = DSS3_LogisticsPoolingForUrbanDistribution.Services || (DSS3_LogisticsPoolingForUrbanDistribution.Services = {}));
})(DSS3_LogisticsPoolingForUrbanDistribution || (DSS3_LogisticsPoolingForUrbanDistribution = {}));
// Create service shortcut
if (window.$api == null) {
    window.$api = {};
}
window.$api.DataSeed = DSS3_LogisticsPoolingForUrbanDistribution.Services.DataSeedServiceClient;
