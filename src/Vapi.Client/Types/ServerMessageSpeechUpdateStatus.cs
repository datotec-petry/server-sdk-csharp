using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<ServerMessageSpeechUpdateStatus>))]
public enum ServerMessageSpeechUpdateStatus
{
    [EnumMember(Value = "started")]
    Started,

    [EnumMember(Value = "stopped")]
    Stopped,
}
