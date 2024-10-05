using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(StringEnumSerializer<ServerMessageEndOfCallReportEndedReason>))]
public enum ServerMessageEndOfCallReportEndedReason
{
    [EnumMember(Value = "assistant-error")]
    AssistantError,

    [EnumMember(Value = "assistant-not-found")]
    AssistantNotFound,

    [EnumMember(Value = "db-error")]
    DbError,

    [EnumMember(Value = "no-server-available")]
    NoServerAvailable,

    [EnumMember(Value = "license-check-failed")]
    LicenseCheckFailed,

    [EnumMember(Value = "pipeline-error-openai-llm-failed")]
    PipelineErrorOpenaiLlmFailed,

    [EnumMember(Value = "pipeline-error-azure-openai-llm-failed")]
    PipelineErrorAzureOpenaiLlmFailed,

    [EnumMember(Value = "pipeline-error-groq-llm-failed")]
    PipelineErrorGroqLlmFailed,

    [EnumMember(Value = "pipeline-error-anthropic-llm-failed")]
    PipelineErrorAnthropicLlmFailed,

    [EnumMember(Value = "pipeline-error-vapi-llm-failed")]
    PipelineErrorVapiLlmFailed,

    [EnumMember(Value = "pipeline-error-vapi-400-bad-request-validation-failed")]
    PipelineErrorVapi400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-vapi-401-unauthorized")]
    PipelineErrorVapi401Unauthorized,

    [EnumMember(Value = "pipeline-error-vapi-403-model-access-denied")]
    PipelineErrorVapi403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-vapi-429-exceeded-quota")]
    PipelineErrorVapi429ExceededQuota,

    [EnumMember(Value = "pipeline-error-vapi-500-server-error")]
    PipelineErrorVapi500ServerError,

    [EnumMember(Value = "pipeline-error-openai-voice-failed")]
    PipelineErrorOpenaiVoiceFailed,

    [EnumMember(Value = "pipeline-error-cartesia-voice-failed")]
    PipelineErrorCartesiaVoiceFailed,

    [EnumMember(Value = "pipeline-error-deepgram-transcriber-failed")]
    PipelineErrorDeepgramTranscriberFailed,

    [EnumMember(Value = "pipeline-error-deepgram-voice-failed")]
    PipelineErrorDeepgramVoiceFailed,

    [EnumMember(Value = "pipeline-error-gladia-transcriber-failed")]
    PipelineErrorGladiaTranscriberFailed,

    [EnumMember(Value = "pipeline-error-eleven-labs-voice-failed")]
    PipelineErrorElevenLabsVoiceFailed,

    [EnumMember(Value = "pipeline-error-playht-voice-failed")]
    PipelineErrorPlayhtVoiceFailed,

    [EnumMember(Value = "pipeline-error-lmnt-voice-failed")]
    PipelineErrorLmntVoiceFailed,

    [EnumMember(Value = "pipeline-error-azure-voice-failed")]
    PipelineErrorAzureVoiceFailed,

    [EnumMember(Value = "pipeline-error-rime-ai-voice-failed")]
    PipelineErrorRimeAiVoiceFailed,

    [EnumMember(Value = "pipeline-error-neets-voice-failed")]
    PipelineErrorNeetsVoiceFailed,

    [EnumMember(Value = "pipeline-no-available-model")]
    PipelineNoAvailableModel,

    [EnumMember(Value = "worker-shutdown")]
    WorkerShutdown,

    [EnumMember(Value = "unknown-error")]
    UnknownError,

    [EnumMember(Value = "vonage-disconnected")]
    VonageDisconnected,

    [EnumMember(Value = "vonage-failed-to-connect-call")]
    VonageFailedToConnectCall,

    [EnumMember(Value = "phone-call-provider-bypass-enabled-but-no-call-received")]
    PhoneCallProviderBypassEnabledButNoCallReceived,

    [EnumMember(Value = "vapifault-phone-call-worker-setup-socket-error")]
    VapifaultPhoneCallWorkerSetupSocketError,

    [EnumMember(Value = "vapifault-phone-call-worker-worker-setup-socket-timeout")]
    VapifaultPhoneCallWorkerWorkerSetupSocketTimeout,

    [EnumMember(Value = "vapifault-phone-call-worker-could-not-find-call")]
    VapifaultPhoneCallWorkerCouldNotFindCall,

