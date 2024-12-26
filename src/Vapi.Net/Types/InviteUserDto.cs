using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record InviteUserDto
{
    [JsonPropertyName("emails")]
    public IEnumerable<string> Emails { get; set; } = new List<string>();

    [JsonPropertyName("role")]
    public required InviteUserDtoRole Role { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
