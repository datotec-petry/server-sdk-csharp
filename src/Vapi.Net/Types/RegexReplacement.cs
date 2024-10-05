using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record RegexReplacement
{
    /// <summary>
    /// This is the regex replacement type. You can use this to replace a word or phrase that matches a pattern.
    ///
    /// Usage:
    ///
    /// - Replace all numbers with "some number": { type: 'regex', regex: '\\d+', value: 'some number' }
    /// - Replace email addresses with "[EMAIL]": { type: 'regex', regex: '\\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Z|a-z]{2,}\\b', value: '[EMAIL]' }
    /// - Replace phone numbers with a formatted version: { type: 'regex', regex: '(\\d{3})(\\d{3})(\\d{4})', value: '($1) $2-$3' }
    /// - Replace all instances of "color" or "colour" with "hue": { type: 'regex', regex: 'colou?r', value: 'hue' }
    /// - Capitalize the first letter of every sentence: { type: 'regex', regex: '(?<=\\. |^)[a-z]', value: (match) => match.toUpperCase() }
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// This is the regex pattern to replace.
    /// </summary>
    [JsonPropertyName("regex")]
    public required string Regex { get; set; }

    /// <summary>
    /// These are the options for the regex replacement. Default all options are disabled.
    ///
    /// @default []
    /// </summary>
    [JsonPropertyName("options")]
    public IEnumerable<RegexOption>? Options { get; set; }

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
