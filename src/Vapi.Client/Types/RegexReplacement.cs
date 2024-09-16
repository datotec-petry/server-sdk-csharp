using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record RegexReplacement
{
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
