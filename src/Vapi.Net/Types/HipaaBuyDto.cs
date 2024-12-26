using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record HipaaBuyDto
{
    /// <summary>
    /// This is the name of the recipient.
    /// </summary>
    [JsonPropertyName("recipientName")]
    public required string RecipientName { get; set; }

    /// <summary>
    /// This is the name of the recipient organization.
    /// </summary>
    [JsonPropertyName("recipientOrganization")]
    public required string RecipientOrganization { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
