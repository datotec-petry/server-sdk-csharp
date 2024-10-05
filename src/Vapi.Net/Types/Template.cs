using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record Template
{
    [JsonPropertyName("details")]
    public OneOf<
        CreateDtmfToolDto,
        CreateEndCallToolDto,
        CreateVoicemailToolDto,
        CreateFunctionToolDto,
        CreateGhlToolDto,
        CreateMakeToolDto,
        CreateTransferCallToolDto
    >? Details { get; set; }

    [JsonPropertyName("providerDetails")]
    public OneOf<
        MakeToolProviderDetails,
        GhlToolProviderDetails,
        FunctionToolProviderDetails
    >? ProviderDetails { get; set; }

    [JsonPropertyName("metadata")]
    public ToolTemplateMetadata? Metadata { get; set; }

    [JsonPropertyName("visibility")]
    public TemplateVisibility? Visibility { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// The name of the template. This is just for your own reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("provider")]
    public TemplateProvider? Provider { get; set; }

    /// <summary>
    /// The unique identifier for the template.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The unique identifier for the organization that this template belongs to.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// The ISO 8601 date-time string of when the template was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// The ISO 8601 date-time string of when the template was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
