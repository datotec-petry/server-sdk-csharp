using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record CreditsBuyDto
{
    /// <summary>
    /// This is the number of credits to add to the subscription.
    /// </summary>
    [JsonPropertyName("credits")]
    public required double Credits { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
