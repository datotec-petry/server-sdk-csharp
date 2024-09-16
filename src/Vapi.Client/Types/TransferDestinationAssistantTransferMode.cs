using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<TransferDestinationAssistantTransferMode>))]
public enum TransferDestinationAssistantTransferMode
{
    [EnumMember(Value = "rolling-history")]
    RollingHistory,

    [EnumMember(Value = "swap-system-message-in-history")]
    SwapSystemMessageInHistory,
}
