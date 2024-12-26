using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record AutoReloadPlanDto
{
    /// <summary>
    /// This is the auto reload plan to be configured for the subscription.
    /// It can be null if no auto reload plan is set.
    /// </summary>
    [JsonPropertyName("autoReloadPlan")]
    public AutoReloadPlan? AutoReloadPlan { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
