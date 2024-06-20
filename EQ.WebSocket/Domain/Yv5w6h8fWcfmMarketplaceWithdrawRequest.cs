using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fWcfmMarketplaceWithdrawRequest
{
    public long Id { get; set; }

    public long VendorId { get; set; }

    public string OrderIds { get; set; } = null!;

    public string CommissionIds { get; set; } = null!;

    public string PaymentMethod { get; set; } = null!;

    public string WithdrawAmount { get; set; } = null!;

    public string WithdrawCharges { get; set; } = null!;

    public string WithdrawStatus { get; set; } = null!;

    public string WithdrawMode { get; set; } = null!;

    public string WithdrawNote { get; set; } = null!;

    public bool IsAutoWithdrawal { get; set; }

    public DateTime? WithdrawPaidDate { get; set; }

    public DateTime Created { get; set; }
}
