using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public partial class AnalyticsClient
{
    private RawClient _client;

    internal AnalyticsClient(RawClient client)
    {
        _client = client;
    }

    public async Task GetAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "analytics",
                Options = options,
            },
            cancellationToken
        );
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
        }
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        throw new VapiClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }
}
