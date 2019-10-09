// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

using System;
using System.Linq;
using System.Collections.Generic;
using log4net;
using System.Collections.ObjectModel;
using System.Data;

namespace DSS3_LogisticsPoolingForUrbanDistribution.BO.TemplateToRouteDataTransformation
{
    public class Transformer
    {

        #region Transformation 'ScheduledRouteTemplate_To_ScheduledRoute'





        // Left To Right

        private readonly Dictionary<DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRouteTemplate, DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRoute> ScheduledRouteTemplate_To_ScheduledRoute_Transformations = new Dictionary<DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRouteTemplate, DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRoute>();
        public DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRoute ScheduledRouteTemplate_To_ScheduledRoute(DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRouteTemplate domainScheduledRouteTemplateInput)
        {
            //Leave, if there is nothing to transform
            if(domainScheduledRouteTemplateInput == null) return default(DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRoute);
            // If the same Transformation has already ran, get the stored Output and return
            if(ScheduledRouteTemplate_To_ScheduledRoute_Transformations.ContainsKey(domainScheduledRouteTemplateInput))
            {
                return ScheduledRouteTemplate_To_ScheduledRoute_Transformations[domainScheduledRouteTemplateInput];
            }
            // Instantiate target root
            var domainScheduledRouteOutput = new DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRoute();
            ScheduledRouteTemplate_To_ScheduledRoute_Transformations.Add(domainScheduledRouteTemplateInput, domainScheduledRouteOutput);
            // ScheduledRouteTemplate.Origin to ScheduledRoute.Origin
            domainScheduledRouteOutput.Origin = domainScheduledRouteTemplateInput?.Origin;
            // ScheduledRouteTemplate.Destination to ScheduledRoute.Destination
            domainScheduledRouteOutput.Destination = domainScheduledRouteTemplateInput?.Destination;
            // ScheduledRouteTemplate.DaysOfWeek to ScheduledRoute.DaysOfWeek
            domainScheduledRouteOutput.DaysOfWeek = domainScheduledRouteTemplateInput?.DaysOfWeek;
            // ScheduledRouteTemplate.PricePerPallet to ScheduledRoute.PricePerPallet
            domainScheduledRouteOutput.PricePerPallet = domainScheduledRouteTemplateInput?.PricePerPallet;
            // ScheduledRouteTemplate.PricePerKilogram to ScheduledRoute.PricePerKilogram
            domainScheduledRouteOutput.PricePerKilogram = domainScheduledRouteTemplateInput?.PricePerKilogram;
            // ScheduledRouteTemplate.PricePerCubicMeter to ScheduledRoute.PricePerCubicMeter
            domainScheduledRouteOutput.PricePerCubicMeter = domainScheduledRouteTemplateInput?.PricePerCubicMeter;
            // ScheduledRouteTemplate.EffectiveFrom to ScheduledRoute.EffectiveFrom
            domainScheduledRouteOutput.EffectiveFrom = domainScheduledRouteTemplateInput?.EffectiveFrom;
            // ScheduledRouteTemplate.EffectiveTo to ScheduledRoute.EffectiveTo
            domainScheduledRouteOutput.EffectiveTo = domainScheduledRouteTemplateInput?.EffectiveTo;
            // ScheduledRouteTemplate.TypeOfGoods to ScheduledRoute.TypeOfGoods
            domainScheduledRouteOutput.TypeOfGoods = domainScheduledRouteTemplateInput?.TypeOfGoods ?? default(DSS3_LogisticsPoolingForUrbanDistribution.BO.TruckContent);
            // ScheduledRouteTemplate.Frequency to ScheduledRoute.Frequency
            domainScheduledRouteOutput.Frequency = domainScheduledRouteTemplateInput?.Frequency ?? default(DSS3_LogisticsPoolingForUrbanDistribution.BO.RouteFrequency);
            // ScheduledRouteTemplate.TotalAvailableCapacityKG to ScheduledRoute.TotalAvailableCapacityKG
            domainScheduledRouteOutput.TotalAvailableCapacityKG = domainScheduledRouteTemplateInput?.TotalAvailableCapacityKG;
            // ScheduledRouteTemplate.TotalAvailableCapacityLaden to ScheduledRoute.TotalAvailableCapacityLaden
            domainScheduledRouteOutput.TotalAvailableCapacityLaden = domainScheduledRouteTemplateInput?.TotalAvailableCapacityLaden;
            // ScheduledRouteTemplate.TotalAvailableCapacityM3 to ScheduledRoute.TotalAvailableCapacityM3
            domainScheduledRouteOutput.TotalAvailableCapacityM3 = domainScheduledRouteTemplateInput?.TotalAvailableCapacityM3;
            // ScheduledRouteTemplate.FixedPrice to ScheduledRoute.FixedPrice
            domainScheduledRouteOutput.FixedPrice = domainScheduledRouteTemplateInput?.FixedPrice;
            // ScheduledRouteTemplate.TruckPlate to ScheduledRoute.TruckPlate
            domainScheduledRouteOutput.TruckPlate = domainScheduledRouteTemplateInput?.TruckPlate;
            return domainScheduledRouteOutput;
        }

