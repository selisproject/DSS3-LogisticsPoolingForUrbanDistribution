
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
	/// The Shipment extensions
	/// </summary>
	public static class ShipmentExtensions
	{
        public static string Get_CurrentStatus(this BO.Shipment @this){using (new zAppDev.DotNet.Framework.Profiling.Profiler("Shipment", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "Get_CurrentStatus")) {
if ((@this?.ShipmentStatus?.OrderByDescending((a) => a.TimeReported).FirstOrDefault() != null && @this?.ShipmentStatus?.OrderByDescending((a) => a.TimeReported).FirstOrDefault()?.Status != null)) {
return (@this?.ShipmentStatus?.OrderByDescending((a) => a.TimeReported).FirstOrDefault()?.Status?.Description ?? "");
}
return null;
}
}


public static decimal? MaxVolume(this BO.Shipment @this){using (new zAppDev.DotNet.Framework.Profiling.Profiler("Shipment", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "MaxVolume")) {
return (@this?.Path?.Max((a) => a.CurrentLoad) ?? 0);
}
}


public static decimal? Get_AverageVolume(this BO.Shipment @this){using (new zAppDev.DotNet.Framework.Profiling.Profiler("Shipment", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "Get_AverageVolume")) {
return ((@this?.Path?.Sum((a) => a.CurrentLoad) ?? 0) / (@this?.Path?.Count() ?? 0)) / (@this?.TotalVolume ?? 0);
}
}


public static System.Collections.Generic.List<decimal?> GetVolumeSpread(this BO.Shipment @this){using (new zAppDev.DotNet.Framework.Profiling.Profiler("Shipment", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "GetVolumeSpread")) {
return @this?.Path?.Select((a) => a.CurrentLoad).ToList();
}
}


public static bool OrderFits(this BO.Shipment @this, DSS3_LogisticsPoolingForUrbanDistribution.BO.ShippingOrder Order){using (new zAppDev.DotNet.Framework.Profiling.Profiler("Shipment", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "OrderFits")) {
return (@this?.MaxVolume() ?? 0) + (Order?.Get_AggregateVolume() ?? 0) <= (@this?.TotalVolume ?? 0);
}
}


public static void PrintPath(this BO.Shipment @this, string Prefix){using (new zAppDev.DotNet.Framework.Profiling.Profiler("Shipment", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "PrintPath")) {
int? count1 = 0;
foreach (var j in @this?.Path ?? Enumerable.Empty<DSS3_LogisticsPoolingForUrbanDistribution.BO.Point>()) {
zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Error, "Shipment",  DSS3_LogisticsPoolingForUrbanDistribution.Hubs.EventsHub.RaiseDebugMessage, Prefix + " - " + count1.GetValueOrDefault(0) + " - " + ( new DSS3_LogisticsPoolingForUrbanDistribution.DAL.Repository().GetById<DSS3_LogisticsPoolingForUrbanDistribution.BO.Location>((j?.LocId ?? 0))?.Name ?? ""));
count1 = count1.GetValueOrDefault(0) + 1;}
}
}


public static System.Collections.Generic.List<DSS3_LogisticsPoolingForUrbanDistribution.BO.CostSplit> GetCostSplit(this BO.Shipment @this, int? WeightVolume, int? WeightPoints, int? WeightPath){using (new zAppDev.DotNet.Framework.Profiling.Profiler("Shipment", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "GetCostSplit")) {
return null;
}
}


