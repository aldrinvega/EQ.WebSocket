using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fWoocommercePaymentToken
{
    public long TokenId { get; set; }

    public string GatewayId { get; set; } = null!;

    public string Token { get; set; } = null!;

    public long UserId { get; set; }

    public string Type { get; set; } = null!;

    public bool IsDefault { get; set; }
}
