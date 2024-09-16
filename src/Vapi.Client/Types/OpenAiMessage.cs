using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record OpenAiMessage
{
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    [JsonPropertyName("role")]
    public required OpenAiMessageRole Role { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
