using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackCartesiaVoiceModel>))]
public enum FallbackCartesiaVoiceModel
{
    [EnumMember(Value = "sonic-english")]
    SonicEnglish,

    [EnumMember(Value = "sonic-multilingual")]
    SonicMultilingual,
}
