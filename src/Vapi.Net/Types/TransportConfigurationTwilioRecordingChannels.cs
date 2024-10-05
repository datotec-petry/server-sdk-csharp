using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(StringEnumSerializer<TransportConfigurationTwilioRecordingChannels>))]
public enum TransportConfigurationTwilioRecordingChannels
{
    [EnumMember(Value = "mono")]
    Mono,

    [EnumMember(Value = "dual")]
    Dual,
}
