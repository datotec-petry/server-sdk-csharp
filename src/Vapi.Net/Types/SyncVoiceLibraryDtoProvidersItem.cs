using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(StringEnumSerializer<SyncVoiceLibraryDtoProvidersItem>))]
public enum SyncVoiceLibraryDtoProvidersItem
{
    [EnumMember(Value = "11labs")]
    ElevenLabs,

    [EnumMember(Value = "azure")]
    Azure,

    [EnumMember(Value = "cartesia")]
    Cartesia,

    [EnumMember(Value = "custom-voice")]
    CustomVoice,

    [EnumMember(Value = "deepgram")]
    Deepgram,

    [EnumMember(Value = "lmnt")]
    Lmnt,

    [EnumMember(Value = "neets")]
    Neets,

    [EnumMember(Value = "openai")]
    Openai,

    [EnumMember(Value = "playht")]
    Playht,

    [EnumMember(Value = "rime-ai")]
    RimeAi,
}
