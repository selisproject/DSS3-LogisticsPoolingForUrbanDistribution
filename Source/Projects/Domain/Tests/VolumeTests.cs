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
    ///This is a test class for VolumeTest and is intended
    ///to contain all VolumeTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("Volume Repository Tests")]
    [Category("Volume Repository Tests")]
    internal class VolumeTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `Volume`")]
        [Order(0)]
        public void Volume_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _ordersbo_supplier_volume = new DSS3_LogisticsPoolingForUrbanDistribution.BO.Supplier
            {
                Name = "Supplier_Name",
            };
            new PersistenceSpecification<DSS3_LogisticsPoolingForUrbanDistribution.BO.Volume>(Session)
            .CheckProperty(p => p.Pallets, 4844)
            .CheckProperty(p => p.Items, 1259)
            .CheckProperty(p => p.Weight, 113)
            .CheckReference(p => p.Supplier, _ordersbo_supplier_volume)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `Volume`")]
        [Order(1)]
        public void Volume_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS3_LogisticsPoolingForUrbanDistribution.BO.Volume> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS3_LogisticsPoolingForUrbanDistribution.BO.Volume>(
                              a => true
                              && (a.Pallets + 123 > 0)
                              && (a.Items + 123 > 0)
                              && (a.Weight + 123 > 0)
                              && a.Supplier != null
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