
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
	/// The ScheduledRoute extensions
	/// </summary>
	public static class ScheduledRouteExtensions
	{
        public static System.Collections.Generic.List<DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRoute> GetHistoricalRoutes(string GUID){using (new zAppDev.DotNet.Framework.Profiling.Profiler("ScheduledRoute", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "GetHistoricalRoutes")) {
return new DSS3_LogisticsPoolingForUrbanDistribution.DAL.Repository().Get<DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRoute>((x) => x.GUID == GUID);
}
}



        
	}
}
