using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record SyncVoiceLibraryDto
{
    /// <summary>
    /// List of providers you want to sync.
    /// </summary>
    [JsonPropertyName("providers")]
    public IEnumerable<SyncVoiceLibraryDtoProvidersItem>? Providers { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
