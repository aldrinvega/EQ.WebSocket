using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fWcWebhook
{
    public long WebhookId { get; set; }

    public string Status { get; set; } = null!;

    public string Name { get; set; } = null!;

    public long UserId { get; set; }

    public string DeliveryUrl { get; set; } = null!;

    public string Secret { get; set; } = null!;

    public string Topic { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public DateTime DateCreatedGmt { get; set; }

    public DateTime DateModified { get; set; }

    public DateTime DateModifiedGmt { get; set; }

    public short ApiVersion { get; set; }

    public short FailureCount { get; set; }

    public bool PendingDelivery { get; set; }
}
