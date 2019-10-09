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
    ///This is a test class for WorkflowScheduleTest and is intended
    ///to contain all WorkflowScheduleTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("WorkflowSchedule Repository Tests")]
    [Category("WorkflowSchedule Repository Tests")]
    internal class WorkflowScheduleTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `WorkflowSchedule`")]
        [Order(0)]
        public void WorkflowSchedule_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            new PersistenceSpecification<zAppDev.DotNet.Framework.Workflow.WorkflowSchedule>(Session)
            .CheckProperty(p => p.Workflow, "fc5cf72f-4d51-4180-89df-2f1e5d6e2a8fWorkflowSchedule_Workflow")
            .CheckProperty(p => p.Description, "WorkflowSchedule_Description")
            .CheckProperty(p => p.StartDateTime, now)
            .CheckProperty(p => p.ExpireOn, now)
            .CheckProperty(p => p.CronExpression, "WorkflowSchedule_CronExpression")
            .CheckProperty(p => p.LastExecution, now)
            .CheckProperty(p => p.LastExecutionMessage, "WorkflowSchedule_LastExecutionMessage")
            .CheckProperty(p => p.IsLastExecutionSuccess, true)
            .CheckProperty(p => p.Active, true)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `WorkflowSchedule`")]
        [Order(1)]
        public void WorkflowSchedule_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<zAppDev.DotNet.Framework.Workflow.WorkflowSchedule> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<zAppDev.DotNet.Framework.Workflow.WorkflowSchedule>(
                              a => true
                              && (a.Workflow != string.Empty && a.Workflow != null)
                              && (a.Description != string.Empty && a.Description != null)
                              && a.StartDateTime.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && a.ExpireOn.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && (a.CronExpression != string.Empty && a.CronExpression != null)
                              && a.LastExecution.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && (a.LastExecutionMessage != string.Empty && a.LastExecutionMessage != null)
                              && !a.IsLastExecutionSuccess
                              && !a.Active
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