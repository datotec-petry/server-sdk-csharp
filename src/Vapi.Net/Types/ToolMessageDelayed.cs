using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record ToolMessageDelayed
{
    /// <summary>
    /// This message is triggered when the tool call is delayed.
    ///
    /// There are the two things that can trigger this message:
    ///
    /// 1. The user talks with the assistant while your server is processing the request. Default is "Sorry, a few more seconds."
    /// 2. The server doesn't respond within `timingMilliseconds`.
    ///
    /// This message is never triggered for async tool calls.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// The number of milliseconds to wait for the server response before saying this message.
    /// </summary>
    [JsonPropertyName("timingMilliseconds")]
    public double? TimingMilliseconds { get; set; }

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
