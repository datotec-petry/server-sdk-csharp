using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record ClientInboundMessage
{
    /// <summary>
    /// These are the messages that can be sent from client-side SDKs to control the call.
    /// </summary>
    [JsonPropertyName("message")]
    public required OneOf<
        ClientInboundMessageAddMessage,
        ClientInboundMessageControl,
        ClientInboundMessageSay
    > Message { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
