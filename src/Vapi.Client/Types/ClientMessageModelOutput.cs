using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record ClientMessageModelOutput
{
    /// <summary>
    /// This is the output of the model. It can be a token or tool call.
    /// </summary>
    [JsonPropertyName("output")]
    public object Output { get; set; } = new Dictionary<string, object?>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
