using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<AssistantOverridesFirstMessageMode>))]
public enum AssistantOverridesFirstMessageMode
{
    [EnumMember(Value = "assistant-speaks-first")]
    AssistantSpeaksFirst,

    [EnumMember(Value = "assistant-speaks-first-with-model-generated-message")]
    AssistantSpeaksFirstWithModelGeneratedMessage,

    [EnumMember(Value = "assistant-waits-for-user")]
    AssistantWaitsForUser,
}
