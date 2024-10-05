using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record UpdateAzureOpenAiCredentialDto
{
    [JsonPropertyName("provider")]
    public required string Provider { get; set; }

    [JsonPropertyName("region")]
    public required UpdateAzureOpenAiCredentialDtoRegion Region { get; set; }

    [JsonPropertyName("models")]
    public IEnumerable<UpdateAzureOpenAiCredentialDtoModelsItem> Models { get; set; } =
        new List<UpdateAzureOpenAiCredentialDtoModelsItem>();

    /// <summary>
    /// This is not returned in the API.
    /// </summary>
    [JsonPropertyName("openAIKey")]
    public required string OpenAiKey { get; set; }

    [JsonPropertyName("openAIEndpoint")]
    public required string OpenAiEndpoint { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
