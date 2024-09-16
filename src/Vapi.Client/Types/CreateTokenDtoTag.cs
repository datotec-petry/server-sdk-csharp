using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<CreateTokenDtoTag>))]
public enum CreateTokenDtoTag
{
    [EnumMember(Value = "private")]
    Private,

    [EnumMember(Value = "public")]
    Public,
}
