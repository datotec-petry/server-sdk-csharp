using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record CreateAzureOpenAiCredentialDto
{
    [JsonPropertyName("provider")]
    public required string Provider { get; set; }

    [JsonPropertyName("region")]
    public required CreateAzureOpenAiCredentialDtoRegion Region { get; set; }

    [JsonPropertyName("models")]
    public IEnumerable<CreateAzureOpenAiCredentialDtoModelsItem> Models { get; set; } =
        new List<CreateAzureOpenAiCredentialDtoModelsItem>();

    /// <summary>
    /// This is not returned in the API.
    /// </summary>
    [JsonPropertyName("openAIKey")]
    public required string OpenAiKey { get; set; }

    [JsonPropertyName("openAIEndpoint")]
    public required string OpenAiEndpoint { get; set; }

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
