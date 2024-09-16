using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public partial class AnalyticsClient
{
    private RawClient _client;

    internal AnalyticsClient(RawClient client)
    {
        _client = client;
    }

    /// <example>
    /// <code>
    /// await client.Analytics.GetAsync(
    ///     new AnalyticsQueryDto
    ///     {
    ///         Queries = new List<AnalyticsQuery>()
    ///         {
    ///             new AnalyticsQuery
    ///             {
    ///                 Table = "call",
    ///                 Name = "name",
    ///                 Operations = new List<AnalyticsOperation>()
    ///                 {
    ///                     new AnalyticsOperation
    ///                     {
    ///                         Operation = AnalyticsOperationOperation.Sum,
    ///                         Column = AnalyticsOperationColumn.Id,
    ///                     },
    ///                 },
    ///             },
    ///         },
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<IEnumerable<AnalyticsQueryResult>> GetAsync(
        AnalyticsQueryDto request,
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
                Body = request,
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<IEnumerable<AnalyticsQueryResult>>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new VapiException("Failed to deserialize response", e);
            }
        }

        throw new VapiApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }
}
