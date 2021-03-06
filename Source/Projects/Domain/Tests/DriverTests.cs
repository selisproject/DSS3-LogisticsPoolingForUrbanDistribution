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
    ///This is a test class for DriverTest and is intended
    ///to contain all DriverTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("Driver Repository Tests")]
    [Category("Driver Repository Tests")]
    internal class DriverTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `Driver`")]
        [Order(0)]
        public void Driver_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _driver_employer_driver = new DSS3_LogisticsPoolingForUrbanDistribution.BO.Location
            {
                Name = "Location_Name",
                Street = "Location_Street",
                City = "Location_City",
                Country = "Location_Country",
                Number = "Location_Number",
                PostCode = "Location_PostCode",
                Label = "Location_Label",
            };
            new PersistenceSpecification<DSS3_LogisticsPoolingForUrbanDistribution.BO.Driver>(Session)
            .CheckProperty(p => p.Id, 9118)
            .CheckProperty(p => p.UserName, "b4b8a92d-9dc8-4365-a816-7782e0306069Driver_UserName")
            .CheckProperty(p => p.PasswordHash, "Driver_PasswordHash")
            .CheckProperty(p => p.SecurityStamp, "Driver_SecurityStamp")
            .CheckProperty(p => p.EmailConfirmed, true)
            .CheckProperty(p => p.LockoutEnabled, true)
            .CheckProperty(p => p.PhoneNumberConfirmed, true)
            .CheckProperty(p => p.TwoFactorEnabled, true)
            .CheckProperty(p => p.AccessFailedCount, 8357)
            .CheckProperty(p => p.Name, "Driver_Name")
            .CheckProperty(p => p.Email, "Driver_Email")
            .CheckProperty(p => p.PhoneNumber, "Driver_PhoneNumber")
            .CheckProperty(p => p.LockoutEndDate, now)
            .CheckReference(p => p.Employer, _driver_employer_driver)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `Driver`")]
        [Order(1)]
        public void Driver_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS3_LogisticsPoolingForUrbanDistribution.BO.Driver> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS3_LogisticsPoolingForUrbanDistribution.BO.Driver>(
                              a => true
                              && (a.Id + 123 > 0)
                              && (a.UserName != string.Empty && a.UserName != null)
                              && (a.PasswordHash != string.Empty && a.PasswordHash != null)
                              && (a.SecurityStamp != string.Empty && a.SecurityStamp != null)
                              && !a.EmailConfirmed
                              && !a.LockoutEnabled
                              && !a.PhoneNumberConfirmed
                              && !a.TwoFactorEnabled
                              && (a.AccessFailedCount + 123 > 0)
                              && (a.Name != string.Empty && a.Name != null)
                              && (a.Email != string.Empty && a.Email != null)
                              && (a.PhoneNumber != string.Empty && a.PhoneNumber != null)
                              && a.LockoutEndDate.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && a.Employer != null
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