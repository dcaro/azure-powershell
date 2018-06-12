﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Consumption.Test.ScenarioTests.ScenarioTest;
using Microsoft.Azure.Commands.ScenarioTest;
using Microsoft.Azure.ServiceManagemenet.Common.Models;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Microsoft.WindowsAzure.Commands.Test.Utilities.Common;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.Azure.Commands.Consumption.Test.ScenarioTests
{
    public class ReservationTests : RMTestBase
    {
        public ReservationTests(ITestOutputHelper output)
        {
            XunitTracingInterceptor.AddToContext(new XunitTracingInterceptor(output));
            TestExecutionHelpers.SetUpSessionAndProfile();
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestListReservationSummariesMonthlyWithOrderId()
        {
            TestController.NewInstance.RunPowerShellTest("Test-ListReservationSummariesMonthlyWithOrderId");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestListReservationSummariesMonthlyWithOrderIdAndId()
        {
            TestController.NewInstance.RunPowerShellTest("Test-ListReservationSummariesMonthlyWithOrderIdAndId");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestListReservationSummariesDailyWithOrderId()
        {
            TestController.NewInstance.RunPowerShellTest("Test-ListReservationSummariesDailyWithOrderId");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestListReservationSummariesDailyWithOrderIdAndId()
        {
            TestController.NewInstance.RunPowerShellTest("Test-ListReservationSummariesDailyWithOrderIdAndId");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestListReservationDetailsWithOrderId()
        {
            TestController.NewInstance.RunPowerShellTest("Test-ListReservationDetailsWithOrderId");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestListReservationDetailsWithOrderIdAndId()
        {
            TestController.NewInstance.RunPowerShellTest("Test-ListReservationDetailsWithOrderIdAndId");
        }
    }
}
