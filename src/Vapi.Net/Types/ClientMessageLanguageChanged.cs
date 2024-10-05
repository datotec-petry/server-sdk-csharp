using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record ClientMessageLanguageChanged
{
    /// <summary>
    /// This is the type of the message. "language-switched" is sent when the transcriber is automatically switched based on the detected language.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// This is the language the transcriber is switched to.
    /// </summary>
    [JsonPropertyName("language")]
    public required string Language { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
