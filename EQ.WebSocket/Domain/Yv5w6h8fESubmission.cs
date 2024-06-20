using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fESubmission
{
    public long Id { get; set; }

    public string? Type { get; set; }

    public string HashId { get; set; } = null!;

    /// <summary>
    /// Id of main field. to represent the main meta field
    /// </summary>
    public long MainMetaId { get; set; }

    public long PostId { get; set; }

    public string Referer { get; set; } = null!;

    public string? RefererTitle { get; set; }

    public string ElementId { get; set; } = null!;

    public string FormName { get; set; } = null!;

    public long CampaignId { get; set; }

    public long? UserId { get; set; }

    public string UserIp { get; set; } = null!;

    public string UserAgent { get; set; } = null!;

    public int? ActionsCount { get; set; }

    public int? ActionsSucceededCount { get; set; }

    public string Status { get; set; } = null!;

    public bool IsRead { get; set; }

    public string? Meta { get; set; }

    public DateTime CreatedAtGmt { get; set; }

    public DateTime UpdatedAtGmt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
