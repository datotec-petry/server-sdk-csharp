using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(StringEnumSerializer<RimeAiVoiceModel>))]
public enum RimeAiVoiceModel
{
    [EnumMember(Value = "v1")]
    V1,

    [EnumMember(Value = "mist")]
    Mist,
}
