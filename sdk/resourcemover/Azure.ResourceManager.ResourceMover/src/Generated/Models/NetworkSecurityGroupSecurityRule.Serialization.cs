// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class NetworkSecurityGroupSecurityRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Access))
            {
                writer.WritePropertyName("access");
                writer.WriteStringValue(Access);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DestinationAddressPrefix))
            {
                writer.WritePropertyName("destinationAddressPrefix");
                writer.WriteStringValue(DestinationAddressPrefix);
            }
            if (Optional.IsDefined(DestinationPortRange))
            {
                writer.WritePropertyName("destinationPortRange");
                writer.WriteStringValue(DestinationPortRange);
            }
            if (Optional.IsDefined(Direction))
            {
                writer.WritePropertyName("direction");
                writer.WriteStringValue(Direction);
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority");
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol");
                writer.WriteStringValue(Protocol);
            }
            if (Optional.IsDefined(SourceAddressPrefix))
            {
                writer.WritePropertyName("sourceAddressPrefix");
                writer.WriteStringValue(SourceAddressPrefix);
            }
            if (Optional.IsDefined(SourcePortRange))
            {
                writer.WritePropertyName("sourcePortRange");
                writer.WriteStringValue(SourcePortRange);
            }
            writer.WriteEndObject();
        }

        internal static NetworkSecurityGroupSecurityRule DeserializeNetworkSecurityGroupSecurityRule(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> access = default;
            Optional<string> description = default;
            Optional<string> destinationAddressPrefix = default;
            Optional<string> destinationPortRange = default;
            Optional<string> direction = default;
            Optional<int> priority = default;
            Optional<string> protocol = default;
            Optional<string> sourceAddressPrefix = default;
            Optional<string> sourcePortRange = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("access"))
                {
                    access = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationAddressPrefix"))
                {
                    destinationAddressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationPortRange"))
                {
                    destinationPortRange = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("direction"))
                {
                    direction = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("priority"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("protocol"))
                {
                    protocol = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceAddressPrefix"))
                {
                    sourceAddressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourcePortRange"))
                {
                    sourcePortRange = property.Value.GetString();
                    continue;
                }
            }
            return new NetworkSecurityGroupSecurityRule(name.Value, access.Value, description.Value, destinationAddressPrefix.Value, destinationPortRange.Value, direction.Value, Optional.ToNullable(priority), protocol.Value, sourceAddressPrefix.Value, sourcePortRange.Value);
        }
    }
}
