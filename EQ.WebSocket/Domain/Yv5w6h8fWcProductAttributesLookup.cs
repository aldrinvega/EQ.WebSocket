using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fWcProductAttributesLookup
{
    public long ProductId { get; set; }

    public long ProductOrParentId { get; set; }

    public string Taxonomy { get; set; } = null!;

    public long TermId { get; set; }

    public bool IsVariationAttribute { get; set; }

    public bool InStock { get; set; }
}
