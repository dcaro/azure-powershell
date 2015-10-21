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

using Microsoft.Azure.KeyVault;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Azure.Commands.KeyVault.Models
{
    public class KeyVaultCertificateOrganizationDetails
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int? Zip { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public List<KeyVaultCertificateAdministratorDetails> AdministratorDetails { get; set; }

        internal OrganizationDetails ToOrganizationDetails()
        {
            return new OrganizationDetails
            {
                Id = Id,
                Name = Name,
                Address1 = Address1,
                Address2 = Address2,
                City = City,
                Zip = Zip,
                State = State,
                Country = Country,
                AdministratorDetails = KeyVaultCertificateAdministratorDetails.ToAdministratorDetails(AdministratorDetails),
            };
        }

        internal static KeyVaultCertificateOrganizationDetails FromOrganizationalDetails(OrganizationDetails organizationalDetails)
        {
            if (organizationalDetails == null)
            {
                return null;
            }

            var kvcOrganizationDetails = new KeyVaultCertificateOrganizationDetails
            {
                Id = organizationalDetails.Id,
                Name = organizationalDetails.Name,
                Address1 = organizationalDetails.Address1,
                Address2 = organizationalDetails.Address2,
                City = organizationalDetails.City,
                Zip = organizationalDetails.Zip,
                State = organizationalDetails.State,
                Country = organizationalDetails.Country,
                AdministratorDetails = KeyVaultCertificateAdministratorDetails.FromAdministratorDetails(organizationalDetails.AdministratorDetails),
            };

            return kvcOrganizationDetails;
        }
    }
}
