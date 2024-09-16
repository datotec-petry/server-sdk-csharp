using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<TemplateVisibility>))]
public enum TemplateVisibility
{
    [EnumMember(Value = "public")]
    Public,

    [EnumMember(Value = "private")]
    Private,
}
