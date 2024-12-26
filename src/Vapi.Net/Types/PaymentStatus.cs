using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<PaymentStatus>))]
public enum PaymentStatus
{
    [EnumMember(Value = "past-due")]
    PastDue,

    [EnumMember(Value = "pending")]
    Pending,

    [EnumMember(Value = "finalized")]
    Finalized,

    [EnumMember(Value = "refunded")]
    Refunded,
}
