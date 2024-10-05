using System.Net.Http;
using System.Text.Json;
using System.Threading;
using OneOf;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public partial class PhoneNumbersClient
{
    private RawClient _client;

    internal PhoneNumbersClient(RawClient client)
    {
        _client = client;
    }

    /// <example>
    /// <code>
    /// await client.PhoneNumbers.ListAsync(new PhoneNumbersListRequest());
    /// </code>
    /// </example>
    public async Task<
        IEnumerable<OneOf<ByoPhoneNumber, TwilioPhoneNumber, VonagePhoneNumber, VapiPhoneNumber>>
    > ListAsync(
        PhoneNumbersListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        if (request.CreatedAtGt != null)
        {
            _query["createdAtGt"] = request.CreatedAtGt.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.CreatedAtLt != null)
        {
            _query["createdAtLt"] = request.CreatedAtLt.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.CreatedAtGe != null)
        {
            _query["createdAtGe"] = request.CreatedAtGe.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.CreatedAtLe != null)
        {
            _query["createdAtLe"] = request.CreatedAtLe.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.UpdatedAtGt != null)
        {
            _query["updatedAtGt"] = request.UpdatedAtGt.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.UpdatedAtLt != null)
        {
            _query["updatedAtLt"] = request.UpdatedAtLt.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.UpdatedAtGe != null)
        {
            _query["updatedAtGe"] = request.UpdatedAtGe.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.UpdatedAtLe != null)
        {
            _query["updatedAtLe"] = request.UpdatedAtLe.Value.ToString(Constants.DateTimeFormat);
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = "phone-number",
                Query = _query,
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<
                    IEnumerable<
                        OneOf<ByoPhoneNumber, TwilioPhoneNumber, VonagePhoneNumber, VapiPhoneNumber>
                    >
                >(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new VapiClientException("Failed to deserialize response", e);
            }
        }

        throw new VapiClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <example>
    /// <code>
    /// await client.PhoneNumbers.CreateAsync(
    ///     new CreateByoPhoneNumberDto { Provider = "byo-phone-number", CredentialId = "credentialId" }
    /// );
    /// </code>
    /// </example>
    public async Task<
        OneOf<ByoPhoneNumber, TwilioPhoneNumber, VonagePhoneNumber, VapiPhoneNumber>
    > CreateAsync(
        OneOf<
            CreateByoPhoneNumberDto,
            CreateTwilioPhoneNumberDto,
            CreateVonagePhoneNumberDto,
            CreateVapiPhoneNumberDto
        > request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "phone-number",
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
                return JsonUtils.Deserialize<
                    OneOf<ByoPhoneNumber, TwilioPhoneNumber, VonagePhoneNumber, VapiPhoneNumber>
                >(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new VapiClientException("Failed to deserialize response", e);
            }
        }

        throw new VapiClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <example>
    /// <code>
    /// await client.PhoneNumbers.GetAsync("id");
    /// </code>
    /// </example>
    public async Task<
        OneOf<ByoPhoneNumber, TwilioPhoneNumber, VonagePhoneNumber, VapiPhoneNumber>
    > GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"phone-number/{id}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<
                    OneOf<ByoPhoneNumber, TwilioPhoneNumber, VonagePhoneNumber, VapiPhoneNumber>
                >(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new VapiClientException("Failed to deserialize response", e);
            }
        }

        throw new VapiClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <example>
    /// <code>
    /// await client.PhoneNumbers.DeleteAsync("id");
    /// </code>
    /// </example>
    public async Task<
        OneOf<ByoPhoneNumber, TwilioPhoneNumber, VonagePhoneNumber, VapiPhoneNumber>
    > DeleteAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Delete,
                Path = $"phone-number/{id}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<
                    OneOf<ByoPhoneNumber, TwilioPhoneNumber, VonagePhoneNumber, VapiPhoneNumber>
                >(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new VapiClientException("Failed to deserialize response", e);
            }
        }

        throw new VapiClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <example>
    /// <code>
    /// await client.PhoneNumbers.UpdateAsync("id", new UpdatePhoneNumberDto());
    /// </code>
    /// </example>
    public async Task<
        OneOf<ByoPhoneNumber, TwilioPhoneNumber, VonagePhoneNumber, VapiPhoneNumber>
    > UpdateAsync(
        string id,
        UpdatePhoneNumberDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethodExtensions.Patch,
                Path = $"phone-number/{id}",
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
                return JsonUtils.Deserialize<
                    OneOf<ByoPhoneNumber, TwilioPhoneNumber, VonagePhoneNumber, VapiPhoneNumber>
                >(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new VapiClientException("Failed to deserialize response", e);
            }
        }

        throw new VapiClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }
}
