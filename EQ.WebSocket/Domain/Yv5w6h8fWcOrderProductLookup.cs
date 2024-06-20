using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fWcOrderProductLookup
{
    public long OrderItemId { get; set; }

    public long OrderId { get; set; }

    public long ProductId { get; set; }

    public long VariationId { get; set; }

    public long? CustomerId { get; set; }

    public DateTime DateCreated { get; set; }

    public int ProductQty { get; set; }

    public double ProductNetRevenue { get; set; }

    public double ProductGrossRevenue { get; set; }

    public double CouponAmount { get; set; }

    public double TaxAmount { get; set; }

    public double ShippingAmount { get; set; }

    public double ShippingTaxAmount { get; set; }
}
