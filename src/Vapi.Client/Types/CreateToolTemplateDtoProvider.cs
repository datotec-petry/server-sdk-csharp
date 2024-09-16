using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<CreateToolTemplateDtoProvider>))]
public enum CreateToolTemplateDtoProvider
{
    [EnumMember(Value = "make")]
    Make,

    [EnumMember(Value = "gohighlevel")]
    Gohighlevel,

    [EnumMember(Value = "function")]
    Function,
}
