using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record ClientMessageSpeechUpdate
{
    /// <summary>
    /// This is the status of the speech update.
    /// </summary>
    [JsonPropertyName("status")]
    public required ClientMessageSpeechUpdateStatus Status { get; set; }

    /// <summary>
    /// This is the role which the speech update is for.
    /// </summary>
    [JsonPropertyName("role")]
    public required ClientMessageSpeechUpdateRole Role { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
