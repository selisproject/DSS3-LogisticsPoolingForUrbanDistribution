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
    ///This is a test class for tblZslBookingTypeTest and is intended
    ///to contain all tblZslBookingTypeTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("tblZslBookingType Repository Tests")]
    [Category("tblZslBookingType Repository Tests")]
    internal class tblZslBookingTypeTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `tblZslBookingType`")]
        [Order(0)]
        public void tblZslBookingType_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _zanardobo_bookingtype_tblzslbookingtype = new DSS3_LogisticsPoolingForUrbanDistribution.BO.tblZslBookingType
            {
                BookingTypeName = "tblZslBookingType_BookingTypeName",
            };
            new PersistenceSpecification<DSS3_LogisticsPoolingForUrbanDistribution.BO.tblZslBookingType>(Session)
            .CheckProperty(p => p.BookingTypeName, "tblZslBookingType_BookingTypeName")
            .CheckReference(p => p.BookingType, _zanardobo_bookingtype_tblzslbookingtype)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `tblZslBookingType`")]
        [Order(1)]
        public void tblZslBookingType_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS3_LogisticsPoolingForUrbanDistribution.BO.tblZslBookingType> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS3_LogisticsPoolingForUrbanDistribution.BO.tblZslBookingType>(
                              a => true
                              && (a.BookingTypeName != string.Empty && a.BookingTypeName != null)
                              && a.BookingType != null
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