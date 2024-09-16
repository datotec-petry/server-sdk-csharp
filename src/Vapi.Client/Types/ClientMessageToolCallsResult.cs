using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record ClientMessageToolCallsResult
{
    /// <summary>
    /// This is the result of the tool call.
    /// </summary>
    [JsonPropertyName("toolCallResult")]
    public object ToolCallResult { get; set; } = new Dictionary<string, object?>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
