// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class ApiProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ServerVersion))
            {
                writer.WritePropertyName("serverVersion");
                writer.WriteStringValue(ServerVersion.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ApiProperties DeserializeApiProperties(JsonElement element)
        {
            Optional<ServerVersion> serverVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serverVersion"))
                {
                    serverVersion = new ServerVersion(property.Value.GetString());
                    continue;
                }
            }
            return new ApiProperties(Optional.ToNullable(serverVersion));
        }
    }
}
