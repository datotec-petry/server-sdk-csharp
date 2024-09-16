using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record ClientMessageTranscript
{
    /// <summary>
    /// This is the role for which the transcript is for.
    /// </summary>
    [JsonPropertyName("role")]
    public required ClientMessageTranscriptRole Role { get; set; }

    /// <summary>
    /// This is the type of the transcript.
    /// </summary>
    [JsonPropertyName("transcriptType")]
    public required ClientMessageTranscriptTranscriptType TranscriptType { get; set; }

    /// <summary>
    /// This is the transcript content.
    /// </summary>
    [JsonPropertyName("transcript")]
    public required string Transcript { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
