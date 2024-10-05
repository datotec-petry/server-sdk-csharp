using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record ClientInboundMessageAddMessage
{
    /// <summary>
    /// This is the type of the message. Send "add-message" message to add a message to the conversation history.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// This is the message to add to the conversation.
    /// </summary>
    [JsonPropertyName("message")]
    public required OpenAiMessage Message { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