    [EnumMember(Value = "vapifault-transport-never-connected")]
    VapifaultTransportNeverConnected,

    [EnumMember(Value = "vapifault-web-call-worker-setup-failed")]
    VapifaultWebCallWorkerSetupFailed,

    [EnumMember(Value = "vapifault-transport-connected-but-call-not-active")]
    VapifaultTransportConnectedButCallNotActive,

    [EnumMember(Value = "assistant-not-invalid")]
    AssistantNotInvalid,

    [EnumMember(Value = "assistant-not-provided")]
    AssistantNotProvided,

    [EnumMember(Value = "call-start-error-neither-assistant-nor-server-set")]
    CallStartErrorNeitherAssistantNorServerSet,

    [EnumMember(Value = "assistant-request-failed")]
    AssistantRequestFailed,

    [EnumMember(Value = "assistant-request-returned-error")]
    AssistantRequestReturnedError,

    [EnumMember(Value = "assistant-request-returned-unspeakable-error")]
    AssistantRequestReturnedUnspeakableError,

    [EnumMember(Value = "assistant-request-returned-invalid-assistant")]
    AssistantRequestReturnedInvalidAssistant,

    [EnumMember(Value = "assistant-request-returned-no-assistant")]
    AssistantRequestReturnedNoAssistant,

    [EnumMember(Value = "assistant-request-returned-forwarding-phone-number")]
    AssistantRequestReturnedForwardingPhoneNumber,

    [EnumMember(Value = "assistant-ended-call")]
    AssistantEndedCall,

    [EnumMember(Value = "assistant-said-end-call-phrase")]
    AssistantSaidEndCallPhrase,

    [EnumMember(Value = "assistant-forwarded-call")]
    AssistantForwardedCall,

    [EnumMember(Value = "assistant-join-timed-out")]
    AssistantJoinTimedOut,

    [EnumMember(Value = "customer-busy")]
    CustomerBusy,

    [EnumMember(Value = "customer-ended-call")]
    CustomerEndedCall,

    [EnumMember(Value = "customer-did-not-answer")]
    CustomerDidNotAnswer,

    [EnumMember(Value = "customer-did-not-give-microphone-permission")]
    CustomerDidNotGiveMicrophonePermission,

    [EnumMember(Value = "assistant-said-message-with-end-call-enabled")]
    AssistantSaidMessageWithEndCallEnabled,

    [EnumMember(Value = "exceeded-max-duration")]
    ExceededMaxDuration,

    [EnumMember(Value = "manually-canceled")]
    ManuallyCanceled,

    [EnumMember(Value = "phone-call-provider-closed-websocket")]
    PhoneCallProviderClosedWebsocket,

    [EnumMember(Value = "pipeline-error-openai-400-bad-request-validation-failed")]
    PipelineErrorOpenai400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-openai-401-unauthorized")]
    PipelineErrorOpenai401Unauthorized,

    [EnumMember(Value = "pipeline-error-openai-403-model-access-denied")]
    PipelineErrorOpenai403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-openai-429-exceeded-quota")]
    PipelineErrorOpenai429ExceededQuota,

    [EnumMember(Value = "pipeline-error-openai-500-server-error")]
    PipelineErrorOpenai500ServerError,

    [EnumMember(Value = "pipeline-error-azure-openai-400-bad-request-validation-failed")]
    PipelineErrorAzureOpenai400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-azure-openai-401-unauthorized")]
    PipelineErrorAzureOpenai401Unauthorized,

    [EnumMember(Value = "pipeline-error-azure-openai-403-model-access-denied")]
    PipelineErrorAzureOpenai403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-azure-openai-429-exceeded-quota")]
    PipelineErrorAzureOpenai429ExceededQuota,

    [EnumMember(Value = "pipeline-error-azure-openai-500-server-error")]
    PipelineErrorAzureOpenai500ServerError,

    [EnumMember(Value = "pipeline-error-groq-400-bad-request-validation-failed")]
    PipelineErrorGroq400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-groq-401-unauthorized")]
    PipelineErrorGroq401Unauthorized,

    [EnumMember(Value = "pipeline-error-groq-403-model-access-denied")]
    PipelineErrorGroq403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-groq-429-exceeded-quota")]
    PipelineErrorGroq429ExceededQuota,

    [EnumMember(Value = "pipeline-error-groq-500-server-error")]
    PipelineErrorGroq500ServerError,

