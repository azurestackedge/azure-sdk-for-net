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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.Network.Models;

namespace Microsoft.WindowsAzure.Management.Network.Models
{
    /// <summary>
    /// The response to a ListGatewayConnections request to a Virtual Network
    /// Gateway.
    /// </summary>
    public partial class GatewayListGatewayConnectionsResponse : AzureOperationResponse, IEnumerable<GatewayListGatewayConnectionsResponse.VirtualNetworkGatewayConnection>
    {
        private IList<GatewayListGatewayConnectionsResponse.VirtualNetworkGatewayConnection> _virtualNetworkGatewayConnections;
        
        /// <summary>
        /// Optional. The list of gateway connections.
        /// </summary>
        public IList<GatewayListGatewayConnectionsResponse.VirtualNetworkGatewayConnection> VirtualNetworkGatewayConnections
        {
            get { return this._virtualNetworkGatewayConnections; }
            set { this._virtualNetworkGatewayConnections = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// GatewayListGatewayConnectionsResponse class.
        /// </summary>
        public GatewayListGatewayConnectionsResponse()
        {
            this.VirtualNetworkGatewayConnections = new LazyList<GatewayListGatewayConnectionsResponse.VirtualNetworkGatewayConnection>();
        }
        
        /// <summary>
        /// Gets the sequence of VirtualNetworkGatewayConnections.
        /// </summary>
        public IEnumerator<GatewayListGatewayConnectionsResponse.VirtualNetworkGatewayConnection> GetEnumerator()
        {
            return this.VirtualNetworkGatewayConnections.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of VirtualNetworkGatewayConnections.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        public partial class VirtualNetworkGatewayConnection
        {
            private string _connectedEntityId;
            
            /// <summary>
            /// Optional. The Service Key / Local network gateway Id / Vnet
            /// Network Gateway Id.
            /// </summary>
            public string ConnectedEntityId
            {
                get { return this._connectedEntityId; }
                set { this._connectedEntityId = value; }
            }
            
            private string _gatewayConnectionName;
            
            /// <summary>
            /// Optional. The name of the virtual network gateway connection.
            /// </summary>
            public string GatewayConnectionName
            {
                get { return this._gatewayConnectionName; }
                set { this._gatewayConnectionName = value; }
            }
            
            private string _gatewayConnectionType;
            
            /// <summary>
            /// Optional. The connection type of gateway:
            /// Ipsec/Dedicated/VpnClient/Vnet2Vnet.
            /// </summary>
            public string GatewayConnectionType
            {
                get { return this._gatewayConnectionType; }
                set { this._gatewayConnectionType = value; }
            }
            
            private int _routingWeight;
            
            /// <summary>
            /// Optional. The Routing Weight.
            /// </summary>
            public int RoutingWeight
            {
                get { return this._routingWeight; }
                set { this._routingWeight = value; }
            }
            
            private string _sharedKey;
            
            /// <summary>
            /// Optional. The Ipsec share key.
            /// </summary>
            public string SharedKey
            {
                get { return this._sharedKey; }
                set { this._sharedKey = value; }
            }
            
            private Guid _virtualNetworkGatewayId;
            
            /// <summary>
            /// Optional. The Virtual network gateway Id.
            /// </summary>
            public Guid VirtualNetworkGatewayId
            {
                get { return this._virtualNetworkGatewayId; }
                set { this._virtualNetworkGatewayId = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the
            /// VirtualNetworkGatewayConnection class.
            /// </summary>
            public VirtualNetworkGatewayConnection()
            {
            }
        }
    }
}
