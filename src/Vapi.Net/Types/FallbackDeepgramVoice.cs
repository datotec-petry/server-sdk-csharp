using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record FallbackDeepgramVoice
{
    /// <summary>
    /// This is the provider-specific ID that will be used.
    /// </summary>
    [JsonPropertyName("voiceId")]
    public required OneOf<FallbackDeepgramVoiceIdEnum, string> VoiceId { get; set; }

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
