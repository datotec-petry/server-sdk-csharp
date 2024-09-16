using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<TransportConfigurationTwilioRecordingChannels>))]
public enum TransportConfigurationTwilioRecordingChannels
{
    [EnumMember(Value = "mono")]
    Mono,

    [EnumMember(Value = "dual")]
    Dual,
}
