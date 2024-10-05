using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record SbcConfiguration
{
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
