using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record ToolMessageFailed
{
    /// <summary>
    /// This message is triggered when the tool call fails.
    ///
    /// This message is never triggered for async tool calls.
    ///
    /// If this message is not provided, the model will be requested to respond.
    ///
    /// If this message is provided, only this message will be spoken and the model will not be requested to come up with a response. It's an exclusive OR.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// This is an optional boolean that if true, the call will end after the message is spoken. Default is false.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("endCallAfterSpokenEnabled")]
    public bool? EndCallAfterSpokenEnabled { get; set; }

    /// <summary>
    /// This is the content that the assistant says when this message is triggered.
    /// </summary>
    [JsonPropertyName("content")]
    public required string Content { get; set; }

    /// <summary>
    /// This is an optional array of conditions that the tool call arguments must meet in order for this message to be triggered.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IEnumerable<Condition>? Conditions { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
