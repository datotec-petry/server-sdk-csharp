using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(StringEnumSerializer<FileStatus>))]
public enum FileStatus
{
    [EnumMember(Value = "indexed")]
    Indexed,

    [EnumMember(Value = "not_indexed")]
    NotIndexed,
}
