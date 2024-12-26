using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<OpenAiModelFallbackModelsItem>))]
public enum OpenAiModelFallbackModelsItem
{
    [EnumMember(Value = "gpt-4o-realtime-preview-2024-10-01")]
    Gpt4ORealtimePreview20241001,

    [EnumMember(Value = "gpt-4o-mini")]
    Gpt4OMini,

    [EnumMember(Value = "gpt-4o-mini-2024-07-18")]
    Gpt4OMini20240718,

    [EnumMember(Value = "gpt-4o")]
    Gpt4O,

    [EnumMember(Value = "gpt-4o-2024-05-13")]
    Gpt4O20240513,

    [EnumMember(Value = "gpt-4o-2024-08-06")]
    Gpt4O20240806,

    [EnumMember(Value = "gpt-4o-2024-11-20")]
    Gpt4O20241120,

    [EnumMember(Value = "gpt-4-turbo")]
    Gpt4Turbo,

    [EnumMember(Value = "gpt-4-turbo-2024-04-09")]
    Gpt4Turbo20240409,

    [EnumMember(Value = "gpt-4-turbo-preview")]
    Gpt4TurboPreview,

    [EnumMember(Value = "gpt-4-0125-preview")]
    Gpt40125Preview,

    [EnumMember(Value = "gpt-4-1106-preview")]
    Gpt41106Preview,

    [EnumMember(Value = "gpt-4")]
    Gpt4,

    [EnumMember(Value = "gpt-4-0613")]
    Gpt40613,

    [EnumMember(Value = "gpt-3.5-turbo")]
    Gpt35Turbo,

    [EnumMember(Value = "gpt-3.5-turbo-0125")]
    Gpt35Turbo0125,

    [EnumMember(Value = "gpt-3.5-turbo-1106")]
    Gpt35Turbo1106,

    [EnumMember(Value = "gpt-3.5-turbo-16k")]
    Gpt35Turbo16K,

    [EnumMember(Value = "gpt-3.5-turbo-0613")]
    Gpt35Turbo0613,
}
