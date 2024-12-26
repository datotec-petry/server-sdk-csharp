using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackElevenLabsVoiceModel>))]
public enum FallbackElevenLabsVoiceModel
{
    [EnumMember(Value = "eleven_multilingual_v2")]
    ElevenMultilingualV2,

    [EnumMember(Value = "eleven_turbo_v2")]
    ElevenTurboV2,

    [EnumMember(Value = "eleven_turbo_v2_5")]
    ElevenTurboV25,

    [EnumMember(Value = "eleven_monolingual_v1")]
    ElevenMonolingualV1,
}
