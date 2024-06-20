using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fWcfmMarketplaceRefundRequest
{
    public long Id { get; set; }

    public long VendorId { get; set; }

    public long RequestedBy { get; set; }

    public long ApprovedBy { get; set; }

    public long OrderId { get; set; }

    public long CommissionId { get; set; }

    public long ItemId { get; set; }

    public string RefundedAmount { get; set; } = null!;

    public string RefundStatus { get; set; } = null!;

    public string RefundReason { get; set; } = null!;

    public bool IsPartiallyRefunded { get; set; }

    public DateTime? RefundPaidDate { get; set; }

    public DateTime Created { get; set; }
}
