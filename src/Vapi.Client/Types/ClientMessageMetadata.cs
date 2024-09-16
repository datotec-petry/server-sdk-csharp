using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record ClientMessageMetadata
{
    /// <summary>
    /// This is the metadata content
    /// </summary>
    [JsonPropertyName("metadata")]
    public required string Metadata { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
