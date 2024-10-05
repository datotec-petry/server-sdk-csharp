using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record UpdateToolTemplateDto
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
    public UpdateToolTemplateDtoVisibility? Visibility { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// The name of the template. This is just for your own reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("provider")]
    public UpdateToolTemplateDtoProvider? Provider { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
