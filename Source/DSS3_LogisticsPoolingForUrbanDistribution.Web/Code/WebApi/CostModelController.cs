// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using zAppDev.DotNet.Framework.Mvc;
using AppCode;
using Identity = zAppDev.DotNet.Framework.Identity;
using zAppDev.DotNet.Framework.Identity;
namespace DSS3_LogisticsPoolingForUrbanDistribution.Web.Code.WebApi
{


    [RoutePrefix("api/CostModel")]
    [WebApiThrottle.EnableThrottling()]
    public class CostModelController : BasicApiCtrl
    {

        /// <summary>
        ///
        /// </summary>
        /// <returns>decimal</returns>
        [CustomWebApiActionFilter(LogEnabled = true)]
        [CustomWebApiAuthorize(LogEnabled = true)]

        [Route("CalculateCost")]
        [HttpGet]
        public decimal? CalculateCost(decimal? DriverSalary = 0, decimal? AvWorkH = 0, decimal? AvServiceH = 0, decimal? VehiculeAnnualHours = 0, decimal? VehiculeAnnualDays = 0, decimal? CostOfReplacementVehicule = 0, decimal? DaysReplacementVehicule = 0, decimal? AmortizationPeriod = 0, decimal? UtilisationPeriod = 0, decimal? ResidualValue = 0, decimal? MaintainanceCost = 0, decimal? VehiculeInsuranceCost = 0, decimal? GoodsInsurancecCost = 0, decimal? RoadTax = 0, decimal? VehiculePurchaseCost = 0, string AmortizationType = "", decimal? TotalDistanceDriven = 0, decimal? TotalDistanceService = 0, decimal? CNGDistance = 0, decimal? FuelDistance = 0, decimal? DieselDistance = 0, decimal? CNGCost = 0, decimal? CNGConsumption = 0, decimal? FuelCost = 0, decimal? FuelConsumption = 0, decimal? DieselCost = 0, decimal? DieselConsumption = 0, decimal? RefriCost = 0, decimal? Lettering = 0, decimal? TotalDistanceVehicule = 0, decimal? OilCost = 0, decimal? OilConsumption = 0, decimal? TireCost = 0, decimal? DistancePerTire = 0, decimal? YearlyReparationCost = 0, decimal? RouteDistance = 0, decimal? RouteTime = 0, decimal? OverHeadFactor = 0)
        {
            var request = ((HttpContextBase)Request.Properties["MS_HttpContext"]).Request;
            var _RequestSourceIp = request.UserHostAddress;
            var _UserName = Identity.IdentityHelper.GetCurrentUserName();
            var result =  (new DSS3_LogisticsPoolingForUrbanDistribution.Services.CostModelService()).CalculateCost(DriverSalary,AvWorkH,AvServiceH,VehiculeAnnualHours,VehiculeAnnualDays,CostOfReplacementVehicule,DaysReplacementVehicule,AmortizationPeriod,UtilisationPeriod,ResidualValue,MaintainanceCost,VehiculeInsuranceCost,GoodsInsurancecCost,RoadTax,VehiculePurchaseCost,AmortizationType,TotalDistanceDriven,TotalDistanceService,CNGDistance,FuelDistance,DieselDistance,CNGCost,CNGConsumption,FuelCost,FuelConsumption,DieselCost,DieselConsumption,RefriCost,Lettering,TotalDistanceVehicule,OilCost,OilConsumption,TireCost,DistancePerTire,YearlyReparationCost,RouteDistance,RouteTime,OverHeadFactor,_RequestSourceIp, _UserName);
            return result;
        }
    }
}