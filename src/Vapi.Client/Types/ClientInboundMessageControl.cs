using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record ClientInboundMessageControl
{
    /// <summary>
    /// This is the control action
    /// </summary>
    [JsonPropertyName("control")]
    public required ClientInboundMessageControlControl Control { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
