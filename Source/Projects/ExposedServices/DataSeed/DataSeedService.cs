// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Channels;
using System.Security.Permissions;
using System.Security.Principal;
using NHibernate;
using System.ServiceModel.Activation;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using DSS3_LogisticsPoolingForUrbanDistribution.Services.DataSeed.DataContracts;
using DSS3_LogisticsPoolingForUrbanDistribution.BO;
using AutoMapper;

namespace DSS3_LogisticsPoolingForUrbanDistribution.Services
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class DataSeedService : IDataSeedService
    {
        public void Orders(DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderWMS[] _orders, string _RequestSourceIp, string _UserName)
        {
            InitializeMappers();
            try
            {
                var inputorders = _orders;
                OrdersImplementation(inputorders);
            }
            catch (Exception @exception)
            {
                log4net.LogManager.GetLogger("DataSeed Service").Error(@exception);
                throw;
            }
        }
        public void InitRegionalAgents(string _RequestSourceIp, string _UserName)
        {
            InitializeMappers();
            try
            {
                InitRegionalAgentsImplementation();
            }
            catch (Exception @exception)
            {
                log4net.LogManager.GetLogger("DataSeed Service").Error(@exception);
                throw;
            }
        }
        public void Change(string _RequestSourceIp, string _UserName)
        {
            InitializeMappers();
            try
            {
                ChangeImplementation();
            }
            catch (Exception @exception)
            {
                log4net.LogManager.GetLogger("DataSeed Service").Error(@exception);
                throw;
            }
        }
        public void TestGoogleAPI(string _RequestSourceIp, string _UserName)
        {
            InitializeMappers();
            try
            {
                TestGoogleAPIImplementation();
            }
            catch (Exception @exception)
            {
                log4net.LogManager.GetLogger("DataSeed Service").Error(@exception);
                throw;
            }
        }
        public void initWarehouse(string _RequestSourceIp, string _UserName)
        {
            InitializeMappers();
            try
            {
                initWarehouseImplementation();
            }
            catch (Exception @exception)
            {
                log4net.LogManager.GetLogger("DataSeed Service").Error(@exception);
                throw;
            }
        }
        public System.Collections.Generic.List<OrderWMSDTO> testOrderGenerator(string _RequestSourceIp, string _UserName)
        {
            InitializeMappers();
            try
            {
                var _exposedOperation = testOrderGeneratorImplementation();
                var result = Mapper.Map<System.Collections.Generic.List<DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderWMS>, System.Collections.Generic.List<OrderWMSDTO>>(_exposedOperation);
                return result;
            }
            catch (Exception @exception)
            {
                log4net.LogManager.GetLogger("DataSeed Service").Error(@exception);
                throw;
            }
        }
        public System.Collections.Generic.List<PubMessageDTO> testReflection(string _RequestSourceIp, string _UserName)
        {
            InitializeMappers();
            try
            {
                var _exposedOperation = testReflectionImplementation();
                var result = Mapper.Map<System.Collections.Generic.List<DSS3_LogisticsPoolingForUrbanDistribution.BO.PubMessage>, System.Collections.Generic.List<PubMessageDTO>>(_exposedOperation);
                return result;
            }
            catch (Exception @exception)
            {
                log4net.LogManager.GetLogger("DataSeed Service").Error(@exception);
                throw;
            }
        }
        public void TruckPosistions(string _RequestSourceIp, string _UserName)
        {
            InitializeMappers();
            try
            {
                TruckPosistionsImplementation();
            }
            catch (Exception @exception)
            {
                log4net.LogManager.GetLogger("DataSeed Service").Error(@exception);
                throw;
            }
        }


        private void InitializeMappers()
        {
            Mapper.CreateMap<OrderWMSDTO, DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderWMS>();
            Mapper.CreateMap<DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderWMS, OrderWMSDTO>();
            Mapper.CreateMap<PubMessageDTO, DSS3_LogisticsPoolingForUrbanDistribution.BO.PubMessage>();
            Mapper.CreateMap<DSS3_LogisticsPoolingForUrbanDistribution.BO.PubMessage, PubMessageDTO>();
            Mapper.CreateMap<TruckDTO, DSS3_LogisticsPoolingForUrbanDistribution.BO.Truck>();
            Mapper.CreateMap<DSS3_LogisticsPoolingForUrbanDistribution.BO.Truck, TruckDTO>();
        }

        public static void OrdersImplementation(DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderWMS[] orders)
        {
            zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Info, "API",  DSS3_LogisticsPoolingForUrbanDistribution.Hubs.EventsHub.RaiseDebugMessage, "Communication started ");
            zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Info, "API",  DSS3_LogisticsPoolingForUrbanDistribution.Hubs.EventsHub.RaiseDebugMessage, "Started insertion of " + orders.Length.ToString() + " on " + DateTime.UtcNow.ToString());
            DSS3_LogisticsPoolingForUrbanDistribution.Services.RAService.GetRAImplementation("test");
            try
            {
                foreach (var order in orders ?? Enumerable.Empty<DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderWMS>())
                {
                    order.Id = 0;
                    new DSS3_LogisticsPoolingForUrbanDistribution.DAL.Repository().Save<DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderWMS>(order);
                }
            }
            catch (System.Exception x)
            {
                zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Error, "API",  DSS3_LogisticsPoolingForUrbanDistribution.Hubs.EventsHub.RaiseDebugMessage, x);
            }
        }

        public static void InitRegionalAgentsImplementation()
        {
            try
            {
                foreach (var order in new DSS3_LogisticsPoolingForUrbanDistribution.DAL.Repository().GetAll<DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderWMS>() ?? Enumerable.Empty<DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderWMS>())
                {
                    string racode = (order?.OrdAgencyCode ?? "");
                    DSS3_LogisticsPoolingForUrbanDistribution.BO.RegionalAgent ra = new DSS3_LogisticsPoolingForUrbanDistribution.DAL.Repository().GetAsQueryable<DSS3_LogisticsPoolingForUrbanDistribution.BO.RegionalAgent>((r) => r.AgencyCode == racode)?.FirstOrDefault();
                    if ((ra == null))
                    {
                        ra = new DSS3_LogisticsPoolingForUrbanDistribution.BO.RegionalAgent();
                        ra.AgencyCode = racode;
                        ra.AgencyAddress = (order?.OrdAgencyAddress ?? "");
                        ra.AgencyDescription = (order?.OrdAgencyDescr ?? "");
                        new DSS3_LogisticsPoolingForUrbanDistribution.DAL.Repository().Save<DSS3_LogisticsPoolingForUrbanDistribution.BO.RegionalAgent>(ra);
                    }
                }
            }
            catch (System.Exception x)
            {
                throw x;
                zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Error, "API",  DSS3_LogisticsPoolingForUrbanDistribution.Hubs.EventsHub.RaiseDebugMessage, x);
            }
        }

        public static void ChangeImplementation()
        {
            try
            {
                foreach (var order in new DSS3_LogisticsPoolingForUrbanDistribution.DAL.Repository().GetAll<DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderWMS>() ?? Enumerable.Empty<DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderWMS>())
                {
                    int? r = zAppDev.DotNet.Framework.Utilities.Common.Random.Next(1, 100);
                    order.OrdDeliveryValue = float.Parse((r?.ToString() ?? ""), System.Globalization.NumberStyles.Number | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture);
                    new DSS3_LogisticsPoolingForUrbanDistribution.DAL.Repository().Update<DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderWMS>(order);
                }
            }
            catch (System.Exception x)
            {
                throw x;
                zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Error, "API",  DSS3_LogisticsPoolingForUrbanDistribution.Hubs.EventsHub.RaiseDebugMessage, x);
            }
        }

        public static void TestGoogleAPIImplementation()
        {
            DSS3_LogisticsPoolingForUrbanDistribution.BO.RegionalAgentExtensions.InitAddressGeocoordinates();
        }

        public static void initWarehouseImplementation()
        {
            DSS3_LogisticsPoolingForUrbanDistribution.BO.WarehouseExtensions.InitWarehouse();
        }

        public static System.Collections.Generic.List<DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderWMS> testOrderGeneratorImplementation()
        {
            return DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderGeneratorExtensions.GenerateOrders(10);
        }

        public static System.Collections.Generic.List<DSS3_LogisticsPoolingForUrbanDistribution.BO.PubMessage> testReflectionImplementation()
        {
            var _count0 = 0;
            DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderWMS order = zAppDev.DotNet.Framework.Utilities.Common.GetItemFromList(new DSS3_LogisticsPoolingForUrbanDistribution.DAL.Repository().GetAll<DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderWMS>(01, 10,out _count0), 3);
            return DSS3_LogisticsPoolingForUrbanDistribution.BO.UtilsExtensions.InitPubMessage(order);
        }

        public static void TruckPosistionsImplementation()
        {
            DSS3_LogisticsPoolingForUrbanDistribution.BO.UtilsExtensions.InitTruckPositions();
        }


    }
}