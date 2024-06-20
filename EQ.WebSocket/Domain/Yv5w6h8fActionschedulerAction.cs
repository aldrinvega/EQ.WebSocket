using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fActionschedulerAction
{
    public long ActionId { get; set; }

    public string Hook { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime? ScheduledDateGmt { get; set; }

    public DateTime? ScheduledDateLocal { get; set; }

    public sbyte Priority { get; set; }

    public string? Args { get; set; }

    public string? Schedule { get; set; }

    public long GroupId { get; set; }

    public int Attempts { get; set; }

    public DateTime? LastAttemptGmt { get; set; }

    public DateTime? LastAttemptLocal { get; set; }

    public long ClaimId { get; set; }

    public string? ExtendedArgs { get; set; }
}
