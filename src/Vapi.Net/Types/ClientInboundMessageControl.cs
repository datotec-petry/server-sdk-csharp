using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record ClientInboundMessageControl
{
    /// <summary>
    /// This is the type of the message. Send "control" message to control the assistant. `control` options are:
    ///
    /// - "mute-assistant" - mute the assistant
    /// - "unmute-assistant" - unmute the assistant
    /// - "say-first-message" - say the first message (this is used when video recording is enabled and the conversation is only started once the client side kicks off the recording)
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// This is the control action
    /// </summary>
    [JsonPropertyName("control")]
    public required ClientInboundMessageControlControl Control { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
