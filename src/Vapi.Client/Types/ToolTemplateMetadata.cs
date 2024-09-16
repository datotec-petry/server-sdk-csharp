using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record ToolTemplateMetadata
{
    [JsonPropertyName("collectionType")]
    public string? CollectionType { get; set; }

    [JsonPropertyName("collectionId")]
    public string? CollectionId { get; set; }

    [JsonPropertyName("collectionName")]
    public string? CollectionName { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
