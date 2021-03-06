// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DSS3_LogisticsPoolingForUrbanDistribution.BO;
using DSS3_LogisticsPoolingForUrbanDistribution.UI.Controllers.NotFoundPage;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DSS3_LogisticsPoolingForUrbanDistribution.UI.ViewModels.MasterPageSignIn;
using DSS3_LogisticsPoolingForUrbanDistribution.UI.Controllers.MasterPageSignIn;
namespace DSS3_LogisticsPoolingForUrbanDistribution.UI.ViewModels.NotFoundPage
{
    public class NotFoundPageViewModel : MasterPageSignInViewModel
    {


        public NotFoundPageViewModel()
        {
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
        }

    }


    [OriginalType(typeof(DSS3_LogisticsPoolingForUrbanDistribution.UI.ViewModels.NotFoundPage.NotFoundPageViewModel))]
    public class NotFoundPageViewModelDTO : MasterPageSignInViewModelDTO, IViewModelDTO<DSS3_LogisticsPoolingForUrbanDistribution.UI.ViewModels.NotFoundPage.NotFoundPageViewModel>
    {

        [JsonConstructor]
        public NotFoundPageViewModelDTO() { }
        public NotFoundPageViewModelDTO(DSS3_LogisticsPoolingForUrbanDistribution.UI.ViewModels.NotFoundPage.NotFoundPageViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
        }
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS3_LogisticsPoolingForUrbanDistribution.UI.ViewModels.NotFoundPage.NotFoundPageViewModel).FullName;

        public new DSS3_LogisticsPoolingForUrbanDistribution.UI.ViewModels.NotFoundPage.NotFoundPageViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS3_LogisticsPoolingForUrbanDistribution.UI.ViewModels.NotFoundPage.NotFoundPageViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DSS3_LogisticsPoolingForUrbanDistribution.UI.ViewModels.NotFoundPage.NotFoundPageViewModel();
        }
        new  public DSS3_LogisticsPoolingForUrbanDistribution.UI.ViewModels.NotFoundPage.NotFoundPageViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS3_LogisticsPoolingForUrbanDistribution.UI.ViewModels.NotFoundPage.NotFoundPageViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS3_LogisticsPoolingForUrbanDistribution.UI.ViewModels.NotFoundPage.NotFoundPageViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
        }
    }



}