        // Left To Right with Existing Instance

        private readonly Dictionary<DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRouteTemplate, DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRoute> ScheduledRouteTemplate_To_ScheduledRoute_MappingTransformations = new Dictionary<DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRouteTemplate, DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRoute>();
        public DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRoute ScheduledRouteTemplate_To_ScheduledRoute(DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRouteTemplate domainScheduledRouteTemplateInput, DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRoute domainScheduledRouteInstance)
        {
            //Leave, if there is nothing to transform
            if(domainScheduledRouteTemplateInput == null) return default(DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRoute);
            if(domainScheduledRouteInstance == null)
                return ScheduledRouteTemplate_To_ScheduledRoute (domainScheduledRouteTemplateInput);
            // If the same Transformation has already ran, get the stored Output and return
            if(ScheduledRouteTemplate_To_ScheduledRoute_MappingTransformations.ContainsKey(domainScheduledRouteTemplateInput))
            {
                return ScheduledRouteTemplate_To_ScheduledRoute_MappingTransformations[domainScheduledRouteTemplateInput];
            }
            // Instantiate target root
            var domainScheduledRouteOutput = domainScheduledRouteInstance;
            ScheduledRouteTemplate_To_ScheduledRoute_MappingTransformations.Add(domainScheduledRouteTemplateInput, domainScheduledRouteOutput);
            // ScheduledRouteTemplate.Origin to ScheduledRoute.Origin
            domainScheduledRouteOutput.Origin = domainScheduledRouteTemplateInput?.Origin;
            // ScheduledRouteTemplate.Destination to ScheduledRoute.Destination
            domainScheduledRouteOutput.Destination = domainScheduledRouteTemplateInput?.Destination;
            // ScheduledRouteTemplate.DaysOfWeek to ScheduledRoute.DaysOfWeek
            domainScheduledRouteOutput.DaysOfWeek = domainScheduledRouteTemplateInput?.DaysOfWeek;
            // ScheduledRouteTemplate.PricePerPallet to ScheduledRoute.PricePerPallet
            domainScheduledRouteOutput.PricePerPallet = domainScheduledRouteTemplateInput?.PricePerPallet;
            // ScheduledRouteTemplate.PricePerKilogram to ScheduledRoute.PricePerKilogram
            domainScheduledRouteOutput.PricePerKilogram = domainScheduledRouteTemplateInput?.PricePerKilogram;
            // ScheduledRouteTemplate.PricePerCubicMeter to ScheduledRoute.PricePerCubicMeter
            domainScheduledRouteOutput.PricePerCubicMeter = domainScheduledRouteTemplateInput?.PricePerCubicMeter;
            // ScheduledRouteTemplate.EffectiveFrom to ScheduledRoute.EffectiveFrom
            domainScheduledRouteOutput.EffectiveFrom = domainScheduledRouteTemplateInput?.EffectiveFrom;
            // ScheduledRouteTemplate.EffectiveTo to ScheduledRoute.EffectiveTo
            domainScheduledRouteOutput.EffectiveTo = domainScheduledRouteTemplateInput?.EffectiveTo;
            // ScheduledRouteTemplate.TypeOfGoods to ScheduledRoute.TypeOfGoods
            domainScheduledRouteOutput.TypeOfGoods = domainScheduledRouteTemplateInput?.TypeOfGoods ?? default(DSS3_LogisticsPoolingForUrbanDistribution.BO.TruckContent);
            // ScheduledRouteTemplate.Frequency to ScheduledRoute.Frequency
            domainScheduledRouteOutput.Frequency = domainScheduledRouteTemplateInput?.Frequency ?? default(DSS3_LogisticsPoolingForUrbanDistribution.BO.RouteFrequency);
            // ScheduledRouteTemplate.TotalAvailableCapacityKG to ScheduledRoute.TotalAvailableCapacityKG
            domainScheduledRouteOutput.TotalAvailableCapacityKG = domainScheduledRouteTemplateInput?.TotalAvailableCapacityKG;
            // ScheduledRouteTemplate.TotalAvailableCapacityLaden to ScheduledRoute.TotalAvailableCapacityLaden
            domainScheduledRouteOutput.TotalAvailableCapacityLaden = domainScheduledRouteTemplateInput?.TotalAvailableCapacityLaden;
            // ScheduledRouteTemplate.TotalAvailableCapacityM3 to ScheduledRoute.TotalAvailableCapacityM3
            domainScheduledRouteOutput.TotalAvailableCapacityM3 = domainScheduledRouteTemplateInput?.TotalAvailableCapacityM3;
            // ScheduledRouteTemplate.FixedPrice to ScheduledRoute.FixedPrice
            domainScheduledRouteOutput.FixedPrice = domainScheduledRouteTemplateInput?.FixedPrice;
            // ScheduledRouteTemplate.TruckPlate to ScheduledRoute.TruckPlate
            domainScheduledRouteOutput.TruckPlate = domainScheduledRouteTemplateInput?.TruckPlate;
            return domainScheduledRouteOutput;
        }

