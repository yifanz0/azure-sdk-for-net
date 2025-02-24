// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class Node : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static Node DeserializeNode(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<NodeStatus> nodeStatus = default;
            Optional<string> nodeChassisSerialNumber = default;
            Optional<string> nodeSerialNumber = default;
            Optional<string> nodeDisplayName = default;
            Optional<string> nodeFriendlySoftwareVersion = default;
            Optional<string> nodeHcsVersion = default;
            Optional<string> nodeInstanceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("nodeStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            nodeStatus = new NodeStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("nodeChassisSerialNumber"))
                        {
                            nodeChassisSerialNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeSerialNumber"))
                        {
                            nodeSerialNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeDisplayName"))
                        {
                            nodeDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeFriendlySoftwareVersion"))
                        {
                            nodeFriendlySoftwareVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeHcsVersion"))
                        {
                            nodeHcsVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeInstanceId"))
                        {
                            nodeInstanceId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new Node(id, name, type, systemData.Value, Optional.ToNullable(nodeStatus), nodeChassisSerialNumber.Value, nodeSerialNumber.Value, nodeDisplayName.Value, nodeFriendlySoftwareVersion.Value, nodeHcsVersion.Value, nodeInstanceId.Value);
        }
    }
}
