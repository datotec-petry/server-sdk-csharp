using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<AnthropicModelModel>))]
public enum AnthropicModelModel
{
    [EnumMember(Value = "claude-3-opus-20240229")]
    Claude3Opus20240229,

    [EnumMember(Value = "claude-3-sonnet-20240229")]
    Claude3Sonnet20240229,

    [EnumMember(Value = "claude-3-haiku-20240307")]
    Claude3Haiku20240307,

    [EnumMember(Value = "claude-3-5-sonnet-20240620")]
    Claude35Sonnet20240620,
}
