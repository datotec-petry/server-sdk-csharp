using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<SuccessEvaluationPlanRubric>))]
public enum SuccessEvaluationPlanRubric
{
    [EnumMember(Value = "NumericScale")]
    NumericScale,

    [EnumMember(Value = "DescriptiveScale")]
    DescriptiveScale,

    [EnumMember(Value = "Checklist")]
    Checklist,

    [EnumMember(Value = "Matrix")]
    Matrix,

    [EnumMember(Value = "PercentageScale")]
    PercentageScale,

    [EnumMember(Value = "LikertScale")]
    LikertScale,

    [EnumMember(Value = "AutomaticRubric")]
    AutomaticRubric,

    [EnumMember(Value = "PassFail")]
    PassFail,
}
