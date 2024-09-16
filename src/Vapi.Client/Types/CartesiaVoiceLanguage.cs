using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<CartesiaVoiceLanguage>))]
public enum CartesiaVoiceLanguage
{
    [EnumMember(Value = "de")]
    De,

    [EnumMember(Value = "en")]
    En,

    [EnumMember(Value = "es")]
    Es,

    [EnumMember(Value = "fr")]
    Fr,

    [EnumMember(Value = "ja")]
    Ja,

    [EnumMember(Value = "pt")]
    Pt,

    [EnumMember(Value = "zh")]
    Zh,
}
