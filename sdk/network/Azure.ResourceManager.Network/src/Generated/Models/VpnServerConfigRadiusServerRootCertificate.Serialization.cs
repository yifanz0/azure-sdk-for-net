// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnServerConfigRadiusServerRootCertificate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(PublicCertData))
            {
                writer.WritePropertyName("publicCertData");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(PublicCertData);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(PublicCertData.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static VpnServerConfigRadiusServerRootCertificate DeserializeVpnServerConfigRadiusServerRootCertificate(JsonElement element)
        {
            Optional<string> name = default;
            Optional<BinaryData> publicCertData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicCertData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    publicCertData = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new VpnServerConfigRadiusServerRootCertificate(name.Value, publicCertData.Value);
        }
    }
}
