using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record LogsPaginatedResponse
{
    [JsonPropertyName("results")]
    public IEnumerable<Log> Results { get; set; } = new List<Log>();

    [JsonPropertyName("metadata")]
    public required PaginationMeta Metadata { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
