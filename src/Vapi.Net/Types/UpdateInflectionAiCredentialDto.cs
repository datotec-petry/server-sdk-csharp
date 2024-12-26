using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record UpdateInflectionAiCredentialDto
{
    /// <summary>
    /// This is the api key for Pi in InflectionAI's console. Get it from here: https://developers.inflection.ai/keys, billing will need to be setup
    /// </summary>
    [JsonPropertyName("provider")]
    public required string Provider { get; set; }

    /// <summary>
    /// This is not returned in the API.
    /// </summary>
    [JsonPropertyName("apiKey")]
    public required string ApiKey { get; set; }

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
