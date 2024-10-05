using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record BlockCompleteMessage
{
    /// <summary>
    /// This is an optional array of conditions that must be met for this message to be triggered.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IEnumerable<OneOf<ModelBasedCondition, RuleBasedCondition>>? Conditions { get; set; }

    /// <summary>
    /// This is the message type that is triggered when the block completes.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// This is the content that the assistant will say when this message is triggered.
    /// </summary>
    [JsonPropertyName("content")]
    public required string Content { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
