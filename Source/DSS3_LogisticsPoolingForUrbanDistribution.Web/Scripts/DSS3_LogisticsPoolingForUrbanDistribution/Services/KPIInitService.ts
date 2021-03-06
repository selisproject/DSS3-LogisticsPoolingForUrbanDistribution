// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
namespace DSS3_LogisticsPoolingForUrbanDistribution.Services {
/**
 * Client for 'KPIInit' Service
 */
export class KPIInitServiceClient {

    /**
     * Base url for 'KPIInit' Service
     */
    static baseUrl = "/api/KPIInit/";

    /**
    *
    */
    public static InitKPIs(): Axios.IPromise<Axios.AxiosXHR<any>> {
        const _data = { params: {  } };
        return axios.get(window._context.siteRoot + KPIInitServiceClient.baseUrl + "InitKPIs",_data);
    }

}
}

// Create service shortcut
if (window.$api == null) {
    window.$api = {};
}

window.$api.KPIInit = DSS3_LogisticsPoolingForUrbanDistribution.Services.KPIInitServiceClient;
