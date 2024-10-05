using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record CartesiaVoice
{
    /// <summary>
    /// This determines whether fillers are injected into the model output before inputting it into the voice provider.
    ///
    /// Default `false` because you can achieve better results with prompting the model.
    /// </summary>
    [JsonPropertyName("fillerInjectionEnabled")]
    public bool? FillerInjectionEnabled { get; set; }

    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    [JsonPropertyName("provider")]
    public required string Provider { get; set; }

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
    /// This is the provider-specific ID that will be used.
    /// </summary>
    [JsonPropertyName("voiceId")]
    public required string VoiceId { get; set; }

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
