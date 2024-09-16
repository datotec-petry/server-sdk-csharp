using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<AssistantOverridesClientMessagesItem>))]
public enum AssistantOverridesClientMessagesItem
{
    [EnumMember(Value = "conversation-update")]
    ConversationUpdate,

    [EnumMember(Value = "function-call")]
    FunctionCall,

    [EnumMember(Value = "function-call-result")]
    FunctionCallResult,

    [EnumMember(Value = "hang")]
    Hang,

    [EnumMember(Value = "language-changed")]
    LanguageChanged,

    [EnumMember(Value = "metadata")]
    Metadata,

    [EnumMember(Value = "model-output")]
    ModelOutput,

    [EnumMember(Value = "speech-update")]
    SpeechUpdate,

    [EnumMember(Value = "status-update")]
    StatusUpdate,

    [EnumMember(Value = "transcript")]
    Transcript,

    [EnumMember(Value = "tool-calls")]
    ToolCalls,

    [EnumMember(Value = "tool-calls-result")]
    ToolCallsResult,

    [EnumMember(Value = "user-interrupted")]
    UserInterrupted,

    [EnumMember(Value = "voice-input")]
    VoiceInput,
}
