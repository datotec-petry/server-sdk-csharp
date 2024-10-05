using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record CreateS3CredentialDto
{
    /// <summary>
    /// Credential provider. Only allowed value is s3
    /// </summary>
    [JsonPropertyName("provider")]
    public required string Provider { get; set; }

    /// <summary>
    /// AWS access key ID.
    /// </summary>
    [JsonPropertyName("awsAccessKeyId")]
    public required string AwsAccessKeyId { get; set; }

    /// <summary>
    /// AWS access key secret. This is not returned in the API.
    /// </summary>
    [JsonPropertyName("awsSecretAccessKey")]
    public required string AwsSecretAccessKey { get; set; }

    /// <summary>
    /// AWS region in which the S3 bucket is located.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>
    /// AWS S3 bucket name.
    /// </summary>
    [JsonPropertyName("s3BucketName")]
    public required string S3BucketName { get; set; }

    /// <summary>
    /// The path prefix for the uploaded recording. Ex. "recordings/"
    /// </summary>
    [JsonPropertyName("s3PathPrefix")]
    public required string S3PathPrefix { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
