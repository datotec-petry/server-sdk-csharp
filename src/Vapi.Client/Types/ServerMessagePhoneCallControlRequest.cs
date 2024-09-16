using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<ServerMessagePhoneCallControlRequest>))]
public enum ServerMessagePhoneCallControlRequest
{
    [EnumMember(Value = "forward")]
    Forward,

    [EnumMember(Value = "hang-up")]
    HangUp,
}
