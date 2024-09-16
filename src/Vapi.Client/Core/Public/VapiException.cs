using System;

#nullable enable

namespace Vapi.Client;

/// <summary>
/// Base exception class for all exceptions thrown by the SDK.
/// </summary>
public class VapiException(string message, Exception? innerException = null)
    : Exception(message, innerException) { }
