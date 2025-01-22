using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record CreateWorkflowDto
{
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    [JsonPropertyName("nodes")]
    public IEnumerable<OneOf<Say, Gather, object, CreateWorkflowDto>> Nodes { get; set; } =
        new List<OneOf<Say, Gather, object, CreateWorkflowDto>>();

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("edges")]
    public IEnumerable<Edge> Edges { get; set; } = new List<Edge>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
