using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record PaymentRetryDto
{
    /// <summary>
    /// This is the payment ID to retry.
    /// </summary>
    [JsonPropertyName("paymentId")]
    public required string PaymentId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
