using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<AnalyticsOperationOperation>))]
public enum AnalyticsOperationOperation
{
    [EnumMember(Value = "sum")]
    Sum,

    [EnumMember(Value = "avg")]
    Avg,

    [EnumMember(Value = "count")]
    Count,

    [EnumMember(Value = "min")]
    Min,

    [EnumMember(Value = "max")]
    Max,
}
