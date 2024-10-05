using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record CreateByoPhoneNumberDto
{
    /// <summary>
    /// This is the fallback destination an inbound call will be transferred to if:
    ///
    /// 1. `assistantId` is not set
    /// 2. `squadId` is not set
    /// 3. and, `assistant-request` message to the `serverUrl` fails
    ///
    /// If this is not set and above conditions are met, the inbound call is hung up with an error message.
    /// </summary>
    [JsonPropertyName("fallbackDestination")]
    public OneOf<
        TransferDestinationNumber,
        TransferDestinationSip
    >? FallbackDestination { get; set; }

    [JsonPropertyName("provider")]
    public required string Provider { get; set; }

    /// <summary>
    /// This is the flag to toggle the E164 check for the `number` field. This is an advanced property which should be used if you know your use case requires it.
    ///
    /// Use cases:
    ///
    /// - `false`: To allow non-E164 numbers like `+001234567890`, `1234`, or `abc`. This is useful for dialing out to non-E164 numbers on your SIP trunks.
    /// - `true` (default): To allow only E164 numbers like `+14155551234`. This is standard for PSTN calls.
    ///
    /// If `false`, the `number` is still required to only contain alphanumeric characters (regex: `/^\+?[a-zA-Z0-9]+$/`).
    ///
    /// @default true (E164 check is enabled)
    /// </summary>
    [JsonPropertyName("numberE164CheckEnabled")]
    public bool? NumberE164CheckEnabled { get; set; }

    /// <summary>
    /// This is the number of the customer.
    /// </summary>
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    /// <summary>
    /// This is the credential of your own SIP trunk or Carrier (type `byo-sip-trunk`) which can be used to make calls to this phone number.
    ///
    /// You can add the SIP trunk or Carrier credential in the Provider Credentials page on the Dashboard to get the credentialId.
    /// </summary>
    [JsonPropertyName("credentialId")]
    public required string CredentialId { get; set; }

    /// <summary>
    /// This is the name of the phone number. This is just for your own reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the assistant that will be used for incoming calls to this phone number.
    ///
    /// If neither `assistantId` nor `squadId` is set, `assistant-request` will be sent to your Server URL. Check `ServerMessage` and `ServerMessageResponse` for the shape of the message and response that is expected.
    /// </summary>
    [JsonPropertyName("assistantId")]
    public string? AssistantId { get; set; }

    /// <summary>
    /// This is the squad that will be used for incoming calls to this phone number.
    ///
    /// If neither `assistantId` nor `squadId` is set, `assistant-request` will be sent to your Server URL. Check `ServerMessage` and `ServerMessageResponse` for the shape of the message and response that is expected.
    /// </summary>
    [JsonPropertyName("squadId")]
    public string? SquadId { get; set; }

    /// <summary>
    /// This is the server URL where messages will be sent for calls on this number. This includes the `assistant-request` message.
    ///
    /// You can see the shape of the messages sent in `ServerMessage`.
    ///
    /// This overrides the `org.serverUrl`. Order of precedence: tool.server.url > assistant.serverUrl > phoneNumber.serverUrl > org.serverUrl.
    /// </summary>
    [JsonPropertyName("serverUrl")]
    public string? ServerUrl { get; set; }

    /// <summary>
    /// This is the secret Vapi will send with every message to your server. It's sent as a header called x-vapi-secret.
    ///
    /// Same precedence logic as serverUrl.
    /// </summary>
    [JsonPropertyName("serverUrlSecret")]
    public string? ServerUrlSecret { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
