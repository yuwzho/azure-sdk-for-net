// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class BillingProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (MaxPrice != null)
            {
                writer.WritePropertyName("maxPrice");
                writer.WriteNumberValue(MaxPrice.Value);
            }
            writer.WriteEndObject();
        }

        internal static BillingProfile DeserializeBillingProfile(JsonElement element)
        {
            double? maxPrice = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxPrice"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPrice = property.Value.GetDouble();
                    continue;
                }
            }
            return new BillingProfile(maxPrice);
        }
    }
}
