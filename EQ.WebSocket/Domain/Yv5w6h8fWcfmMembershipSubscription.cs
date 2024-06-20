using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fWcfmMembershipSubscription
{
    public long Id { get; set; }

    public long VendorId { get; set; }

    public long MembershipId { get; set; }

    public string SubscriptionType { get; set; } = null!;

    public int SubscriptionAmt { get; set; }

    public string SubscriptionInterval { get; set; } = null!;

    public string Event { get; set; } = null!;

    public string PayMode { get; set; } = null!;

    public string TransactionId { get; set; } = null!;

    public string TransactionType { get; set; } = null!;

    public string TransactionStatus { get; set; } = null!;

    public string TransactionDetails { get; set; } = null!;

    public DateTime Created { get; set; }
}
