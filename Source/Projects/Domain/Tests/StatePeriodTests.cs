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
    ///This is a test class for StatePeriodTest and is intended
    ///to contain all StatePeriodTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("StatePeriod Repository Tests")]
    [Category("StatePeriod Repository Tests")]
    internal class StatePeriodTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `StatePeriod`")]
        [Order(0)]
        public void StatePeriod_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            new PersistenceSpecification<DSS3_LogisticsPoolingForUrbanDistribution.BO.StatePeriod>(Session)
            .CheckProperty(p => p.StartDate, now)
            .CheckProperty(p => p.EndDate, now)
            .CheckProperty(p => p.Active, true)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `StatePeriod`")]
        [Order(1)]
        public void StatePeriod_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS3_LogisticsPoolingForUrbanDistribution.BO.StatePeriod> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS3_LogisticsPoolingForUrbanDistribution.BO.StatePeriod>(
                              a => true
                              && a.StartDate.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && a.EndDate.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && !a.Active
                              && a.State == DSS3_LogisticsPoolingForUrbanDistribution.BO.State.Registration
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