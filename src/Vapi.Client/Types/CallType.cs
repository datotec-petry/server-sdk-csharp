using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<CallType>))]
public enum CallType
{
    [EnumMember(Value = "inboundPhoneCall")]
    InboundPhoneCall,

    [EnumMember(Value = "outboundPhoneCall")]
    OutboundPhoneCall,

    [EnumMember(Value = "webCall")]
    WebCall,
}
