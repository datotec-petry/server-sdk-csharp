using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record TransferDestinationSip
{
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// This is the SIP URI to transfer the call to.
    /// </summary>
    [JsonPropertyName("sipUri")]
    public required string SipUri { get; set; }

    /// <summary>
    /// This is the message to say before transferring the call to the destination.
    ///
    /// If this is not provided and transfer tool messages is not provided, default is "Transferring the call now".
    ///
    /// If set to "", nothing is spoken. This is useful when you want to silently transfer. This is especially useful when transferring between assistants in a squad. In this scenario, you likely also want to set `assistant.firstMessageMode=assistant-speaks-first-with-model-generated-message` for the destination assistant.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// This is the description of the destination, used by the AI to choose when and how to transfer the call.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
