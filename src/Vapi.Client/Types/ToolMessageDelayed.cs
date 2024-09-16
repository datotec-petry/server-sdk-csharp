using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record ToolMessageDelayed
{
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
