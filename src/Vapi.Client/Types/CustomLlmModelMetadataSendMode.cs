using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

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
