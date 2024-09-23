using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

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
