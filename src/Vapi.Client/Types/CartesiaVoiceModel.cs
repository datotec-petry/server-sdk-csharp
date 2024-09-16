using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<CartesiaVoiceModel>))]
public enum CartesiaVoiceModel
{
    [EnumMember(Value = "sonic-english")]
    SonicEnglish,

    [EnumMember(Value = "sonic-multilingual")]
    SonicMultilingual,
}
