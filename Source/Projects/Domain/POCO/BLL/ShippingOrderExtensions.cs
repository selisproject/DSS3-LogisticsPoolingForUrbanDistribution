
// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Collections;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Configuration;
using zAppDev.DotNet.Framework.Data.Domain;

using DSS3_LogisticsPoolingForUrbanDistribution.DAL;

namespace DSS3_LogisticsPoolingForUrbanDistribution.BO
{
	/// <summary>
	/// The ShippingOrder extensions
	/// </summary>
	public static class ShippingOrderExtensions
	{
        public static void NewOperation(this BO.ShippingOrder @this){using (new zAppDev.DotNet.Framework.Profiling.Profiler("ShippingOrder", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "NewOperation")) {
}
}


public static void NewOperation1(this BO.ShippingOrder @this){using (new zAppDev.DotNet.Framework.Profiling.Profiler("ShippingOrder", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "NewOperation1")) {
}
}


public static string Get_CurrentStatus(this BO.ShippingOrder @this){using (new zAppDev.DotNet.Framework.Profiling.Profiler("ShippingOrder", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "Get_CurrentStatus")) {
if ((@this?.StatusEvolution?.OrderByDescending((a) => a.TimeChanged).FirstOrDefault() != null && @this?.StatusEvolution?.OrderByDescending((a) => a.TimeChanged).FirstOrDefault()?.Status != null)) {
return (@this?.StatusEvolution?.OrderByDescending((a) => a.TimeChanged).FirstOrDefault()?.Status?.Description ?? "");
}
return null;
}
}


public static decimal? CalculateOrderCost(this BO.ShippingOrder @this){using (new zAppDev.DotNet.Framework.Profiling.Profiler("ShippingOrder", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "CalculateOrderCost")) {
return 1.00m;
}
}


public static decimal? Get_AggregateLoad(this BO.ShippingOrder @this){using (new zAppDev.DotNet.Framework.Profiling.Profiler("ShippingOrder", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "Get_AggregateLoad")) {
decimal? TotalMass = new decimal?();
foreach (var i in @this?.PlannedVolume ?? Enumerable.Empty<DSS3_LogisticsPoolingForUrbanDistribution.BO.CustomVolume>()) {
TotalMass = TotalMass.GetValueOrDefault(0) + (i?.Weight ?? 0);}
return TotalMass;
}
}


public static decimal? Get_AggregateVolume(this BO.ShippingOrder @this){using (new zAppDev.DotNet.Framework.Profiling.Profiler("ShippingOrder", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "Get_AggregateVolume")) {
decimal? TotalVolume = new decimal?();
foreach (var i in @this?.PlannedVolume ?? Enumerable.Empty<DSS3_LogisticsPoolingForUrbanDistribution.BO.CustomVolume>()) {
TotalVolume = TotalVolume.GetValueOrDefault(0) + (i?.VolumeComposition?.FirstOrDefault()?.VolumeComponent?.StandardVolume ?? 0) * (i?.VolumeComposition?.FirstOrDefault()?.Units ?? 0);}
zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Error, "ShippingOrder",  DSS3_LogisticsPoolingForUrbanDistribution.Hubs.EventsHub.RaiseDebugMessage, "Agregate " + TotalVolume.GetValueOrDefault(0));
return TotalVolume;
}
}


public static void ChangeStatus(this BO.ShippingOrder @this, string Status, string Description, int? Limit){using (new zAppDev.DotNet.Framework.Profiling.Profiler("ShippingOrder", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "ChangeStatus")) {
DSS3_LogisticsPoolingForUrbanDistribution.BO.StatusEvolution newStatus = new DSS3_LogisticsPoolingForUrbanDistribution.BO.StatusEvolution();
newStatus.Status = new DSS3_LogisticsPoolingForUrbanDistribution.DAL.Repository().GetAsQueryable<DSS3_LogisticsPoolingForUrbanDistribution.BO.Status>((a) => a.Code == Status)?.FirstOrDefault();newStatus.TimeChanged = DateTime.UtcNow;newStatus.User = zAppDev.DotNet.Framework.Identity.IdentityHelper.GetCurrentUserName();newStatus.Description = Description;var _var0 = @this?.Shipper;var _var1 = @this?.Carrier;foreach (var i in new DSS3_LogisticsPoolingForUrbanDistribution.DAL.Repository().Get<DSS3_LogisticsPoolingForUrbanDistribution.BO.StatusRule>((a) => a.Status.Code == Status && (a.Shipper == null || a.Shipper == _var0) && (a.Carrier == null || a.Carrier == _var1)) ?? Enumerable.Empty<DSS3_LogisticsPoolingForUrbanDistribution.BO.StatusRule>()) {
if ((Limit != null && Limit > (i?.Limit ?? 0))) {
zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Error, "ShippingOrder",  DSS3_LogisticsPoolingForUrbanDistribution.Hubs.EventsHub.RaiseDebugMessage, "working");
if ((i?.ForcedStatus != null)) {
newStatus.Status = i?.ForcedStatus;}
}
}
@this?.AddStatusEvolution(newStatus);
}
}



        
	}
}
