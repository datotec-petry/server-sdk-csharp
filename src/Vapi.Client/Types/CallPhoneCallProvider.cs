using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<CallPhoneCallProvider>))]
public enum CallPhoneCallProvider
{
    [EnumMember(Value = "twilio")]
    Twilio,

    [EnumMember(Value = "vonage")]
    Vonage,

    [EnumMember(Value = "vapi")]
    Vapi,
}
