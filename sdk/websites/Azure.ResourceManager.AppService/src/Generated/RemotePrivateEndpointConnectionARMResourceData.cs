// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the RemotePrivateEndpointConnectionARMResource data model. </summary>
    public partial class RemotePrivateEndpointConnectionARMResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of RemotePrivateEndpointConnectionARMResourceData. </summary>
        public RemotePrivateEndpointConnectionARMResourceData()
        {
            IPAddresses = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of RemotePrivateEndpointConnectionARMResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"></param>
        /// <param name="privateEndpoint"> PrivateEndpoint of a remote private endpoint connection. </param>
        /// <param name="privateLinkServiceConnectionState"> The state of a private link connection. </param>
        /// <param name="ipAddresses"> Private IPAddresses mapped to the remote private endpoint. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal RemotePrivateEndpointConnectionARMResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string provisioningState, SubResource privateEndpoint, PrivateLinkConnectionState privateLinkServiceConnectionState, IList<string> ipAddresses, string kind) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            IPAddresses = ipAddresses;
            Kind = kind;
        }

        /// <summary> Gets the provisioning state. </summary>
        public string ProvisioningState { get; }
        /// <summary> PrivateEndpoint of a remote private endpoint connection. </summary>
        internal SubResource PrivateEndpoint { get; set; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint is null ? default : PrivateEndpoint.Id;
        }

        /// <summary> The state of a private link connection. </summary>
        public PrivateLinkConnectionState PrivateLinkServiceConnectionState { get; set; }
        /// <summary> Private IPAddresses mapped to the remote private endpoint. </summary>
        public IList<string> IPAddresses { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
