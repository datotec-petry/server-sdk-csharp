using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<ConditionOperator>))]
public enum ConditionOperator
{
    [EnumMember(Value = "eq")]
    Eq,

    [EnumMember(Value = "neq")]
    Neq,

    [EnumMember(Value = "gt")]
    Gt,

    [EnumMember(Value = "gte")]
    Gte,

    [EnumMember(Value = "lt")]
    Lt,

    [EnumMember(Value = "lte")]
    Lte,
}
