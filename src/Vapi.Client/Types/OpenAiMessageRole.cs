using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<OpenAiMessageRole>))]
public enum OpenAiMessageRole
{
    [EnumMember(Value = "assistant")]
    Assistant,

    [EnumMember(Value = "function")]
    Function,

    [EnumMember(Value = "user")]
    User,

    [EnumMember(Value = "system")]
    System,

    [EnumMember(Value = "tool")]
    Tool,
}
