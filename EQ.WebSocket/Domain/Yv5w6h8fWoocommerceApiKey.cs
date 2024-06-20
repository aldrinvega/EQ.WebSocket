using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fWoocommerceApiKey
{
    public long KeyId { get; set; }

    public long UserId { get; set; }

    public string? Description { get; set; }

    public string Permissions { get; set; } = null!;

    public string ConsumerKey { get; set; } = null!;

    public string ConsumerSecret { get; set; } = null!;

    public string? Nonces { get; set; }

    public string TruncatedKey { get; set; } = null!;

    public DateTime? LastAccess { get; set; }
}
