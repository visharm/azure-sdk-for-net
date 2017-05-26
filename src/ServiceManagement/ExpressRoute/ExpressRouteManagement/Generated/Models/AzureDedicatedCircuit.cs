// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.WindowsAzure.Management.ExpressRoute.Models;

namespace Microsoft.WindowsAzure.Management.ExpressRoute.Models
{
    /// <summary>
    /// Describes a Dedicated Circuit.
    /// </summary>
    public partial class AzureDedicatedCircuit
    {
        private uint _bandwidth;
        
        /// <summary>
        /// Optional. Specifies the bandwidth that is assigned to the circuit.
        /// </summary>
        public uint Bandwidth
        {
            get { return this._bandwidth; }
            set { this._bandwidth = value; }
        }
        
        private string _billingType;
        
        /// <summary>
        /// Optional. BillingType to be used for the new dedicated circuit.
        /// </summary>
        public string BillingType
        {
            get { return this._billingType; }
            set { this._billingType = value; }
        }
        
        private string _circuitName;
        
        /// <summary>
        /// Optional. Specifies the name of the circuit.
        /// </summary>
        public string CircuitName
        {
            get { return this._circuitName; }
            set { this._circuitName = value; }
        }
        
        private string _location;
        
        /// <summary>
        /// Optional. Specifies the peering location of the circuit.
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        private string _serviceKey;
        
        /// <summary>
        /// Optional. A value that uniquely identifies the circuit.
        /// </summary>
        public string ServiceKey
        {
            get { return this._serviceKey; }
            set { this._serviceKey = value; }
        }
        
        private string _serviceProviderName;
        
        /// <summary>
        /// Optional. Specifies the name of the dedicated circuit service
        /// provider.
        /// </summary>
        public string ServiceProviderName
        {
            get { return this._serviceProviderName; }
            set { this._serviceProviderName = value; }
        }
        
        private ProviderProvisioningState _serviceProviderProvisioningState;
        
        /// <summary>
        /// Optional. Specifies the provisioning state of the circuit. Values
        /// are NotProvisioned, Provisioning, Provisioned, or DeProvisioning.
        /// </summary>
        public ProviderProvisioningState ServiceProviderProvisioningState
        {
            get { return this._serviceProviderProvisioningState; }
            set { this._serviceProviderProvisioningState = value; }
        }
        
        private CircuitSku _sku;
        
        /// <summary>
        /// Optional. Sku to be used for the new dedicated circuit.
        /// </summary>
        public CircuitSku Sku
        {
            get { return this._sku; }
            set { this._sku = value; }
        }
        
        private DedicatedCircuitState _status;
        
        /// <summary>
        /// Optional. The current status of the circuit. Values are Disabled,
        /// Disabliing, Enabled, Enabling.
        /// </summary>
        public DedicatedCircuitState Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AzureDedicatedCircuit class.
        /// </summary>
        public AzureDedicatedCircuit()
        {
        }
    }
}