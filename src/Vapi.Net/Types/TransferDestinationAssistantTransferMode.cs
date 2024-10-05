using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(StringEnumSerializer<TransferDestinationAssistantTransferMode>))]
public enum TransferDestinationAssistantTransferMode
{
    [EnumMember(Value = "rolling-history")]
    RollingHistory,

    [EnumMember(Value = "swap-system-message-in-history")]
    SwapSystemMessageInHistory,
}
