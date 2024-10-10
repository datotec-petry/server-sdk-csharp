using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

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
