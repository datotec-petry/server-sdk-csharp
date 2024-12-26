using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record SubscriptionMonthlyCharge
{
    /// <summary>
    /// This is the monthly charge for the subscription.
    /// </summary>
    [JsonPropertyName("monthlyCharge")]
    public required double MonthlyCharge { get; set; }

    /// <summary>
    /// These are the different costs that make up the monthly charge.
    /// </summary>
    [JsonPropertyName("costs")]
    public IEnumerable<object> Costs { get; set; } = new List<object>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
