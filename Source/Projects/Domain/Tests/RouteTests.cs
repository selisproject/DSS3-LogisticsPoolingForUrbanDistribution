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
    ///This is a test class for RouteTest and is intended
    ///to contain all RouteTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("Route Repository Tests")]
    [Category("Route Repository Tests")]
    internal class RouteTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `Route`")]
        [Order(0)]
        public void Route_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _vrpsolution_vehicule_routes = new DSS3_LogisticsPoolingForUrbanDistribution.BO.Shipment
            {
                Owner = "Shipment_Owner",
                DepartureTime = now,
                CurrentStatus = "Shipment_CurrentStatus",
                Temperature = "Shipment_Temperature",
                LoadPercentage = 8535,
                TotalVolume = 222222.22M,
                AverageVolume = 222222.22M,
                MaxTravelTime = 6241,
            };
            var _vrpsolution_activities_routes = new DSS3_LogisticsPoolingForUrbanDistribution.BO.Activity
            {
                TravelDistance = 5150,
                TravelDuration = 5883,
            };
            var _vrpsolution_activities_routes2 = new DSS3_LogisticsPoolingForUrbanDistribution.BO.Activity
            {
                TravelDistance = 1169,
                TravelDuration = 3355,
            };
            new PersistenceSpecification<DSS3_LogisticsPoolingForUrbanDistribution.BO.Route>(Session)
            .CheckProperty(p => p.TotalTime, 2213)
            .CheckProperty(p => p.TotalDistance, 1506)
            .CheckReference(p => p.Vehicule, _vrpsolution_vehicule_routes)
            .CheckBag(p => p.Activities, (new List<DSS3_LogisticsPoolingForUrbanDistribution.BO.Activity>
            {
                _vrpsolution_activities_routes,
                _vrpsolution_activities_routes2
            }))
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `Route`")]
        [Order(1)]
        public void Route_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS3_LogisticsPoolingForUrbanDistribution.BO.Route> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS3_LogisticsPoolingForUrbanDistribution.BO.Route>(
                              a => true
                              && (a.TotalTime + 123 > 0)
                              && (a.TotalDistance + 123 > 0)
                              && a.Vehicule != null
                              && a.Activities.Any()
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