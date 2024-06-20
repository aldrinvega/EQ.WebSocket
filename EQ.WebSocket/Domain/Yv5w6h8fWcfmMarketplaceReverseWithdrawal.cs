using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fWcfmMarketplaceReverseWithdrawal
{
    public long Id { get; set; }

    public long VendorId { get; set; }

    public long OrderId { get; set; }

    public long CommissionId { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public string GrossTotal { get; set; } = null!;

    public string Commission { get; set; } = null!;

    public string Balance { get; set; } = null!;

    public string WithdrawStatus { get; set; } = null!;

    public string WithdrawNote { get; set; } = null!;

    public DateTime? WithdrawPaidDate { get; set; }

    public DateTime Created { get; set; }
}
