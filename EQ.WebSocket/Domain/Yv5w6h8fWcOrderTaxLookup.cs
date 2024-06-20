using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fWcOrderTaxLookup
{
    public long OrderId { get; set; }

    public long TaxRateId { get; set; }

    public DateTime DateCreated { get; set; }

    public double ShippingTax { get; set; }

    public double OrderTax { get; set; }

    public double TotalTax { get; set; }
}
