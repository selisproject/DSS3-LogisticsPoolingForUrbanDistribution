
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
	/// The OrderStatistics extensions
	/// </summary>
	public static class OrderStatisticsExtensions
	{
        public static void Initialize(){using (new zAppDev.DotNet.Framework.Profiling.Profiler("OrderStatistics", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "Initialize")) {
DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderStatistics stats = new DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderStatistics();
stats.TotalAsOrdered = (new DSS3_LogisticsPoolingForUrbanDistribution.DAL.Repository().GetAsQueryable<DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderWMS>()?.Where((x) => x.ProofOfDelivery != null && x.ProofOfDelivery.QualityStatus == "As Ordered").Count() ?? 0);stats.TotalDeliveries = new DSS3_LogisticsPoolingForUrbanDistribution.DAL.Repository().GetCount<DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderWMS>();stats.TotalInFull = (new DSS3_LogisticsPoolingForUrbanDistribution.DAL.Repository().GetAsQueryable<DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderWMS>()?.Where((y) => y.ProofOfDelivery != null && y.ProofOfDelivery.QuantityStatus == "In Full").Count() ?? 0);stats.TotalOnTime = (new DSS3_LogisticsPoolingForUrbanDistribution.DAL.Repository().GetAsQueryable<DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderWMS>()?.Where((z) => z.ProofOfDelivery != null && z.ProofOfDelivery.DeliveryStatus == "On Time").Count() ?? 0);stats.TotalImpeachments = (new DSS3_LogisticsPoolingForUrbanDistribution.DAL.Repository().GetAsQueryable<DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderWMS>()?.Where((y) => y.ProofOfDelivery != null && (y.ProofOfDelivery.DeliveryStatus != "On Time" || y.ProofOfDelivery.QuantityStatus != "In Full" || y.ProofOfDelivery.QualityStatus != "As Ordered")).Count() ?? 0);}
}


public static System.Collections.Generic.List<DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderStatistics> GetStats(){using (new zAppDev.DotNet.Framework.Profiling.Profiler("OrderStatistics", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "GetStats")) {
return new DSS3_LogisticsPoolingForUrbanDistribution.DAL.Repository().GetAll<DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderStatistics>();
}
}



        
	}
}
