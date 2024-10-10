using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record CreateToolTemplateDto
{
    [JsonPropertyName("details")]
    public object? Details { get; set; }

    [JsonPropertyName("providerDetails")]
    public object? ProviderDetails { get; set; }

    [JsonPropertyName("metadata")]
    public ToolTemplateMetadata? Metadata { get; set; }

    [JsonPropertyName("visibility")]
    public CreateToolTemplateDtoVisibility? Visibility { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// The name of the template. This is just for your own reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("provider")]
    public CreateToolTemplateDtoProvider? Provider { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
