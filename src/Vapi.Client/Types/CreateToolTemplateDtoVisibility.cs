using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<CreateToolTemplateDtoVisibility>))]
public enum CreateToolTemplateDtoVisibility
{
    [EnumMember(Value = "public")]
    Public,

    [EnumMember(Value = "private")]
    Private,
}
