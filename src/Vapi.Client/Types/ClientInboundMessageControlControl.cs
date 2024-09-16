using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<ClientInboundMessageControlControl>))]
public enum ClientInboundMessageControlControl
{
    [EnumMember(Value = "mute-assistant")]
    MuteAssistant,

    [EnumMember(Value = "unmute-assistant")]
    UnmuteAssistant,

    [EnumMember(Value = "say-first-message")]
    SayFirstMessage,
}
