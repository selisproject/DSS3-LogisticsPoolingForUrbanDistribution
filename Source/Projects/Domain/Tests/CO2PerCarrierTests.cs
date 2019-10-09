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
    ///This is a test class for CO2PerCarrierTest and is intended
    ///to contain all CO2PerCarrierTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("CO2PerCarrier Repository Tests")]
    [Category("CO2PerCarrier Repository Tests")]
    internal class CO2PerCarrierTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `CO2PerCarrier`")]
        [Order(0)]
        public void CO2PerCarrier_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            new PersistenceSpecification<DSS3_LogisticsPoolingForUrbanDistribution.BO.CO2PerCarrier>(Session)
            .CheckProperty(p => p.Description, "CO2PerCarrier_Description")
            .CheckProperty(p => p.KgCO2, 222222.22M)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `CO2PerCarrier`")]
        [Order(1)]
        public void CO2PerCarrier_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS3_LogisticsPoolingForUrbanDistribution.BO.CO2PerCarrier> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS3_LogisticsPoolingForUrbanDistribution.BO.CO2PerCarrier>(
                              a => true
                              && (a.Description != string.Empty && a.Description != null)
                              && (a.KgCO2 + 123 > 0)
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