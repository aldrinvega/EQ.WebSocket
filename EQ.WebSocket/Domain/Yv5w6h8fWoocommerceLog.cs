using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fWoocommerceLog
{
    public long LogId { get; set; }

    public DateTime Timestamp { get; set; }

    public short Level { get; set; }

    public string Source { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string? Context { get; set; }
}
