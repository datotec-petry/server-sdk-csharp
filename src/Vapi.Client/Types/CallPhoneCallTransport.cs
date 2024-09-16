using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<CallPhoneCallTransport>))]
public enum CallPhoneCallTransport
{
    [EnumMember(Value = "sip")]
    Sip,

    [EnumMember(Value = "pstn")]
    Pstn,
}
