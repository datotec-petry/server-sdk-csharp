using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<ToolMessageCompleteRole>))]
public enum ToolMessageCompleteRole
{
    [EnumMember(Value = "assistant")]
    Assistant,

    [EnumMember(Value = "system")]
    System,
}
