using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record SipTrunkOutboundSipRegisterPlan
{
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    [JsonPropertyName("username")]
    public string? Username { get; set; }

    [JsonPropertyName("realm")]
    public string? Realm { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
