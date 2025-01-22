using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record UpdateWorkflowDto
{
    [JsonPropertyName("nodes")]
    public IEnumerable<OneOf<Say, Gather, object, CreateWorkflowDto>>? Nodes { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("edges")]
    public IEnumerable<Edge>? Edges { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
