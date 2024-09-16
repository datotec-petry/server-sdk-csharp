using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<ServerMessageTranscriptTranscriptType>))]
public enum ServerMessageTranscriptTranscriptType
{
    [EnumMember(Value = "partial")]
    Partial,

    [EnumMember(Value = "final")]
    Final,
}
