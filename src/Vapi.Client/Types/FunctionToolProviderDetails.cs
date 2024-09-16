using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record FunctionToolProviderDetails
{
    /// <summary>
    /// This is the Template URL or the Snapshot URL corresponding to the Template.
    /// </summary>
    [JsonPropertyName("templateUrl")]
    public string? TemplateUrl { get; set; }

    [JsonPropertyName("setupInstructions")]
    public IEnumerable<ToolTemplateSetup>? SetupInstructions { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
