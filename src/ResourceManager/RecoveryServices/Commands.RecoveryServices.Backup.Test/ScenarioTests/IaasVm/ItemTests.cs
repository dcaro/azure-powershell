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

using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Common.Authentication;
using Microsoft.Azure.Commands.RecoveryServices.Backup.Cmdlets.Models;
using Microsoft.Azure.ServiceManagemenet.Common.Models;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Microsoft.WindowsAzure.Commands.Test.Utilities.Common;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.Azure.Commands.RecoveryServices.Backup.Test.ScenarioTests
{
    public partial class ItemTests : RMTestBase
    {
        public ItemTests(ITestOutputHelper output)
        {
            XunitTracingInterceptor.AddToContext(new XunitTracingInterceptor(output));
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(TestConstants.Workload, TestConstants.AzureVM)]
        public void TestAzureVMGetItems()
        {
            TestController.NewInstance.RunPsTest(
                PsBackupProviderTypes.IaasVm, "Test-AzureVMGetItems");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(TestConstants.Workload, TestConstants.AzureVM)]
        public void TestAzureVMProtection()
        {
            TestController.NewInstance.RunPsTest(
                PsBackupProviderTypes.IaasVm, "Test-AzureVMProtection");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(TestConstants.Workload, TestConstants.AzureVM)]
        public void TestAzureVMBackup()
        {
            TestController.NewInstance.RunPsTest(
                PsBackupProviderTypes.IaasVm, "Test-AzureVMBackup");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(TestConstants.Workload, TestConstants.AzureVM)]
        public void TestAzureVMGetRPs()
        {
            TestController.NewInstance.RunPsTest(
                PsBackupProviderTypes.IaasVm, "Test-AzureVMGetRPs");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(TestConstants.Workload, TestConstants.AzureVM)]
        public void TestAzureVMFullRestore()
        {
            TestController.NewInstance.RunPsTest(
                PsBackupProviderTypes.IaasVm, "Test-AzureVMFullRestore");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(TestConstants.Workload, TestConstants.AzureVM)]
        public void TestAzureVMRPMountScript()
        {
            Collection<PSObject> psObjects = TestController.NewInstance.RunPsTest(
                PsBackupProviderTypes.IaasVm, "Test-AzureVMRPMountScript");

            AzureVmRPMountScriptDetails mountScriptDetails = (AzureVmRPMountScriptDetails)psObjects.First(
                psObject => psObject.BaseObject.GetType() == typeof(AzureVmRPMountScriptDetails)).BaseObject;

            Assert.True(AzureSession.Instance.DataStore.FileExists(mountScriptDetails.FilePath));
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(TestConstants.Workload, TestConstants.AzureVM)]
        public void TestAzureVMSetVaultContext()
        {
            TestController.NewInstance.RunPsTest(
                PsBackupProviderTypes.IaasVm, "Test-AzureVMSetVaultContext");
        }
    }
}
