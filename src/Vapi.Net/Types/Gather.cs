using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record Gather
{
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    [JsonPropertyName("schema")]
    public JsonSchema? Schema { get; set; }

    [JsonPropertyName("instruction")]
    public required string Instruction { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
