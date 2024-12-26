using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<OrgWithOrgUserChannel>))]
public enum OrgWithOrgUserChannel
{
    [EnumMember(Value = "default")]
    Default,

    [EnumMember(Value = "weekly")]
    Weekly,
}