    [EnumMember(Value = "pipeline-error-anthropic-400-bad-request-validation-failed")]
    PipelineErrorAnthropic400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-anthropic-401-unauthorized")]
    PipelineErrorAnthropic401Unauthorized,

    [EnumMember(Value = "pipeline-error-anthropic-403-model-access-denied")]
    PipelineErrorAnthropic403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-anthropic-429-exceeded-quota")]
    PipelineErrorAnthropic429ExceededQuota,

    [EnumMember(Value = "pipeline-error-anthropic-500-server-error")]
    PipelineErrorAnthropic500ServerError,

    [EnumMember(Value = "pipeline-error-together-ai-400-bad-request-validation-failed")]
    PipelineErrorTogetherAi400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-together-ai-401-unauthorized")]
    PipelineErrorTogetherAi401Unauthorized,

    [EnumMember(Value = "pipeline-error-together-ai-403-model-access-denied")]
    PipelineErrorTogetherAi403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-together-ai-429-exceeded-quota")]
    PipelineErrorTogetherAi429ExceededQuota,

    [EnumMember(Value = "pipeline-error-together-ai-500-server-error")]
    PipelineErrorTogetherAi500ServerError,

    [EnumMember(Value = "pipeline-error-together-ai-llm-failed")]
    PipelineErrorTogetherAiLlmFailed,

    [EnumMember(Value = "pipeline-error-anyscale-400-bad-request-validation-failed")]
    PipelineErrorAnyscale400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-anyscale-401-unauthorized")]
    PipelineErrorAnyscale401Unauthorized,

    [EnumMember(Value = "pipeline-error-anyscale-403-model-access-denied")]
    PipelineErrorAnyscale403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-anyscale-429-exceeded-quota")]
    PipelineErrorAnyscale429ExceededQuota,

    [EnumMember(Value = "pipeline-error-anyscale-500-server-error")]
    PipelineErrorAnyscale500ServerError,

    [EnumMember(Value = "pipeline-error-anyscale-llm-failed")]
    PipelineErrorAnyscaleLlmFailed,

    [EnumMember(Value = "pipeline-error-openrouter-400-bad-request-validation-failed")]
    PipelineErrorOpenrouter400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-openrouter-401-unauthorized")]
    PipelineErrorOpenrouter401Unauthorized,

    [EnumMember(Value = "pipeline-error-openrouter-403-model-access-denied")]
    PipelineErrorOpenrouter403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-openrouter-429-exceeded-quota")]
    PipelineErrorOpenrouter429ExceededQuota,

    [EnumMember(Value = "pipeline-error-openrouter-500-server-error")]
    PipelineErrorOpenrouter500ServerError,

    [EnumMember(Value = "pipeline-error-openrouter-llm-failed")]
    PipelineErrorOpenrouterLlmFailed,

    [EnumMember(Value = "pipeline-error-perplexity-ai-400-bad-request-validation-failed")]
    PipelineErrorPerplexityAi400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-perplexity-ai-401-unauthorized")]
    PipelineErrorPerplexityAi401Unauthorized,

    [EnumMember(Value = "pipeline-error-perplexity-ai-403-model-access-denied")]
    PipelineErrorPerplexityAi403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-perplexity-ai-429-exceeded-quota")]
    PipelineErrorPerplexityAi429ExceededQuota,

    [EnumMember(Value = "pipeline-error-perplexity-ai-500-server-error")]
    PipelineErrorPerplexityAi500ServerError,

    [EnumMember(Value = "pipeline-error-perplexity-ai-llm-failed")]
    PipelineErrorPerplexityAiLlmFailed,

    [EnumMember(Value = "pipeline-error-deepinfra-400-bad-request-validation-failed")]
    PipelineErrorDeepinfra400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-deepinfra-401-unauthorized")]
    PipelineErrorDeepinfra401Unauthorized,

    [EnumMember(Value = "pipeline-error-deepinfra-403-model-access-denied")]
    PipelineErrorDeepinfra403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-deepinfra-429-exceeded-quota")]
    PipelineErrorDeepinfra429ExceededQuota,

    [EnumMember(Value = "pipeline-error-deepinfra-500-server-error")]
    PipelineErrorDeepinfra500ServerError,

    [EnumMember(Value = "pipeline-error-deepinfra-llm-failed")]
    PipelineErrorDeepinfraLlmFailed,

