using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(StringEnumSerializer<LmntVoiceIdEnum>))]
public enum LmntVoiceIdEnum
{
    [EnumMember(Value = "lily")]
    Lily,

    [EnumMember(Value = "daniel")]
    Daniel,
}
