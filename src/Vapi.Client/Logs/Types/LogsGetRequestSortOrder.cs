using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<LogsGetRequestSortOrder>))]
public enum LogsGetRequestSortOrder
{
    [EnumMember(Value = "ASC")]
    Asc,

    [EnumMember(Value = "DESC")]
    Desc,
}
