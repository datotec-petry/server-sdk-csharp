using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record CreateTwilioCredentialDto
{
    [JsonPropertyName("provider")]
    public required string Provider { get; set; }

    /// <summary>
    /// This is not returned in the API.
    /// </summary>
    [JsonPropertyName("authToken")]
    public required string AuthToken { get; set; }

    [JsonPropertyName("accountSid")]
    public required string AccountSid { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
