using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record Edge
{
    [JsonPropertyName("condition")]
    public object? Condition { get; set; }

    [JsonPropertyName("from")]
    public required string From { get; set; }

    [JsonPropertyName("to")]
    public required string To { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
