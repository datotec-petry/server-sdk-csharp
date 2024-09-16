using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record ClientMessageHang
{
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
