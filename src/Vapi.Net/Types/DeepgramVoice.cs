using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record DeepgramVoice
{
    /// <summary>
    /// This determines whether fillers are injected into the model output before inputting it into the voice provider.
    ///
    /// Default `false` because you can achieve better results with prompting the model.
    /// </summary>
    [JsonPropertyName("fillerInjectionEnabled")]
    public bool? FillerInjectionEnabled { get; set; }

    /// <summary>
    /// This is the provider-specific ID that will be used.
    /// </summary>
    [JsonPropertyName("voiceId")]
    public required OneOf<DeepgramVoiceIdEnum, string> VoiceId { get; set; }

    /// <summary>
    /// This is the plan for chunking the model output before it is sent to the voice provider.
    /// </summary>
    [JsonPropertyName("chunkPlan")]
    public ChunkPlan? ChunkPlan { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
