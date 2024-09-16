using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<GladiaTranscriberModel>))]
public enum GladiaTranscriberModel
{
    [EnumMember(Value = "fast")]
    Fast,

    [EnumMember(Value = "accurate")]
    Accurate,
}
