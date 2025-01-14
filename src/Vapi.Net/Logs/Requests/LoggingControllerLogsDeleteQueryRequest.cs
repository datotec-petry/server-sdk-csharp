using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record LoggingControllerLogsDeleteQueryRequest
{
    /// <summary>
    /// This is the unique identifier for the org that this log belongs to.
    /// </summary>
    public string? OrgId { get; set; }

    /// <summary>
    /// This is the ID of the assistant.
    /// </summary>
    public string? AssistantId { get; set; }

    /// <summary>
    /// This is the ID of the phone number.
    /// </summary>
    public string? PhoneNumberId { get; set; }

    /// <summary>
    /// This is the ID of the customer.
    /// </summary>
    public string? CustomerId { get; set; }

    /// <summary>
    /// This is the ID of the squad.
    /// </summary>
    public string? SquadId { get; set; }

    /// <summary>
    /// This is the ID of the call.
    /// </summary>
    public string? CallId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
