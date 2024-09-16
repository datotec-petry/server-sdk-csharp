using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<ChunkPlanPunctuationBoundariesItem>))]
public enum ChunkPlanPunctuationBoundariesItem
{
    [EnumMember(Value = "。")]
    Circle,

    [EnumMember(Value = "，")]
    Comma,

    [EnumMember(Value = ".")]
    Dot,

    [EnumMember(Value = "!")]
    Exclamation,

    [EnumMember(Value = "?")]
    Question,

    [EnumMember(Value = ";")]
    Semicolon,

    [EnumMember(Value = ")")]
    Parenthesis,

    [EnumMember(Value = "،")]
    ArabicComma,

    [EnumMember(Value = "۔")]
    UrduFullStop,

    [EnumMember(Value = "।")]
    BengaliFullStop,

    [EnumMember(Value = "॥")]
    DoubleDanda,

    [EnumMember(Value = "|")]
    Pipe,

    [EnumMember(Value = "||")]
    DoublePipe,

    [EnumMember(Value = ",")]
    HalfWidthComma,

    [EnumMember(Value = ":")]
    Colon,
}
