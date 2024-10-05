using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(StringEnumSerializer<CallStatus>))]
public enum CallStatus
{
    [EnumMember(Value = "queued")]
    Queued,

    [EnumMember(Value = "ringing")]
    Ringing,

    [EnumMember(Value = "in-progress")]
    InProgress,

    [EnumMember(Value = "forwarding")]
    Forwarding,

    [EnumMember(Value = "ended")]
    Ended,
}
