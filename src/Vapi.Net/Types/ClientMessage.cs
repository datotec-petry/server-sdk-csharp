using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record ClientMessage
{
    /// <summary>
    /// These are all the messages that can be sent to the client-side SDKs during the call. Configure the messages you'd like to receive in `assistant.clientMessages`.
    /// </summary>
    [JsonPropertyName("message")]
    public required object Message { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
