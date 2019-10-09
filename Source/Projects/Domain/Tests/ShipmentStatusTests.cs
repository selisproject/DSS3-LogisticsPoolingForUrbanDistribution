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
    ///This is a test class for ShipmentStatusTest and is intended
    ///to contain all ShipmentStatusTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("ShipmentStatus Repository Tests")]
    [Category("ShipmentStatus Repository Tests")]
    internal class ShipmentStatusTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `ShipmentStatus`")]
        [Order(0)]
        public void ShipmentStatus_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _actionsbo_status_shipmentstatus = new DSS3_LogisticsPoolingForUrbanDistribution.BO.Status
            {
                Code = "Status_Code",
                Description = "Status_Description",
            };
            new PersistenceSpecification<DSS3_LogisticsPoolingForUrbanDistribution.BO.ShipmentStatus>(Session)
            .CheckProperty(p => p.TimeReported, now)
            .CheckProperty(p => p.Description, "ShipmentStatus_Description")
            .CheckProperty(p => p.User, "ShipmentStatus_User")
            .CheckReference(p => p.Status, _actionsbo_status_shipmentstatus)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `ShipmentStatus`")]
        [Order(1)]
        public void ShipmentStatus_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS3_LogisticsPoolingForUrbanDistribution.BO.ShipmentStatus> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS3_LogisticsPoolingForUrbanDistribution.BO.ShipmentStatus>(
                              a => true
                              && a.TimeReported.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && (a.Description != string.Empty && a.Description != null)
                              && (a.User != string.Empty && a.User != null)
                              && a.Status != null
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