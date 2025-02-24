// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiManagementSkuLocationInfo
    {
        internal static ApiManagementSkuLocationInfo DeserializeApiManagementSkuLocationInfo(JsonElement element)
        {
            Optional<AzureLocation> location = default;
            Optional<IReadOnlyList<string>> zones = default;
            Optional<IReadOnlyList<ApiManagementSkuZoneDetails>> zoneDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("zones"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
                    continue;
                }
                if (property.NameEquals("zoneDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ApiManagementSkuZoneDetails> array = new List<ApiManagementSkuZoneDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApiManagementSkuZoneDetails.DeserializeApiManagementSkuZoneDetails(item));
                    }
                    zoneDetails = array;
                    continue;
                }
            }
            return new ApiManagementSkuLocationInfo(Optional.ToNullable(location), Optional.ToList(zones), Optional.ToList(zoneDetails));
        }
    }
}
