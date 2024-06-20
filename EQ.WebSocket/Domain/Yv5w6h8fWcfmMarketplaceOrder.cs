using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fWcfmMarketplaceOrder
{
    public long Id { get; set; }

    public long VendorId { get; set; }

    public long OrderId { get; set; }

    public long CustomerId { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public long ProductId { get; set; }

    public long VariationId { get; set; }

    public long Quantity { get; set; }

    public string? ProductPrice { get; set; }

    public string PurchasePrice { get; set; } = null!;

    public long ItemId { get; set; }

    public string? ItemType { get; set; }

    public string? ItemSubTotal { get; set; }

    public string? ItemTotal { get; set; }

    public string Shipping { get; set; } = null!;

    public string Tax { get; set; } = null!;

    public string ShippingTaxAmount { get; set; } = null!;

    public string CommissionAmount { get; set; } = null!;

    public string DiscountAmount { get; set; } = null!;

    public string DiscountType { get; set; } = null!;

    public string OtherAmount { get; set; } = null!;

    public string OtherAmountType { get; set; } = null!;

    public long WithdrawalId { get; set; }

    public long RefundedId { get; set; }

    public string RefundedAmount { get; set; } = null!;

    public string WithdrawCharges { get; set; } = null!;

    public string TotalCommission { get; set; } = null!;

    public string OrderStatus { get; set; } = null!;

    public string ShippingStatus { get; set; } = null!;

    public string CommissionStatus { get; set; } = null!;

    public string WithdrawStatus { get; set; } = null!;

    public string RefundStatus { get; set; } = null!;

    public bool IsRefunded { get; set; }

    public bool IsPartiallyRefunded { get; set; }

    public bool IsWithdrawable { get; set; }

    public bool IsAutoWithdrawal { get; set; }

    public bool IsTrashed { get; set; }

    public DateTime? CommissionPaidDate { get; set; }

    public DateTime Created { get; set; }
}
