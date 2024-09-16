using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<JsonSchemaType>))]
public enum JsonSchemaType
{
    [EnumMember(Value = "string")]
    String,

    [EnumMember(Value = "number")]
    Number,

    [EnumMember(Value = "integer")]
    Integer,

    [EnumMember(Value = "boolean")]
    Boolean,

    [EnumMember(Value = "array")]
    Array,

    [EnumMember(Value = "object")]
    Object,
}
