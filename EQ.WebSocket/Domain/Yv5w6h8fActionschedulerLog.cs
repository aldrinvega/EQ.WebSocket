using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fActionschedulerLog
{
    public long LogId { get; set; }

    public long ActionId { get; set; }

    public string Message { get; set; } = null!;

    public DateTime? LogDateGmt { get; set; }

    public DateTime? LogDateLocal { get; set; }
}
