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
    ///This is a test class for PointTest and is intended
    ///to contain all PointTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("Point Repository Tests")]
    [Category("Point Repository Tests")]
    internal class PointTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `Point`")]
        [Order(0)]
        public void Point_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            new PersistenceSpecification<DSS3_LogisticsPoolingForUrbanDistribution.BO.Point>(Session)
            .CheckProperty(p => p.LocId, 9819)
            .CheckProperty(p => p.Time, 2620)
            .CheckProperty(p => p.Distance, 4869)
            .CheckProperty(p => p.CurrentLoad, 222222.22M)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `Point`")]
        [Order(1)]
        public void Point_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS3_LogisticsPoolingForUrbanDistribution.BO.Point> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS3_LogisticsPoolingForUrbanDistribution.BO.Point>(
                              a => true
                              && (a.LocId + 123 > 0)
                              && (a.Time + 123 > 0)
                              && (a.Distance + 123 > 0)
                              && (a.CurrentLoad + 123 > 0)
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