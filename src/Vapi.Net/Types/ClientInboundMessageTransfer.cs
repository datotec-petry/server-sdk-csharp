using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record ClientInboundMessageTransfer
{
    /// <summary>
    /// This is the destination to transfer the call to.
    /// </summary>
    [JsonPropertyName("destination")]
    public object? Destination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
