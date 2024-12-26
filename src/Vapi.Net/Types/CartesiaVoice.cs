using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record CartesiaVoice
{
    /// <summary>
    /// This is the model that will be used. This is optional and will default to the correct model for the voiceId.
    /// </summary>
    [JsonPropertyName("model")]
    public CartesiaVoiceModel? Model { get; set; }

    /// <summary>
    /// This is the language that will be used. This is optional and will default to the correct language for the voiceId.
    /// </summary>
    [JsonPropertyName("language")]
    public CartesiaVoiceLanguage? Language { get; set; }

    /// <summary>
    /// This is the plan for chunking the model output before it is sent to the voice provider.
    /// </summary>
    [JsonPropertyName("chunkPlan")]
    public ChunkPlan? ChunkPlan { get; set; }

    /// <summary>
    /// This is the provider-specific ID that will be used.
    /// </summary>
    [JsonPropertyName("voiceId")]
    public required string VoiceId { get; set; }

    /// <summary>
    /// This is the plan for voice provider fallbacks in the event that the primary voice provider fails.
    /// </summary>
    [JsonPropertyName("fallbackPlan")]
    public FallbackPlan? FallbackPlan { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
