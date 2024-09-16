using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record VapiCost
{
    /// <summary>
    /// This is the minutes of Vapi usage. This should match `call.endedAt` - `call.startedAt`.
    /// </summary>
    [JsonPropertyName("minutes")]
    public required double Minutes { get; set; }

    /// <summary>
    /// This is the cost of the component in USD.
    /// </summary>
    [JsonPropertyName("cost")]
    public required double Cost { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
