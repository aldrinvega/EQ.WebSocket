using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fWcfmMarketplaceVendorLedger
{
    public long Id { get; set; }

    public long VendorId { get; set; }

    public string Credit { get; set; } = null!;

    public string Debit { get; set; } = null!;

    public long ReferenceId { get; set; }

    public string Reference { get; set; } = null!;

    public string ReferenceDetails { get; set; } = null!;

    public string ReferenceStatus { get; set; } = null!;

    public DateTime? ReferenceUpdateDate { get; set; }

    public DateTime Created { get; set; }
}
