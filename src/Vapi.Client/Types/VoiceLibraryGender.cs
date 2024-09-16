using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<VoiceLibraryGender>))]
public enum VoiceLibraryGender
{
    [EnumMember(Value = "male")]
    Male,

    [EnumMember(Value = "female")]
    Female,
}
