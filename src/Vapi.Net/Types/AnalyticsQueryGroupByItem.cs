using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(StringEnumSerializer<AnalyticsQueryGroupByItem>))]
public enum AnalyticsQueryGroupByItem
{
    [EnumMember(Value = "type")]
    Type,

    [EnumMember(Value = "assistantId")]
    AssistantId,

    [EnumMember(Value = "endedReason")]
    EndedReason,

    [EnumMember(Value = "analysis.successEvaluation")]
    AnalysisSuccessEvaluation,

    [EnumMember(Value = "status")]
    Status,
}
