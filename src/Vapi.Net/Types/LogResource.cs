using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(StringEnumSerializer<LogResource>))]
public enum LogResource
{
    [EnumMember(Value = "assistant")]
    Assistant,

    [EnumMember(Value = "phone-number")]
    PhoneNumber,

    [EnumMember(Value = "tool")]
    Tool,

    [EnumMember(Value = "squad")]
    Squad,

    [EnumMember(Value = "call")]
    Call,

    [EnumMember(Value = "file")]
    File,

    [EnumMember(Value = "metric")]
    Metric,

    [EnumMember(Value = "log")]
    Log,
}
