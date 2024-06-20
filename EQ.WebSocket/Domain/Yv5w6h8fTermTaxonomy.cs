using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fTermTaxonomy
{
    public long TermTaxonomyId { get; set; }

    public long TermId { get; set; }

    public string Taxonomy { get; set; } = null!;

    public string Description { get; set; } = null!;

    public long Parent { get; set; }

    public long Count { get; set; }
}
