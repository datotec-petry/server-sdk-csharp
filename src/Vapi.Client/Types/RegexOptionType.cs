using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<RegexOptionType>))]
public enum RegexOptionType
{
    [EnumMember(Value = "ignore-case")]
    IgnoreCase,

    [EnumMember(Value = "whole-word")]
    WholeWord,

    [EnumMember(Value = "multi-line")]
    MultiLine,
}
