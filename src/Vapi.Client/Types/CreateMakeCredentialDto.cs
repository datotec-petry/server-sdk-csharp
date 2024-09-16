using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record CreateMakeCredentialDto
{
    [JsonPropertyName("provider")]
    public required string Provider { get; set; }

    /// <summary>
    /// Team ID
    /// </summary>
    [JsonPropertyName("teamId")]
    public required string TeamId { get; set; }

    /// <summary>
    /// Region of your application. For example: eu1, eu2, us1, us2
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>
    /// This is not returned in the API.
    /// </summary>
    [JsonPropertyName("apiKey")]
    public required string ApiKey { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
