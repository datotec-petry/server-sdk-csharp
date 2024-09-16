using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record PaginationMeta
{
    [JsonPropertyName("itemsPerPage")]
    public required double ItemsPerPage { get; set; }

    [JsonPropertyName("totalItems")]
    public required double TotalItems { get; set; }

    [JsonPropertyName("currentPage")]
    public required double CurrentPage { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