    [EnumMember(Value = "pipeline-error-runpod-400-bad-request-validation-failed")]
    PipelineErrorRunpod400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-runpod-401-unauthorized")]
    PipelineErrorRunpod401Unauthorized,

    [EnumMember(Value = "pipeline-error-runpod-403-model-access-denied")]
    PipelineErrorRunpod403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-runpod-429-exceeded-quota")]
    PipelineErrorRunpod429ExceededQuota,

    [EnumMember(Value = "pipeline-error-runpod-500-server-error")]
    PipelineErrorRunpod500ServerError,

    [EnumMember(Value = "pipeline-error-runpod-llm-failed")]
    PipelineErrorRunpodLlmFailed,

    [EnumMember(Value = "pipeline-error-custom-llm-400-bad-request-validation-failed")]
    PipelineErrorCustomLlm400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-custom-llm-401-unauthorized")]
    PipelineErrorCustomLlm401Unauthorized,

    [EnumMember(Value = "pipeline-error-custom-llm-403-model-access-denied")]
    PipelineErrorCustomLlm403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-custom-llm-429-exceeded-quota")]
    PipelineErrorCustomLlm429ExceededQuota,

    [EnumMember(Value = "pipeline-error-custom-llm-500-server-error")]
    PipelineErrorCustomLlm500ServerError,

    [EnumMember(Value = "pipeline-error-custom-llm-llm-failed")]
    PipelineErrorCustomLlmLlmFailed,

    [EnumMember(Value = "pipeline-error-cartesia-socket-hang-up")]
    PipelineErrorCartesiaSocketHangUp,

    [EnumMember(Value = "pipeline-error-cartesia-requested-payment")]
    PipelineErrorCartesiaRequestedPayment,

    [EnumMember(Value = "pipeline-error-cartesia-500-server-error")]
    PipelineErrorCartesia500ServerError,

    [EnumMember(Value = "pipeline-error-cartesia-503-server-error")]
    PipelineErrorCartesia503ServerError,

    [EnumMember(Value = "pipeline-error-cartesia-522-server-error")]
    PipelineErrorCartesia522ServerError,

    [EnumMember(Value = "pipeline-error-custom-voice-failed")]
    PipelineErrorCustomVoiceFailed,

    [EnumMember(Value = "pipeline-error-eleven-labs-voice-not-found")]
    PipelineErrorElevenLabsVoiceNotFound,

    [EnumMember(Value = "pipeline-error-eleven-labs-quota-exceeded")]
    PipelineErrorElevenLabsQuotaExceeded,

    [EnumMember(Value = "pipeline-error-eleven-labs-unauthorized-access")]
    PipelineErrorElevenLabsUnauthorizedAccess,

    [EnumMember(Value = "pipeline-error-eleven-labs-unauthorized-to-access-model")]
    PipelineErrorElevenLabsUnauthorizedToAccessModel,

    [EnumMember(Value = "pipeline-error-eleven-labs-professional-voices-only-for-creator-plus")]
    PipelineErrorElevenLabsProfessionalVoicesOnlyForCreatorPlus,

    [EnumMember(Value = "pipeline-error-eleven-labs-blocked-free-plan-and-requested-upgrade")]
    PipelineErrorElevenLabsBlockedFreePlanAndRequestedUpgrade,

    [EnumMember(
        Value = "pipeline-error-eleven-labs-blocked-concurrent-requests-and-requested-upgrade"
    )]
    PipelineErrorElevenLabsBlockedConcurrentRequestsAndRequestedUpgrade,

    [EnumMember(
        Value = "pipeline-error-eleven-labs-blocked-using-instant-voice-clone-and-requested-upgrade"
    )]
    PipelineErrorElevenLabsBlockedUsingInstantVoiceCloneAndRequestedUpgrade,

    [EnumMember(Value = "pipeline-error-eleven-labs-system-busy-and-requested-upgrade")]
    PipelineErrorElevenLabsSystemBusyAndRequestedUpgrade,

    [EnumMember(Value = "pipeline-error-eleven-labs-voice-not-fine-tuned")]
    PipelineErrorElevenLabsVoiceNotFineTuned,

    [EnumMember(Value = "pipeline-error-eleven-labs-invalid-api-key")]
    PipelineErrorElevenLabsInvalidApiKey,

