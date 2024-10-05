using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(StringEnumSerializer<ServerMessagePhoneCallControlRequest>))]
public enum ServerMessagePhoneCallControlRequest
{
    [EnumMember(Value = "forward")]
    Forward,

    [EnumMember(Value = "hang-up")]
    HangUp,
}
