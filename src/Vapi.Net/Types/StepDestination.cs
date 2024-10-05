using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record StepDestination
{
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// This is an optional array of conditions that must be met for this destination to be triggered. If empty, this is the default destination that the step transfers to.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IEnumerable<OneOf<ModelBasedCondition, RuleBasedCondition>>? Conditions { get; set; }

    [JsonPropertyName("stepName")]
    public required string StepName { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
