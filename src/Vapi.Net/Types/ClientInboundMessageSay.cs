using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record ClientInboundMessageSay
{
    /// <summary>
    /// This is the type of the message. Send "say" message to make the assistant say something.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// This is the content to say.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// This is the flag to end call after content is spoken.
    /// </summary>
    [JsonPropertyName("endCallAfterSpoken")]
    public bool? EndCallAfterSpoken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
