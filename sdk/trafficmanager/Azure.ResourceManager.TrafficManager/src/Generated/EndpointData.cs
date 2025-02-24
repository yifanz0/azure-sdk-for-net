// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.TrafficManager.Models;

namespace Azure.ResourceManager.TrafficManager
{
    /// <summary> A class representing the Endpoint data model. </summary>
    public partial class EndpointData : ProxyResource
    {
        /// <summary> Initializes a new instance of EndpointData. </summary>
        public EndpointData()
        {
            GeoMapping = new ChangeTrackingList<string>();
            Subnets = new ChangeTrackingList<EndpointPropertiesSubnetsItem>();
            CustomHeaders = new ChangeTrackingList<EndpointPropertiesCustomHeadersItem>();
        }

        /// <summary> Initializes a new instance of EndpointData. </summary>
        /// <param name="id"> Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="resourceType"> The type of the resource. Ex- Microsoft.Network/trafficManagerProfiles. </param>
        /// <param name="targetResourceId"> The Azure Resource URI of the of the endpoint. Not applicable to endpoints of type &apos;ExternalEndpoints&apos;. </param>
        /// <param name="target"> The fully-qualified DNS name or IP address of the endpoint. Traffic Manager returns this value in DNS responses to direct traffic to this endpoint. </param>
        /// <param name="endpointStatus"> The status of the endpoint. If the endpoint is Enabled, it is probed for endpoint health and is included in the traffic routing method. </param>
        /// <param name="weight"> The weight of this endpoint when using the &apos;Weighted&apos; traffic routing method. Possible values are from 1 to 1000. </param>
        /// <param name="priority"> The priority of this endpoint when using the &apos;Priority&apos; traffic routing method. Possible values are from 1 to 1000, lower values represent higher priority. This is an optional parameter.  If specified, it must be specified on all endpoints, and no two endpoints can share the same priority value. </param>
        /// <param name="endpointLocation"> Specifies the location of the external or nested endpoints when using the &apos;Performance&apos; traffic routing method. </param>
        /// <param name="endpointMonitorStatus"> The monitoring status of the endpoint. </param>
        /// <param name="minChildEndpoints"> The minimum number of endpoints that must be available in the child profile in order for the parent profile to be considered available. Only applicable to endpoint of type &apos;NestedEndpoints&apos;. </param>
        /// <param name="minChildEndpointsIPv4"> The minimum number of IPv4 (DNS record type A) endpoints that must be available in the child profile in order for the parent profile to be considered available. Only applicable to endpoint of type &apos;NestedEndpoints&apos;. </param>
        /// <param name="minChildEndpointsIPv6"> The minimum number of IPv6 (DNS record type AAAA) endpoints that must be available in the child profile in order for the parent profile to be considered available. Only applicable to endpoint of type &apos;NestedEndpoints&apos;. </param>
        /// <param name="geoMapping"> The list of countries/regions mapped to this endpoint when using the &apos;Geographic&apos; traffic routing method. Please consult Traffic Manager Geographic documentation for a full list of accepted values. </param>
        /// <param name="subnets"> The list of subnets, IP addresses, and/or address ranges mapped to this endpoint when using the &apos;Subnet&apos; traffic routing method. An empty list will match all ranges not covered by other endpoints. </param>
        /// <param name="customHeaders"> List of custom headers. </param>
        internal EndpointData(string id, string name, string resourceType, string targetResourceId, string target, EndpointStatus? endpointStatus, long? weight, long? priority, string endpointLocation, EndpointMonitorStatus? endpointMonitorStatus, long? minChildEndpoints, long? minChildEndpointsIPv4, long? minChildEndpointsIPv6, IList<string> geoMapping, IList<EndpointPropertiesSubnetsItem> subnets, IList<EndpointPropertiesCustomHeadersItem> customHeaders) : base(id, name, resourceType)
        {
            TargetResourceId = targetResourceId;
            Target = target;
            EndpointStatus = endpointStatus;
            Weight = weight;
            Priority = priority;
            EndpointLocation = endpointLocation;
            EndpointMonitorStatus = endpointMonitorStatus;
            MinChildEndpoints = minChildEndpoints;
            MinChildEndpointsIPv4 = minChildEndpointsIPv4;
            MinChildEndpointsIPv6 = minChildEndpointsIPv6;
            GeoMapping = geoMapping;
            Subnets = subnets;
            CustomHeaders = customHeaders;
        }

        /// <summary> The Azure Resource URI of the of the endpoint. Not applicable to endpoints of type &apos;ExternalEndpoints&apos;. </summary>
        public string TargetResourceId { get; set; }
        /// <summary> The fully-qualified DNS name or IP address of the endpoint. Traffic Manager returns this value in DNS responses to direct traffic to this endpoint. </summary>
        public string Target { get; set; }
        /// <summary> The status of the endpoint. If the endpoint is Enabled, it is probed for endpoint health and is included in the traffic routing method. </summary>
        public EndpointStatus? EndpointStatus { get; set; }
        /// <summary> The weight of this endpoint when using the &apos;Weighted&apos; traffic routing method. Possible values are from 1 to 1000. </summary>
        public long? Weight { get; set; }
        /// <summary> The priority of this endpoint when using the &apos;Priority&apos; traffic routing method. Possible values are from 1 to 1000, lower values represent higher priority. This is an optional parameter.  If specified, it must be specified on all endpoints, and no two endpoints can share the same priority value. </summary>
        public long? Priority { get; set; }
        /// <summary> Specifies the location of the external or nested endpoints when using the &apos;Performance&apos; traffic routing method. </summary>
        public string EndpointLocation { get; set; }
        /// <summary> The monitoring status of the endpoint. </summary>
        public EndpointMonitorStatus? EndpointMonitorStatus { get; set; }
        /// <summary> The minimum number of endpoints that must be available in the child profile in order for the parent profile to be considered available. Only applicable to endpoint of type &apos;NestedEndpoints&apos;. </summary>
        public long? MinChildEndpoints { get; set; }
        /// <summary> The minimum number of IPv4 (DNS record type A) endpoints that must be available in the child profile in order for the parent profile to be considered available. Only applicable to endpoint of type &apos;NestedEndpoints&apos;. </summary>
        public long? MinChildEndpointsIPv4 { get; set; }
        /// <summary> The minimum number of IPv6 (DNS record type AAAA) endpoints that must be available in the child profile in order for the parent profile to be considered available. Only applicable to endpoint of type &apos;NestedEndpoints&apos;. </summary>
        public long? MinChildEndpointsIPv6 { get; set; }
        /// <summary> The list of countries/regions mapped to this endpoint when using the &apos;Geographic&apos; traffic routing method. Please consult Traffic Manager Geographic documentation for a full list of accepted values. </summary>
        public IList<string> GeoMapping { get; }
        /// <summary> The list of subnets, IP addresses, and/or address ranges mapped to this endpoint when using the &apos;Subnet&apos; traffic routing method. An empty list will match all ranges not covered by other endpoints. </summary>
        public IList<EndpointPropertiesSubnetsItem> Subnets { get; }
        /// <summary> List of custom headers. </summary>
        public IList<EndpointPropertiesCustomHeadersItem> CustomHeaders { get; }
    }
}