public static decimal? CalculatePathTime(this BO.Shipment @this){using (new zAppDev.DotNet.Framework.Profiling.Profiler("Shipment", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "CalculatePathTime")) {
System.Collections.Generic.List<string> coordinates = new System.Collections.Generic.List<string>();
coordinates.Add((@this?.DeparturePoint?.Coordinates?.CoordinateY ?? 0) + "," + (@this?.DeparturePoint?.Coordinates?.CoordinateX ?? 0));
zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Error, "Shipment",  DSS3_LogisticsPoolingForUrbanDistribution.Hubs.EventsHub.RaiseDebugMessage, coordinates.FirstOrDefault());
foreach (var i in @this?.ShippingOrders ?? Enumerable.Empty<DSS3_LogisticsPoolingForUrbanDistribution.BO.ShippingOrder>()) {
string departure = (i?.DeparturePoint?.Coordinates?.CoordinateY ?? 0) + "," + (i?.DeparturePoint?.Coordinates?.CoordinateX ?? 0);
string arrival = (i?.ArrivalPoint?.Coordinates?.CoordinateY ?? 0) + "," + (i?.ArrivalPoint?.Coordinates?.CoordinateX ?? 0);
if ((((coordinates.Contains(departure)) == false) && i?.DeparturePoint != @this?.FinalDestination)) {
coordinates.Add(departure);
}
if ((((coordinates.Contains(arrival)) == false) && i?.ArrivalPoint != @this?.FinalDestination)) {
coordinates.Add(arrival);
}
}
string FinalCoordinate = (@this?.FinalDestination?.Coordinates?.CoordinateY ?? 0) + "," + (@this?.FinalDestination?.Coordinates?.CoordinateX ?? 0);
coordinates.Add(FinalCoordinate);
while ((coordinates.Contains("0,0"))) {
coordinates.Remove("0,0");
}
string coord = "";
foreach (var i in coordinates ?? Enumerable.Empty<string>()) {
if (coord == "") {
coord = coord + i;}
else {
coord = coord + "," + i;}
}
DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.Router_Mapotempo.Router_MapotempoRoot response = DSS3_LogisticsPoolingForUrbanDistribution.BLL.ExternalRestServices.Router_MapotempoRestService.route("time", "true", "true", "true", "200", "EUR", "en", coord, "inlecom-1-pe3io4Ui5aimobich1oot0eilothongo");
return ((zAppDev.DotNet.Framework.Utilities.Common.GetItemFromArray(response.features, 0)).properties.router.total_time / 60 + 10 * coordinates.Count()) / 60;
}
}


public static decimal? CalculatePathDistance(this BO.Shipment @this){using (new zAppDev.DotNet.Framework.Profiling.Profiler("Shipment", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "CalculatePathDistance")) {
System.Collections.Generic.List<string> coordinates = new System.Collections.Generic.List<string>();
coordinates.Add((@this?.DeparturePoint?.Coordinates?.CoordinateY ?? 0) + "," + (@this?.DeparturePoint?.Coordinates?.CoordinateX ?? 0));
zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Error, "Shipment",  DSS3_LogisticsPoolingForUrbanDistribution.Hubs.EventsHub.RaiseDebugMessage, coordinates.FirstOrDefault());
foreach (var i in @this?.ShippingOrders ?? Enumerable.Empty<DSS3_LogisticsPoolingForUrbanDistribution.BO.ShippingOrder>()) {
string departure = (i?.DeparturePoint?.Coordinates?.CoordinateY ?? 0) + "," + (i?.DeparturePoint?.Coordinates?.CoordinateX ?? 0);
string arrival = (i?.ArrivalPoint?.Coordinates?.CoordinateY ?? 0) + "," + (i?.ArrivalPoint?.Coordinates?.CoordinateX ?? 0);
if ((((coordinates.Contains(departure)) == false) && i?.DeparturePoint != @this?.FinalDestination)) {
coordinates.Add(departure);
}
if ((((coordinates.Contains(arrival)) == false) && i?.ArrivalPoint != @this?.FinalDestination)) {
coordinates.Add(arrival);
}
}
string FinalCoordinate = (@this?.FinalDestination?.Coordinates?.CoordinateY ?? 0) + "," + (@this?.FinalDestination?.Coordinates?.CoordinateX ?? 0);
coordinates.Add(FinalCoordinate);
while ((coordinates.Contains("0,0"))) {
coordinates.Remove("0,0");
}
string coord = "";
foreach (var i in coordinates ?? Enumerable.Empty<string>()) {
if (coord == "") {
coord = coord + i;}
else {
coord = coord + "," + i;}
}
DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.Router_Mapotempo.Router_MapotempoRoot response = DSS3_LogisticsPoolingForUrbanDistribution.BLL.ExternalRestServices.Router_MapotempoRestService.route("time", "true", "true", "true", "200", "EUR", "en", coord, "inlecom-1-pe3io4Ui5aimobich1oot0eilothongo");
return (zAppDev.DotNet.Framework.Utilities.Common.GetItemFromArray(response.features, 0)).properties.router.total_distance / 1000;
}
}


