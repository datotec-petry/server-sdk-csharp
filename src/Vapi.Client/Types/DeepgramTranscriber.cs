using System.Text.Json.Serialization;
using OneOf;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record DeepgramTranscriber
{
    /// <summary>
    /// This is the Deepgram model that will be used. A list of models can be found here: https://developers.deepgram.com/docs/models-languages-overview
    /// </summary>
    [JsonPropertyName("model")]
    public OneOf<
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string
    >? Model { get; set; }

    /// <summary>
    /// This is the language that will be set for the transcription. The list of languages Deepgram supports can be found here: https://developers.deepgram.com/docs/models-languages-overview
    /// </summary>
    [JsonPropertyName("language")]
    public DeepgramTranscriberLanguage? Language { get; set; }

    /// <summary>
    /// This will be use smart format option provided by Deepgram. It's default disabled because it can sometimes format numbers as times but it's getting better.
    /// </summary>
    [JsonPropertyName("smartFormat")]
    public bool? SmartFormat { get; set; }

    /// <summary>
    /// This enables or disables language detection. If true, swaps transcribers to detected language automatically. Defaults to false.
    /// </summary>
    [JsonPropertyName("languageDetectionEnabled")]
    public bool? LanguageDetectionEnabled { get; set; }

    /// <summary>
    /// These keywords are passed to the transcription model to help it pick up use-case specific words. Anything that may not be a common word, like your company name, should be added here.
    /// </summary>
    [JsonPropertyName("keywords")]
    public IEnumerable<string>? Keywords { get; set; }

    /// <summary>
    /// This is the timeout after which Deepgram will send transcription on user silence. You can read in-depth documentation here: https://developers.deepgram.com/docs/endpointing.
    ///
    /// Here are the most important bits:
    ///
    /// - Defaults to 10. This is recommended for most use cases to optimize for latency.
    /// - 10 can cause some missing transcriptions since because of the shorter context. This mostly happens for one-word utterances. For those uses cases, it's recommended to try 300. It will add a bit of latency but the quality and reliability of the experience will be better.
    /// - If neither 10 nor 300 work, contact support@vapi.ai and we'll find another solution.
    ///
    /// @default 10
    /// </summary>
    [JsonPropertyName("endpointing")]
    public double? Endpointing { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