        // Right To Left

        private readonly Dictionary<DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRoute, DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRouteTemplate> ScheduledRouteTemplate_To_ScheduledRouteReversed_Transformations = new Dictionary<DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRoute, DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRouteTemplate>();
        public DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRouteTemplate ScheduledRouteTemplate_To_ScheduledRouteReversed(DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRoute domainScheduledRouteInput)
        {
            //Leave, if there is nothing to transform
            if(domainScheduledRouteInput == null) return default(DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRouteTemplate);
            // If the same Transformation has already ran, get the stored Output and return
            if(ScheduledRouteTemplate_To_ScheduledRouteReversed_Transformations.ContainsKey(domainScheduledRouteInput))
            {
                return ScheduledRouteTemplate_To_ScheduledRouteReversed_Transformations[domainScheduledRouteInput];
            }
            // Instantiate target root
            var domainScheduledRouteTemplateOutput = new DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRouteTemplate();
            ScheduledRouteTemplate_To_ScheduledRouteReversed_Transformations.Add(domainScheduledRouteInput, domainScheduledRouteTemplateOutput);
            // ScheduledRoute.Origin to ScheduledRouteTemplate.Origin
            domainScheduledRouteTemplateOutput.Origin = domainScheduledRouteInput?.Origin;
            // ScheduledRoute.Destination to ScheduledRouteTemplate.Destination
            domainScheduledRouteTemplateOutput.Destination = domainScheduledRouteInput?.Destination;
            // ScheduledRoute.DaysOfWeek to ScheduledRouteTemplate.DaysOfWeek
            domainScheduledRouteTemplateOutput.DaysOfWeek = domainScheduledRouteInput?.DaysOfWeek;
            // ScheduledRoute.PricePerPallet to ScheduledRouteTemplate.PricePerPallet
            domainScheduledRouteTemplateOutput.PricePerPallet = domainScheduledRouteInput?.PricePerPallet;
            // ScheduledRoute.PricePerKilogram to ScheduledRouteTemplate.PricePerKilogram
            domainScheduledRouteTemplateOutput.PricePerKilogram = domainScheduledRouteInput?.PricePerKilogram;
            // ScheduledRoute.PricePerCubicMeter to ScheduledRouteTemplate.PricePerCubicMeter
            domainScheduledRouteTemplateOutput.PricePerCubicMeter = domainScheduledRouteInput?.PricePerCubicMeter;
            // ScheduledRoute.EffectiveFrom to ScheduledRouteTemplate.EffectiveFrom
            domainScheduledRouteTemplateOutput.EffectiveFrom = domainScheduledRouteInput?.EffectiveFrom;
            // ScheduledRoute.EffectiveTo to ScheduledRouteTemplate.EffectiveTo
            domainScheduledRouteTemplateOutput.EffectiveTo = domainScheduledRouteInput?.EffectiveTo;
            // ScheduledRoute.TypeOfGoods to ScheduledRouteTemplate.TypeOfGoods
            domainScheduledRouteTemplateOutput.TypeOfGoods = domainScheduledRouteInput?.TypeOfGoods ?? default(DSS3_LogisticsPoolingForUrbanDistribution.BO.TruckContent);
            // ScheduledRoute.Frequency to ScheduledRouteTemplate.Frequency
            domainScheduledRouteTemplateOutput.Frequency = domainScheduledRouteInput?.Frequency ?? default(DSS3_LogisticsPoolingForUrbanDistribution.BO.RouteFrequency);
            // ScheduledRoute.TotalAvailableCapacityKG to ScheduledRouteTemplate.TotalAvailableCapacityKG
            domainScheduledRouteTemplateOutput.TotalAvailableCapacityKG = domainScheduledRouteInput?.TotalAvailableCapacityKG;
            // ScheduledRoute.TotalAvailableCapacityLaden to ScheduledRouteTemplate.TotalAvailableCapacityLaden
            domainScheduledRouteTemplateOutput.TotalAvailableCapacityLaden = domainScheduledRouteInput?.TotalAvailableCapacityLaden;
            // ScheduledRoute.TotalAvailableCapacityM3 to ScheduledRouteTemplate.TotalAvailableCapacityM3
            domainScheduledRouteTemplateOutput.TotalAvailableCapacityM3 = domainScheduledRouteInput?.TotalAvailableCapacityM3;
            // ScheduledRoute.FixedPrice to ScheduledRouteTemplate.FixedPrice
            domainScheduledRouteTemplateOutput.FixedPrice = domainScheduledRouteInput?.FixedPrice;
            // ScheduledRoute.TruckPlate to ScheduledRouteTemplate.TruckPlate
            domainScheduledRouteTemplateOutput.TruckPlate = domainScheduledRouteInput?.TruckPlate;
            return domainScheduledRouteTemplateOutput;
        }

