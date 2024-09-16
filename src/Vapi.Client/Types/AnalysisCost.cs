using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record AnalysisCost
{
    /// <summary>
    /// This is the type of analysis performed.
    /// </summary>
    [JsonPropertyName("analysisType")]
    public required AnalysisCostAnalysisType AnalysisType { get; set; }

    /// <summary>
    /// This is the model that was used to perform the analysis.
    /// </summary>
    [JsonPropertyName("model")]
    public object Model { get; set; } = new Dictionary<string, object?>();

    /// <summary>
    /// This is the number of prompt tokens used in the analysis.
    /// </summary>
    [JsonPropertyName("promptTokens")]
    public required double PromptTokens { get; set; }

    /// <summary>
    /// This is the number of completion tokens generated in the analysis.
    /// </summary>
    [JsonPropertyName("completionTokens")]
    public required double CompletionTokens { get; set; }

    /// <summary>
    /// This is the cost of the component in USD.
    /// </summary>
    [JsonPropertyName("cost")]
    public required double Cost { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
