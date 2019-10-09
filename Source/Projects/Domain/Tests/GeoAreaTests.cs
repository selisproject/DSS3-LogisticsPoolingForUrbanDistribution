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
    ///This is a test class for GeoAreaTest and is intended
    ///to contain all GeoAreaTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("GeoArea Repository Tests")]
    [Category("GeoArea Repository Tests")]
    internal class GeoAreaTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `GeoArea`")]
        [Order(0)]
        public void GeoArea_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            new PersistenceSpecification<DSS3_LogisticsPoolingForUrbanDistribution.BO.GeoArea>(Session)
            .CheckProperty(p => p.Area, "GeoArea_Area")
            .CheckProperty(p => p.PostalCode, "GeoArea_PostalCode")
            .CheckProperty(p => p.County, "GeoArea_County")
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `GeoArea`")]
        [Order(1)]
        public void GeoArea_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS3_LogisticsPoolingForUrbanDistribution.BO.GeoArea> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS3_LogisticsPoolingForUrbanDistribution.BO.GeoArea>(
                              a => true
                              && (a.Area != string.Empty && a.Area != null)
                              && (a.PostalCode != string.Empty && a.PostalCode != null)
                              && (a.County != string.Empty && a.County != null)
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