using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record StartSpeakingPlan
{
    /// <summary>
    /// This is how long assistant waits before speaking. Defaults to 0.4.
    ///
    /// This is the minimum it will wait but if there is latency is the pipeline, this minimum will be exceeded. This is really a stopgap in case the pipeline is moving too fast.
    ///
    /// Example:
    ///
    /// - If model generates tokens and voice generates bytes within 100ms, the pipeline still waits 300ms before outputting speech.
    ///
    /// Usage:
    ///
    /// - If the customer is taking long pauses, set this to a higher value.
    /// - If the assistant is accidentally jumping in too much, set this to a higher value.
    ///
    /// @default 0.4
    /// </summary>
    [JsonPropertyName("waitSeconds")]
    public double? WaitSeconds { get; set; }

    /// <summary>
    /// This determines if a customer speech is considered done (endpointing) using the VAP model on customer's speech. This is good for middle-of-thought detection.
    ///
    /// Once an endpoint is triggered, the request is sent to `assistant.model`.
    ///
    /// Default `false` since experimental.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("smartEndpointingEnabled")]
    public bool? SmartEndpointingEnabled { get; set; }

    /// <summary>
    /// This determines how a customer speech is considered done (endpointing) using the transcription of customer's speech.
    ///
    /// Once an endpoint is triggered, the request is sent to `assistant.model`.
    /// </summary>
    [JsonPropertyName("transcriptionEndpointingPlan")]
    public TranscriptionEndpointingPlan? TranscriptionEndpointingPlan { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
