using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record ClientMessageHang
{
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
