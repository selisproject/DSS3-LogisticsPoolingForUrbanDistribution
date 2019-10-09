// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using FluentNHibernate.Testing;
using DSS3_LogisticsPoolingForUrbanDistribution.BO;
using DSS3_LogisticsPoolingForUrbanDistribution.BoTesting.Tests.Common;
using DSS3_LogisticsPoolingForUrbanDistribution.DAL;

namespace DSS3_LogisticsPoolingForUrbanDistribution.BoTesting.Tests
{
    /// <summary>
    ///This is a test class for OrderWMSTest and is intended
    ///to contain all OrderWMSTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("OrderWMS Repository Tests")]
    [Category("OrderWMS Repository Tests")]
    internal class OrderWMSTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `OrderWMS`")]
        [Order(0)]
        public void OrderWMS_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _order_proofofdelivery_orderwms = new DSS3_LogisticsPoolingForUrbanDistribution.BO.ProofOfDelivery
            {
                DateIssued = now,
                PODNumber = 3904,
                QualityStatus = "ProofOfDelivery_QualityStatus",
                QuantityStatus = "ProofOfDelivery_QuantityStatus",
                DeliveryStatus = "ProofOfDelivery_DeliveryStatus",
                PODAttachment = "ProofOfDelivery_PODAttachment",
                Comments = "ProofOfDelivery_Comments",
                DamagedPackaging = true,
                DamagedProducts = true,
                CloseToExpiry = true,
            };
            new PersistenceSpecification<DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderWMS>(Session)
            .CheckProperty(p => p.OrdID, 9106)
            .CheckProperty(p => p.OrdOrderID_Remote, 9568)
            .CheckProperty(p => p.OrdOrderExternalCode, "OrderWMS_OrdOrderExternalCode")
            .CheckProperty(p => p.OrdOrderDescr, "OrderWMS_OrdOrderDescr")
            .CheckProperty(p => p.OrdRegDateTime, now)
            .CheckProperty(p => p.OrdDateTime, now)
            .CheckProperty(p => p.OrdDeliveryDateTime, now)
            .CheckProperty(p => p.OrdDepositorCode, "OrderWMS_OrdDepositorCode")
            .CheckProperty(p => p.OrdDepositorFullName, "OrderWMS_OrdDepositorFullName")
            .CheckProperty(p => p.OrdCustomerCode, "OrderWMS_OrdCustomerCode")
            .CheckProperty(p => p.OrdCustomerFullName, "OrderWMS_OrdCustomerFullName")
            .CheckProperty(p => p.OrdStatus, 3543)
            .CheckProperty(p => p.OrdMemo, "OrderWMS_OrdMemo")
            .CheckProperty(p => p.OrdPurpose, "OrderWMS_OrdPurpose")
            .CheckProperty(p => p.OrdDeliveryValue, 222.222f)
            .CheckProperty(p => p.OrdDeliveryNotes, "OrderWMS_OrdDeliveryNotes")
            .CheckProperty(p => p.OrdIsReturn, 5583)
            .CheckProperty(p => p.OrdPrdTypeDescr, "OrderWMS_OrdPrdTypeDescr")
            .CheckProperty(p => p.OrdWrhRoutingCode, "OrderWMS_OrdWrhRoutingCode")
            .CheckProperty(p => p.OrdDlsId, 3628)
            .CheckProperty(p => p.OrdDlsDescr, "OrderWMS_OrdDlsDescr")
            .CheckProperty(p => p.OrdDlsAddress, "OrderWMS_OrdDlsAddress")
            .CheckProperty(p => p.OrdDlsZipCode, "OrderWMS_OrdDlsZipCode")
            .CheckProperty(p => p.OrdDlsCity, "OrderWMS_OrdDlsCity")
            .CheckProperty(p => p.OrdDlsArea, "OrderWMS_OrdDlsArea")
            .CheckProperty(p => p.OrdRoutingStatus, 9387)
            .CheckProperty(p => p.OrdLfdWeight, 222.222f)
            .CheckProperty(p => p.OrdLfdVol, 222.222f)
            .CheckProperty(p => p.OrdLfdCtn, 4903)
            .CheckProperty(p => p.OrdLfdBar, 1821)
            .CheckProperty(p => p.OrdLfdPalEuro, 565)
            .CheckProperty(p => p.OrdLfdPalInd, 7644)
            .CheckProperty(p => p.OrdLfdPalElsa, 53)
            .CheckProperty(p => p.OrdLfdParOU, 9919)
            .CheckProperty(p => p.OrdLfdVar, 1339)
            .CheckProperty(p => p.OrdVoucherDateTime, now)
            .CheckProperty(p => p.OrdVoucherNumber, "OrderWMS_OrdVoucherN")
            .CheckProperty(p => p.OrdVoucherSeries, "OrderWMS_OrdVoucherS")
            .CheckProperty(p => p.OrdVoucherId, 1794)
            .CheckProperty(p => p.OrdAgencyCode, "OrderWMS_OrdAgencyCode")
            .CheckProperty(p => p.OrdAgencyDescr, "OrderWMS_OrdAgencyDescr")
            .CheckProperty(p => p.OrdAgencyAddress, "OrderWMS_OrdAgencyAddress")
            .CheckProperty(p => p.OrdTelRouteId, 3043)
            .CheckProperty(p => p.OrdVchPlateNr, "OrderWMS_OrdVchPlateNr")
            .CheckProperty(p => p.OrdVchRouteNr, 1500)
            .CheckProperty(p => p.OrdVhrDate, now)
            .CheckProperty(p => p.OrdVhrID, 1766)
            .CheckProperty(p => p.OrdLastUpdateDateTime, now)
            .CheckProperty(p => p.OrdReadyForLoading, 7893)
            .CheckProperty(p => p.Polyline, "OrderWMS_Polyline")
            .CheckProperty(p => p.Warehouse, "OrderWMS_Warehouse")
            .CheckProperty(p => p.Truck, "OrderWMS_Truck")
            .CheckProperty(p => p.WarehouseAddress, "OrderWMS_WarehouseAddress")
            .CheckProperty(p => p.ETA, "OrderWMS_ETA")
            .CheckProperty(p => p.ATA, now)
            .CheckProperty(p => p.DestLat, 222.222f)
            .CheckProperty(p => p.DestLong, 222.222f)
            .CheckProperty(p => p.COE, 222.222f)
            .CheckReference(p => p.ProofOfDelivery, _order_proofofdelivery_orderwms)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `OrderWMS`")]
        [Order(1)]
        public void OrderWMS_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderWMS> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderWMS>(
                              a => true
                              && (a.OrdID + 123 > 0)
                              && (a.OrdOrderID_Remote + 123 > 0)
                              && (a.OrdOrderExternalCode != string.Empty && a.OrdOrderExternalCode != null)
                              && (a.OrdOrderDescr != string.Empty && a.OrdOrderDescr != null)
                              && a.OrdRegDateTime.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && a.OrdDateTime.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && a.OrdDeliveryDateTime.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && (a.OrdDepositorCode != string.Empty && a.OrdDepositorCode != null)
                              && (a.OrdDepositorFullName != string.Empty && a.OrdDepositorFullName != null)
                              && (a.OrdCustomerCode != string.Empty && a.OrdCustomerCode != null)
                              && (a.OrdCustomerFullName != string.Empty && a.OrdCustomerFullName != null)
                              && (a.OrdStatus + 123 > 0)
                              && (a.OrdMemo != string.Empty && a.OrdMemo != null)
                              && (a.OrdPurpose != string.Empty && a.OrdPurpose != null)
                              && (a.OrdDeliveryValue + 123 > 0)
                              && (a.OrdDeliveryNotes != string.Empty && a.OrdDeliveryNotes != null)
                              && (a.OrdIsReturn + 123 > 0)
                              && (a.OrdPrdTypeDescr != string.Empty && a.OrdPrdTypeDescr != null)
                              && (a.OrdWrhRoutingCode != string.Empty && a.OrdWrhRoutingCode != null)
                              && (a.OrdDlsId + 123 > 0)
                              && (a.OrdDlsDescr != string.Empty && a.OrdDlsDescr != null)
                              && (a.OrdDlsAddress != string.Empty && a.OrdDlsAddress != null)
                              && (a.OrdDlsZipCode != string.Empty && a.OrdDlsZipCode != null)
                              && (a.OrdDlsCity != string.Empty && a.OrdDlsCity != null)
                              && (a.OrdDlsArea != string.Empty && a.OrdDlsArea != null)
                              && (a.OrdRoutingStatus + 123 > 0)
                              && (a.OrdLfdWeight + 123 > 0)
                              && (a.OrdLfdVol + 123 > 0)
                              && (a.OrdLfdCtn + 123 > 0)
                              && (a.OrdLfdBar + 123 > 0)
                              && (a.OrdLfdPalEuro + 123 > 0)
                              && (a.OrdLfdPalInd + 123 > 0)
                              && (a.OrdLfdPalElsa + 123 > 0)
                              && (a.OrdLfdParOU + 123 > 0)
                              && (a.OrdLfdVar + 123 > 0)
                              && a.OrdVoucherDateTime.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && (a.OrdVoucherNumber != string.Empty && a.OrdVoucherNumber != null)
                              && (a.OrdVoucherSeries != string.Empty && a.OrdVoucherSeries != null)
                              && (a.OrdVoucherId + 123 > 0)
                              && (a.OrdAgencyCode != string.Empty && a.OrdAgencyCode != null)
                              && (a.OrdAgencyDescr != string.Empty && a.OrdAgencyDescr != null)
                              && (a.OrdAgencyAddress != string.Empty && a.OrdAgencyAddress != null)
                              && (a.OrdTelRouteId + 123 > 0)
                              && (a.OrdVchPlateNr != string.Empty && a.OrdVchPlateNr != null)
                              && (a.OrdVchRouteNr + 123 > 0)
                              && a.OrdVhrDate.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && (a.OrdVhrID + 123 > 0)
                              && a.OrdLastUpdateDateTime.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && (a.OrdReadyForLoading + 123 > 0)
                              && (a.Polyline != string.Empty && a.Polyline != null)
                              && (a.Warehouse != string.Empty && a.Warehouse != null)
                              && (a.Truck != string.Empty && a.Truck != null)
                              && (a.WarehouseAddress != string.Empty && a.WarehouseAddress != null)
                              && (a.ETA != string.Empty && a.ETA != null)
                              && a.ATA.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && (a.DestLat + 123 > 0)
                              && (a.DestLong + 123 > 0)
                              && (a.COE + 123 > 0)
                              && a.ProofOfDelivery != null
                              ,
                              cacheQuery: true)
                          .OrderBy(a => a)
                          .Skip(0)
                          .Take(3)
                          .ToList();
            });
            Assert.AreNotEqual(null, results);
        }
    }
}