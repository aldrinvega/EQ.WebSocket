using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fWcfmMessagesModifier
{
    public long Id { get; set; }

    public long Message { get; set; }

    public bool IsRead { get; set; }

    public long ReadBy { get; set; }

    public DateTime ReadOn { get; set; }

    public bool IsTrashed { get; set; }

    public long TrashedBy { get; set; }

    public DateTime TrashedOn { get; set; }
}
