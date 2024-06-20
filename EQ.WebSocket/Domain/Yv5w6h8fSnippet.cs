using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fSnippet
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string Tags { get; set; } = null!;

    public string Scope { get; set; } = null!;

    public short Priority { get; set; }

    public bool Active { get; set; }

    public DateTime Modified { get; set; }

    public long Revision { get; set; }

    public string? CloudId { get; set; }
}
