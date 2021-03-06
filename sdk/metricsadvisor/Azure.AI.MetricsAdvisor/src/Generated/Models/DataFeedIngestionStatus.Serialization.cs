// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class DataFeedIngestionStatus
    {
        internal static DataFeedIngestionStatus DeserializeDataFeedIngestionStatus(JsonElement element)
        {
            Optional<DateTimeOffset> timestamp = default;
            Optional<IngestionStatusType> status = default;
            Optional<string> message = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new IngestionStatusType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
            }
            return new DataFeedIngestionStatus(Optional.ToNullable(timestamp), Optional.ToNullable(status), message.Value);
        }
    }
}
