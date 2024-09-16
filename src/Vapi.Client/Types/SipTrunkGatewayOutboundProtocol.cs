using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<SipTrunkGatewayOutboundProtocol>))]
public enum SipTrunkGatewayOutboundProtocol
{
    [EnumMember(Value = "tls/srtp")]
    TlsSrtp,

    [EnumMember(Value = "tcp")]
    Tcp,

    [EnumMember(Value = "tls")]
    Tls,

    [EnumMember(Value = "udp")]
    Udp,
}
