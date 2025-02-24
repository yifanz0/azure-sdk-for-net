// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync
{
    /// <summary> A class representing the RegisteredServer data model. </summary>
    public partial class RegisteredServerData : ResourceData
    {
        /// <summary> Initializes a new instance of RegisteredServerData. </summary>
        public RegisteredServerData()
        {
        }

        /// <summary> Initializes a new instance of RegisteredServerData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="serverCertificate"> Registered Server Certificate. </param>
        /// <param name="agentVersion"> Registered Server Agent Version. </param>
        /// <param name="agentVersionStatus"> Registered Server Agent Version Status. </param>
        /// <param name="agentVersionExpirationOn"> Registered Server Agent Version Expiration Date. </param>
        /// <param name="serverOSVersion"> Registered Server OS Version. </param>
        /// <param name="serverManagementErrorCode"> Registered Server Management Error Code. </param>
        /// <param name="lastHeartBeat"> Registered Server last heart beat. </param>
        /// <param name="provisioningState"> Registered Server Provisioning State. </param>
        /// <param name="serverRole"> Registered Server serverRole. </param>
        /// <param name="clusterId"> Registered Server clusterId. </param>
        /// <param name="clusterName"> Registered Server clusterName. </param>
        /// <param name="serverId"> Registered Server serverId. </param>
        /// <param name="storageSyncServiceUid"> Registered Server storageSyncServiceUid. </param>
        /// <param name="lastWorkflowId"> Registered Server lastWorkflowId. </param>
        /// <param name="lastOperationName"> Resource Last Operation Name. </param>
        /// <param name="discoveryEndpointUri"> Resource discoveryEndpointUri. </param>
        /// <param name="resourceLocation"> Resource Location. </param>
        /// <param name="serviceLocation"> Service Location. </param>
        /// <param name="friendlyName"> Friendly Name. </param>
        /// <param name="managementEndpointUri"> Management Endpoint Uri. </param>
        /// <param name="monitoringEndpointUri"> Telemetry Endpoint Uri. </param>
        /// <param name="monitoringConfiguration"> Monitoring Configuration. </param>
        /// <param name="serverName"> Server name. </param>
        internal RegisteredServerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string serverCertificate, string agentVersion, RegisteredServerAgentVersionStatus? agentVersionStatus, DateTimeOffset? agentVersionExpirationOn, string serverOSVersion, int? serverManagementErrorCode, string lastHeartBeat, string provisioningState, string serverRole, string clusterId, string clusterName, string serverId, string storageSyncServiceUid, string lastWorkflowId, string lastOperationName, Uri discoveryEndpointUri, string resourceLocation, string serviceLocation, string friendlyName, Uri managementEndpointUri, Uri monitoringEndpointUri, string monitoringConfiguration, string serverName) : base(id, name, resourceType, systemData)
        {
            ServerCertificate = serverCertificate;
            AgentVersion = agentVersion;
            AgentVersionStatus = agentVersionStatus;
            AgentVersionExpirationOn = agentVersionExpirationOn;
            ServerOSVersion = serverOSVersion;
            ServerManagementErrorCode = serverManagementErrorCode;
            LastHeartBeat = lastHeartBeat;
            ProvisioningState = provisioningState;
            ServerRole = serverRole;
            ClusterId = clusterId;
            ClusterName = clusterName;
            ServerId = serverId;
            StorageSyncServiceUid = storageSyncServiceUid;
            LastWorkflowId = lastWorkflowId;
            LastOperationName = lastOperationName;
            DiscoveryEndpointUri = discoveryEndpointUri;
            ResourceLocation = resourceLocation;
            ServiceLocation = serviceLocation;
            FriendlyName = friendlyName;
            ManagementEndpointUri = managementEndpointUri;
            MonitoringEndpointUri = monitoringEndpointUri;
            MonitoringConfiguration = monitoringConfiguration;
            ServerName = serverName;
        }

        /// <summary> Registered Server Certificate. </summary>
        public string ServerCertificate { get; set; }
        /// <summary> Registered Server Agent Version. </summary>
        public string AgentVersion { get; set; }
        /// <summary> Registered Server Agent Version Status. </summary>
        public RegisteredServerAgentVersionStatus? AgentVersionStatus { get; }
        /// <summary> Registered Server Agent Version Expiration Date. </summary>
        public DateTimeOffset? AgentVersionExpirationOn { get; }
        /// <summary> Registered Server OS Version. </summary>
        public string ServerOSVersion { get; set; }
        /// <summary> Registered Server Management Error Code. </summary>
        public int? ServerManagementErrorCode { get; set; }
        /// <summary> Registered Server last heart beat. </summary>
        public string LastHeartBeat { get; set; }
        /// <summary> Registered Server Provisioning State. </summary>
        public string ProvisioningState { get; set; }
        /// <summary> Registered Server serverRole. </summary>
        public string ServerRole { get; set; }
        /// <summary> Registered Server clusterId. </summary>
        public string ClusterId { get; set; }
        /// <summary> Registered Server clusterName. </summary>
        public string ClusterName { get; set; }
        /// <summary> Registered Server serverId. </summary>
        public string ServerId { get; set; }
        /// <summary> Registered Server storageSyncServiceUid. </summary>
        public string StorageSyncServiceUid { get; set; }
        /// <summary> Registered Server lastWorkflowId. </summary>
        public string LastWorkflowId { get; set; }
        /// <summary> Resource Last Operation Name. </summary>
        public string LastOperationName { get; set; }
        /// <summary> Resource discoveryEndpointUri. </summary>
        public Uri DiscoveryEndpointUri { get; set; }
        /// <summary> Resource Location. </summary>
        public string ResourceLocation { get; set; }
        /// <summary> Service Location. </summary>
        public string ServiceLocation { get; set; }
        /// <summary> Friendly Name. </summary>
        public string FriendlyName { get; set; }
        /// <summary> Management Endpoint Uri. </summary>
        public Uri ManagementEndpointUri { get; set; }
        /// <summary> Telemetry Endpoint Uri. </summary>
        public Uri MonitoringEndpointUri { get; set; }
        /// <summary> Monitoring Configuration. </summary>
        public string MonitoringConfiguration { get; set; }
        /// <summary> Server name. </summary>
        public string ServerName { get; }
    }
}
