using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record Org
{
    /// <summary>
    /// When this is enabled, no logs, recordings, or transcriptions will be stored. At the end of the call, you will still receive an end-of-call-report message to store on your server. Defaults to false.
    /// When HIPAA is enabled, only OpenAI/Custom LLM or Azure Providers will be available for LLM and Voice respectively.
    /// This is due to the compliance requirements of HIPAA. Other providers may not meet these requirements.
    /// </summary>
    [JsonPropertyName("hipaaEnabled")]
    public bool? HipaaEnabled { get; set; }

    /// <summary>
    /// This is the unique identifier for the org.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the org was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the org was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// This is the Stripe customer for the org.
    /// </summary>
    [JsonPropertyName("stripeCustomerId")]
    public string? StripeCustomerId { get; set; }

    /// <summary>
    /// This is the subscription for the org.
    /// </summary>
    [JsonPropertyName("stripeSubscriptionId")]
    public string? StripeSubscriptionId { get; set; }

    /// <summary>
    /// This is the subscription's subscription item.
    /// </summary>
    [JsonPropertyName("stripeSubscriptionItemId")]
    public string? StripeSubscriptionItemId { get; set; }

    /// <summary>
    /// This is the subscription's current period start.
    /// </summary>
    [JsonPropertyName("stripeSubscriptionCurrentPeriodStart")]
    public DateTime? StripeSubscriptionCurrentPeriodStart { get; set; }

    /// <summary>
    /// This is the subscription's status.
    /// </summary>
    [JsonPropertyName("stripeSubscriptionStatus")]
    public string? StripeSubscriptionStatus { get; set; }

    /// <summary>
    /// This is the plan for the org.
    /// </summary>
    [JsonPropertyName("plan")]
    public OrgPlan? Plan { get; set; }

    /// <summary>
    /// This is the name of the org. This is just for your own reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the monthly billing limit for the org. To go beyond $1000/mo, please contact us at support@vapi.ai.
    /// </summary>
    [JsonPropertyName("billingLimit")]
    public double? BillingLimit { get; set; }

    /// <summary>
    /// This is the URL Vapi will communicate with via HTTP GET and POST Requests. This is used for retrieving context, function calling, and end-of-call reports.
    ///
    /// All requests will be sent with the call object among other things relevant to that message. You can find more details in the Server URL documentation.
    /// </summary>
    [JsonPropertyName("serverUrl")]
    public string? ServerUrl { get; set; }

    /// <summary>
    /// This is the secret you can set that Vapi will send with every request to your server. Will be sent as a header called x-vapi-secret.
    /// </summary>
    [JsonPropertyName("serverUrlSecret")]
    public string? ServerUrlSecret { get; set; }

    /// <summary>
    /// This is the concurrency limit for the org. This is the maximum number of calls that can be active at any given time. To go beyond 10, please contact us at support@vapi.ai.
    /// </summary>
    [JsonPropertyName("concurrencyLimit")]
    public double? ConcurrencyLimit { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
