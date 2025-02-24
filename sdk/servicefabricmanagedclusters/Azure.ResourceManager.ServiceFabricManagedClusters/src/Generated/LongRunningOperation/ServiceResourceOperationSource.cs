// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ServiceFabricManagedClusters
{
    internal class ServiceResourceOperationSource : IOperationSource<ServiceResource>
    {
        private readonly ArmClient _client;

        internal ServiceResourceOperationSource(ArmClient client)
        {
            _client = client;
        }

        ServiceResource IOperationSource<ServiceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ServiceResourceData.DeserializeServiceResourceData(document.RootElement);
            return new ServiceResource(_client, data);
        }

        async ValueTask<ServiceResource> IOperationSource<ServiceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ServiceResourceData.DeserializeServiceResourceData(document.RootElement);
            return new ServiceResource(_client, data);
        }
    }
}
