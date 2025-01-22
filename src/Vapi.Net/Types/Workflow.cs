using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record Workflow
{
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    [JsonPropertyName("nodes")]
    public IEnumerable<OneOf<Say, Gather, object, CreateWorkflowDto>> Nodes { get; set; } =
        new List<OneOf<Say, Gather, object, CreateWorkflowDto>>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("edges")]
    public IEnumerable<Edge> Edges { get; set; } = new List<Edge>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
