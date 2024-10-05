using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record ExactReplacement
{
    /// <summary>
    /// This is the exact replacement type. You can use this to replace a specific word or phrase with a different word or phrase.
    ///
    /// Usage:
    ///
    /// - Replace "hello" with "hi": { type: 'exact', key: 'hello', value: 'hi' }
    /// - Replace "good morning" with "good day": { type: 'exact', key: 'good morning', value: 'good day' }
    /// - Replace a specific name: { type: 'exact', key: 'John Doe', value: 'Jane Smith' }
    /// - Replace an acronym: { type: 'exact', key: 'AI', value: 'Artificial Intelligence' }
    /// - Replace a company name with its phonetic pronunciation: { type: 'exact', key: 'Vapi', value: 'Vappy' }
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// This is the key to replace.
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// This is the value that will replace the match.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
