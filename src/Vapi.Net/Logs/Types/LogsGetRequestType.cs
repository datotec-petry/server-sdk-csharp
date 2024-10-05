using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(StringEnumSerializer<LogsGetRequestType>))]
public enum LogsGetRequestType
{
    [EnumMember(Value = "API")]
    Api,

    [EnumMember(Value = "Webhook")]
    Webhook,

    [EnumMember(Value = "Call")]
    Call,

    [EnumMember(Value = "Provider")]
    Provider,
}
