using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record ClientMessageVoiceInput
{
    /// <summary>
    /// This is the voice input content
    /// </summary>
    [JsonPropertyName("input")]
    public required string Input { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
