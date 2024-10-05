using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

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