        // Right To Left with Existing Instance

        private readonly Dictionary<DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRoute, DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRouteTemplate> ScheduledRouteTemplate_To_ScheduledRouteReversed_MappingTransformations = new Dictionary<DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRoute, DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRouteTemplate>();
        public DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRouteTemplate ScheduledRouteTemplate_To_ScheduledRouteReversed(DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRoute domainScheduledRouteInput, DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRouteTemplate domainScheduledRouteTemplateInstance)
        {
            //Leave, if there is nothing to transform
            if(domainScheduledRouteInput == null) return default(DSS3_LogisticsPoolingForUrbanDistribution.BO.ScheduledRouteTemplate);
            if(domainScheduledRouteTemplateInstance == null)
                return ScheduledRouteTemplate_To_ScheduledRouteReversed (domainScheduledRouteInput);
            // If the same Transformation has already ran, get the stored Output and return
            if(ScheduledRouteTemplate_To_ScheduledRouteReversed_MappingTransformations.ContainsKey(domainScheduledRouteInput))
            {
                return ScheduledRouteTemplate_To_ScheduledRouteReversed_MappingTransformations[domainScheduledRouteInput];
            }
            // Instantiate target root
            var domainScheduledRouteTemplateOutput = domainScheduledRouteTemplateInstance;
            ScheduledRouteTemplate_To_ScheduledRouteReversed_MappingTransformations.Add(domainScheduledRouteInput, domainScheduledRouteTemplateOutput);
            // ScheduledRoute.Origin to ScheduledRouteTemplate.Origin
            domainScheduledRouteTemplateOutput.Origin = domainScheduledRouteInput?.Origin;
            // ScheduledRoute.Destination to ScheduledRouteTemplate.Destination
            domainScheduledRouteTemplateOutput.Destination = domainScheduledRouteInput?.Destination;
            // ScheduledRoute.DaysOfWeek to ScheduledRouteTemplate.DaysOfWeek
            domainScheduledRouteTemplateOutput.DaysOfWeek = domainScheduledRouteInput?.DaysOfWeek;
            // ScheduledRoute.PricePerPallet to ScheduledRouteTemplate.PricePerPallet
            domainScheduledRouteTemplateOutput.PricePerPallet = domainScheduledRouteInput?.PricePerPallet;
            // ScheduledRoute.PricePerKilogram to ScheduledRouteTemplate.PricePerKilogram
            domainScheduledRouteTemplateOutput.PricePerKilogram = domainScheduledRouteInput?.PricePerKilogram;
            // ScheduledRoute.PricePerCubicMeter to ScheduledRouteTemplate.PricePerCubicMeter
            domainScheduledRouteTemplateOutput.PricePerCubicMeter = domainScheduledRouteInput?.PricePerCubicMeter;
            // ScheduledRoute.EffectiveFrom to ScheduledRouteTemplate.EffectiveFrom
            domainScheduledRouteTemplateOutput.EffectiveFrom = domainScheduledRouteInput?.EffectiveFrom;
            // ScheduledRoute.EffectiveTo to ScheduledRouteTemplate.EffectiveTo
            domainScheduledRouteTemplateOutput.EffectiveTo = domainScheduledRouteInput?.EffectiveTo;
            // ScheduledRoute.TypeOfGoods to ScheduledRouteTemplate.TypeOfGoods
            domainScheduledRouteTemplateOutput.TypeOfGoods = domainScheduledRouteInput?.TypeOfGoods ?? default(DSS3_LogisticsPoolingForUrbanDistribution.BO.TruckContent);
            // ScheduledRoute.Frequency to ScheduledRouteTemplate.Frequency
            domainScheduledRouteTemplateOutput.Frequency = domainScheduledRouteInput?.Frequency ?? default(DSS3_LogisticsPoolingForUrbanDistribution.BO.RouteFrequency);
            // ScheduledRoute.TotalAvailableCapacityKG to ScheduledRouteTemplate.TotalAvailableCapacityKG
            domainScheduledRouteTemplateOutput.TotalAvailableCapacityKG = domainScheduledRouteInput?.TotalAvailableCapacityKG;
            // ScheduledRoute.TotalAvailableCapacityLaden to ScheduledRouteTemplate.TotalAvailableCapacityLaden
            domainScheduledRouteTemplateOutput.TotalAvailableCapacityLaden = domainScheduledRouteInput?.TotalAvailableCapacityLaden;
            // ScheduledRoute.TotalAvailableCapacityM3 to ScheduledRouteTemplate.TotalAvailableCapacityM3
            domainScheduledRouteTemplateOutput.TotalAvailableCapacityM3 = domainScheduledRouteInput?.TotalAvailableCapacityM3;
            // ScheduledRoute.FixedPrice to ScheduledRouteTemplate.FixedPrice
            domainScheduledRouteTemplateOutput.FixedPrice = domainScheduledRouteInput?.FixedPrice;
            // ScheduledRoute.TruckPlate to ScheduledRouteTemplate.TruckPlate
            domainScheduledRouteTemplateOutput.TruckPlate = domainScheduledRouteInput?.TruckPlate;
            return domainScheduledRouteTemplateOutput;
        }

        #endregion

    }
}