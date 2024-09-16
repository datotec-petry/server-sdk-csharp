using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record ClientInboundMessage
{
    /// <summary>
    /// These are the messages that can be sent from client-side SDKs to control the call.
    /// </summary>
    [JsonPropertyName("message")]
    public required object Message { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
