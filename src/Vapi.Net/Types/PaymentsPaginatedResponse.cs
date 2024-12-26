using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record PaymentsPaginatedResponse
{
    [JsonPropertyName("results")]
    public IEnumerable<Payment> Results { get; set; } = new List<Payment>();

    [JsonPropertyName("metadata")]
    public required PaginationMeta Metadata { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
