using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record ProgrammaticEdgeCondition
{
    [JsonPropertyName("booleanExpression")]
    public string? BooleanExpression { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