public static decimal? CalculatePathCost(this BO.Shipment @this, System.Collections.Generic.List<DSS3_LogisticsPoolingForUrbanDistribution.BO.ShippingOrder> Orders){using (new zAppDev.DotNet.Framework.Profiling.Profiler("Shipment", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "CalculatePathCost")) {
System.Collections.Generic.List<string> coordinates = new System.Collections.Generic.List<string>();
coordinates.Add((@this?.DeparturePoint?.Coordinates?.CoordinateY ?? 0) + "," + (@this?.DeparturePoint?.Coordinates?.CoordinateX ?? 0));
zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Error, "Shipment",  DSS3_LogisticsPoolingForUrbanDistribution.Hubs.EventsHub.RaiseDebugMessage, coordinates.FirstOrDefault());
foreach (var i in Orders ?? Enumerable.Empty<DSS3_LogisticsPoolingForUrbanDistribution.BO.ShippingOrder>()) {
string departure = (i?.DeparturePoint?.Coordinates?.CoordinateY ?? 0) + "," + (i?.DeparturePoint?.Coordinates?.CoordinateX ?? 0);
string arrival = (i?.ArrivalPoint?.Coordinates?.CoordinateY ?? 0) + "," + (i?.ArrivalPoint?.Coordinates?.CoordinateX ?? 0);
if ((((coordinates.Contains(departure)) == false) && i?.DeparturePoint != @this?.FinalDestination)) {
coordinates.Add(departure);
}
if ((((coordinates.Contains(arrival)) == false) && i?.ArrivalPoint != @this?.FinalDestination)) {
coordinates.Add(arrival);
}
}
string FinalCoordinate = (@this?.FinalDestination?.Coordinates?.CoordinateY ?? 0) + "," + (@this?.FinalDestination?.Coordinates?.CoordinateX ?? 0);
coordinates.Add(FinalCoordinate);
while ((coordinates.Contains("0,0"))) {
coordinates.Remove("0,0");
}
string coord = "";
foreach (var i in coordinates ?? Enumerable.Empty<string>()) {
if (coord == "") {
coord = coord + i;}
else {
coord = coord + "," + i;}
}
DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.Router_Mapotempo.Router_MapotempoRoot response = DSS3_LogisticsPoolingForUrbanDistribution.BLL.ExternalRestServices.Router_MapotempoRestService.route("time", "true", "true", "true", "200", "EUR", "en", coord, "inlecom-1-pe3io4Ui5aimobich1oot0eilothongo");
zAppDev.DotNet.Framework.Utilities.Serializer<DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.Router_Mapotempo.Router_MapotempoRoot> serializer = new zAppDev.DotNet.Framework.Utilities.Serializer<DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.Router_Mapotempo.Router_MapotempoRoot>();
zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Info, "Shipment",  DSS3_LogisticsPoolingForUrbanDistribution.Hubs.EventsHub.RaiseDebugMessage, serializer.ToJson(response));
decimal? time = (zAppDev.DotNet.Framework.Utilities.Common.GetItemFromArray(response.features, 0)).properties.router.total_time / 3600;
decimal? distance = (zAppDev.DotNet.Framework.Utilities.Common.GetItemFromArray(response.features, 0)).properties.router.total_distance / 1000;
decimal? DistanceCost = distance.GetValueOrDefault(0) * (@this?.VehiculeType?.CalculatedDistanceCost ?? 0);
decimal? TimeCost = time.GetValueOrDefault(0) * (@this?.VehiculeType?.CalculatedTimeCost ?? 0);
decimal? TotalCost = new decimal?();
if (@this?.VehiculeType?.AmortizationType1?.Label == "technical") {
TotalCost = TimeCost.GetValueOrDefault(0) + DistanceCost.GetValueOrDefault(0) + (@this?.VehiculeType?.CalculatedOwnershipCost ?? 0) * distance.GetValueOrDefault(0);}
else {
TotalCost = TimeCost.GetValueOrDefault(0) + DistanceCost.GetValueOrDefault(0) + (@this?.VehiculeType?.CalculatedOwnershipCost ?? 0) * time.GetValueOrDefault(0);}
TotalCost = TotalCost.GetValueOrDefault(0) * (1 + (@this?.VehiculeType?.OverHeadCost ?? 0) / 100);return TotalCost;
}
}



        
	}
}
