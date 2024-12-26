using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record SubscriptionCouponAddDto
{
    /// <summary>
    /// This is the ID of the org within the subscription which the coupon will take effect on.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// This is the code of the coupon to apply to the subscription.
    /// </summary>
    [JsonPropertyName("couponCode")]
    public required string CouponCode { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
