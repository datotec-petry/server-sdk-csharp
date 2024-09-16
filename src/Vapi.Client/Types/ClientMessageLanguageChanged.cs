using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record ClientMessageLanguageChanged
{
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
