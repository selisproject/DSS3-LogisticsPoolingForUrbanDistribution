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
    ///This is a test class for OrderStatisticsTest and is intended
    ///to contain all OrderStatisticsTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("OrderStatistics Repository Tests")]
    [Category("OrderStatistics Repository Tests")]
    internal class OrderStatisticsTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `OrderStatistics`")]
        [Order(0)]
        public void OrderStatistics_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            new PersistenceSpecification<DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderStatistics>(Session)
            .CheckProperty(p => p.TotalDeliveries, 7459)
            .CheckProperty(p => p.TotalOnTime, 7498)
            .CheckProperty(p => p.TotalInFull, 4895)
            .CheckProperty(p => p.TotalAsOrdered, 3627)
            .CheckProperty(p => p.TotalImpeachments, 3983)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `OrderStatistics`")]
        [Order(1)]
        public void OrderStatistics_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderStatistics> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS3_LogisticsPoolingForUrbanDistribution.BO.OrderStatistics>(
                              a => true
                              && (a.TotalDeliveries + 123 > 0)
                              && (a.TotalOnTime + 123 > 0)
                              && (a.TotalInFull + 123 > 0)
                              && (a.TotalAsOrdered + 123 > 0)
                              && (a.TotalImpeachments + 123 > 0)
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