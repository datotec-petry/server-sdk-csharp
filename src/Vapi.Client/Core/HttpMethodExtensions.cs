using System.Net.Http;

namespace Vapi.Client.Core;

internal static class HttpMethodExtensions
{
    public static readonly HttpMethod Patch = new("PATCH");
}