    [EnumMember(Value = "pipeline-error-eleven-labs-invalid-voice-samples")]
    PipelineErrorElevenLabsInvalidVoiceSamples,

    [EnumMember(Value = "pipeline-error-eleven-labs-voice-disabled-by-owner")]
    PipelineErrorElevenLabsVoiceDisabledByOwner,

    [EnumMember(Value = "pipeline-error-eleven-labs-blocked-account-in-probation")]
    PipelineErrorElevenLabsBlockedAccountInProbation,

    [EnumMember(Value = "pipeline-error-eleven-labs-blocked-content-against-their-policy")]
    PipelineErrorElevenLabsBlockedContentAgainstTheirPolicy,

    [EnumMember(Value = "pipeline-error-eleven-labs-missing-samples-for-voice-clone")]
    PipelineErrorElevenLabsMissingSamplesForVoiceClone,

    [EnumMember(Value = "pipeline-error-eleven-labs-voice-not-fine-tuned-and-cannot-be-used")]
    PipelineErrorElevenLabsVoiceNotFineTunedAndCannotBeUsed,

    [EnumMember(Value = "pipeline-error-eleven-labs-voice-not-allowed-for-free-users")]
    PipelineErrorElevenLabsVoiceNotAllowedForFreeUsers,

    [EnumMember(Value = "pipeline-error-eleven-labs-500-server-error")]
    PipelineErrorElevenLabs500ServerError,

    [EnumMember(Value = "pipeline-error-eleven-labs-max-character-limit-exceeded")]
    PipelineErrorElevenLabsMaxCharacterLimitExceeded,

    [EnumMember(Value = "pipeline-error-playht-request-timed-out")]
    PipelineErrorPlayhtRequestTimedOut,

    [EnumMember(Value = "pipeline-error-playht-invalid-voice")]
    PipelineErrorPlayhtInvalidVoice,

    [EnumMember(Value = "pipeline-error-playht-unexpected-error")]
    PipelineErrorPlayhtUnexpectedError,

    [EnumMember(Value = "pipeline-error-playht-out-of-credits")]
    PipelineErrorPlayhtOutOfCredits,

    [EnumMember(Value = "pipeline-error-playht-voice-must-be-a-valid-voice-manifest-uri")]
    PipelineErrorPlayhtVoiceMustBeAValidVoiceManifestUri,

    [EnumMember(Value = "pipeline-error-playht-401-unauthorized")]
    PipelineErrorPlayht401Unauthorized,

    [EnumMember(Value = "pipeline-error-playht-403-forbidden-out-of-characters")]
    PipelineErrorPlayht403ForbiddenOutOfCharacters,

    [EnumMember(Value = "pipeline-error-playht-403-forbidden-api-access-not-available")]
    PipelineErrorPlayht403ForbiddenApiAccessNotAvailable,

    [EnumMember(Value = "pipeline-error-playht-429-exceeded-quota")]
    PipelineErrorPlayht429ExceededQuota,

    [EnumMember(Value = "pipeline-error-playht-502-gateway-error")]
    PipelineErrorPlayht502GatewayError,

    [EnumMember(Value = "pipeline-error-playht-504-gateway-error")]
    PipelineErrorPlayht504GatewayError,

    [EnumMember(Value = "pipeline-error-deepgram-403-model-access-denied")]
    PipelineErrorDeepgram403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-deepgram-404-not-found")]
    PipelineErrorDeepgram404NotFound,

    [EnumMember(Value = "pipeline-error-deepgram-400-no-such-model-language-tier-combination")]
    PipelineErrorDeepgram400NoSuchModelLanguageTierCombination,

    [EnumMember(Value = "pipeline-error-deepgram-500-returning-invalid-json")]
    PipelineErrorDeepgram500ReturningInvalidJson,

    [EnumMember(Value = "sip-gateway-failed-to-connect-call")]
    SipGatewayFailedToConnectCall,

    [EnumMember(Value = "silence-timed-out")]
    SilenceTimedOut,

    [EnumMember(Value = "twilio-failed-to-connect-call")]
    TwilioFailedToConnectCall,

    [EnumMember(Value = "twilio-reported-customer-misdialed")]
    TwilioReportedCustomerMisdialed,

    [EnumMember(Value = "voicemail")]
    Voicemail,

    [EnumMember(Value = "vonage-rejected")]
    VonageRejected,
}
