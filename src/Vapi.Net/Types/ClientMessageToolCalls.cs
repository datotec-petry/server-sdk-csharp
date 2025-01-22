using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record ClientMessageToolCalls
{
    /// <summary>
    /// This is the list of tools calls that the model is requesting along with the original tool configuration.
    /// </summary>
    [JsonPropertyName("toolWithToolCallList")]
    public IEnumerable<object> ToolWithToolCallList { get; set; } = new List<object>();

    /// <summary>
    /// This is the list of tool calls that the model is requesting.
    /// </summary>
    [JsonPropertyName("toolCallList")]
    public IEnumerable<ToolCall> ToolCallList { get; set; } = new List<ToolCall>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
