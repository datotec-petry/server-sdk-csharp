using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<TokenTag>))]
public enum TokenTag
{
    [EnumMember(Value = "private")]
    Private,

    [EnumMember(Value = "public")]
    Public,
}
