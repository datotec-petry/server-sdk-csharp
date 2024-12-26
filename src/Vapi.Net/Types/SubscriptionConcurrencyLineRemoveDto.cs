using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record SubscriptionConcurrencyLineRemoveDto
{
    /// <summary>
    /// This is the number of concurrency lines to remove.
    /// </summary>
    [JsonPropertyName("quantity")]
    public required double Quantity { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
