
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
	/// The FileData extensions
	/// </summary>
	public static class FileDataExtensions
	{
        public static string GetAbsolutePath(this BO.FileData @this){using (new zAppDev.DotNet.Framework.Profiling.Profiler("FileData", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "GetAbsolutePath")) {
if ((@this?.StorageMedium == DSS3_LogisticsPoolingForUrbanDistribution.BO.StorageMedium.DataBase)) {
return null;
}
string relativePath = System.IO.Path.Combine((@this?.FolderPath ?? ""), (@this?.FileName ?? ""));
return zAppDev.DotNet.Framework.Utilities.Web.MapPath(System.IO.Path.Combine("~/App_Data/Uploads", relativePath));
}
}


public static System.Collections.Generic.List<System.Byte> GetThumbnail(this BO.FileData @this, int? width, int? height){using (new zAppDev.DotNet.Framework.Profiling.Profiler("FileData", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "GetThumbnail")) {
if ((@this?.StorageMedium == DSS3_LogisticsPoolingForUrbanDistribution.BO.StorageMedium.DataBase)) {
return zAppDev.DotNet.Framework.Utilities.Imaging.GetThumbnail(@this?.Blob, (width).GetValueOrDefault(0), (height).GetValueOrDefault(0));;
}
else {
System.Byte[] image = System.IO.File.ReadAllBytes((@this?.GetAbsolutePath() ?? ""));
return zAppDev.DotNet.Framework.Utilities.Imaging.GetThumbnail(image, (width).GetValueOrDefault(0), (height).GetValueOrDefault(0));;
}
}
}



        
	}
}
