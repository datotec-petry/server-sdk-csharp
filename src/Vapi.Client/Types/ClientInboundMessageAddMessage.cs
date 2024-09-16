using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record ClientInboundMessageAddMessage
{
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
