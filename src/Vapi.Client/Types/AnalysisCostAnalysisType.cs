using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<AnalysisCostAnalysisType>))]
public enum AnalysisCostAnalysisType
{
    [EnumMember(Value = "summary")]
    Summary,

    [EnumMember(Value = "structuredData")]
    StructuredData,

    [EnumMember(Value = "successEvaluation")]
    SuccessEvaluation,
}
