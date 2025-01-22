using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record SemanticEdgeCondition
{
    [JsonPropertyName("matches")]
    public IEnumerable<string>? Matches { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
