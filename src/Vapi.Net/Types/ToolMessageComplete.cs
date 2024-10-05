using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record ToolMessageComplete
{
    /// <summary>
    /// This is optional and defaults to "assistant".
    ///
    /// When role=assistant, `content` is said out loud.
    ///
    /// When role=system, `content` is passed to the model in a system message. Example:
    /// system: default one
    /// assistant:
    /// user:
    /// assistant:
    /// user:
    /// assistant:
    /// user:
    /// assistant: tool called
    /// tool: your server response
    /// <--- system prompt as hint
    /// ---> model generates response which is spoken
    /// This is useful when you want to provide a hint to the model about what to say next.
    /// </summary>
    [JsonPropertyName("role")]
    public ToolMessageCompleteRole? Role { get; set; }

    /// <summary>
    /// This is an optional boolean that if true, the call will end after the message is spoken. Default is false.
    ///
    /// This is ignored if `role` is set to `system`.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("endCallAfterSpokenEnabled")]
    public bool? EndCallAfterSpokenEnabled { get; set; }

    /// <summary>
    /// This is the content that the assistant says when this message is triggered.
    /// </summary>
    [JsonPropertyName("content")]
    public required string Content { get; set; }

    /// <summary>
    /// This is an optional array of conditions that the tool call arguments must meet in order for this message to be triggered.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IEnumerable<Condition>? Conditions { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
