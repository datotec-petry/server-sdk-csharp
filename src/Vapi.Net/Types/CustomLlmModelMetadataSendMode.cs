using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(StringEnumSerializer<CustomLlmModelMetadataSendMode>))]
public enum CustomLlmModelMetadataSendMode
{
    [EnumMember(Value = "off")]
    Off,

    [EnumMember(Value = "variable")]
    Variable,

    [EnumMember(Value = "destructured")]
    Destructured,
}
