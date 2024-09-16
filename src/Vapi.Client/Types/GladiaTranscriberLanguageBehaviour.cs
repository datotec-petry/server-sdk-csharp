using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<GladiaTranscriberLanguageBehaviour>))]
public enum GladiaTranscriberLanguageBehaviour
{
    [EnumMember(Value = "manual")]
    Manual,

    [EnumMember(Value = "automatic single language")]
    AutomaticSingleLanguage,

    [EnumMember(Value = "automatic multiple languages")]
    AutomaticMultipleLanguages,
}
