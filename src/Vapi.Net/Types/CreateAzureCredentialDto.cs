using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record CreateAzureCredentialDto
{
    [JsonPropertyName("provider")]
    public required string Provider { get; set; }

    /// <summary>
    /// This is the service being used in Azure.
    /// </summary>
    [JsonPropertyName("service")]
    public required string Service { get; set; }

    /// <summary>
    /// This is the region of the Azure resource.
    /// </summary>
    [JsonPropertyName("region")]
    public CreateAzureCredentialDtoRegion? Region { get; set; }

    /// <summary>
    /// This is not returned in the API.
    /// </summary>
    [JsonPropertyName("apiKey")]
    public string? ApiKey { get; set; }

    /// <summary>
    /// This is the name of credential. This is just for your reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
