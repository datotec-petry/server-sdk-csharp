using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record OrgPlan
{
    [JsonPropertyName("includedProviders")]
    public IEnumerable<object>? IncludedProviders { get; set; }

    [JsonPropertyName("includedMinutes")]
    public double? IncludedMinutes { get; set; }

    [JsonPropertyName("costPerOverageMinute")]
    public double? CostPerOverageMinute { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
