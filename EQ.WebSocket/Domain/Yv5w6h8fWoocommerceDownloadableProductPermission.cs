using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fWoocommerceDownloadableProductPermission
{
    public long PermissionId { get; set; }

    public string DownloadId { get; set; } = null!;

    public long ProductId { get; set; }

    public long OrderId { get; set; }

    public string OrderKey { get; set; } = null!;

    public string UserEmail { get; set; } = null!;

    public long? UserId { get; set; }

    public string? DownloadsRemaining { get; set; }

    public DateTime AccessGranted { get; set; }

    public DateTime? AccessExpires { get; set; }

    public long DownloadCount { get; set; }
}
