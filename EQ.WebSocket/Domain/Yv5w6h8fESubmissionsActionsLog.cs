using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fESubmissionsActionsLog
{
    public long Id { get; set; }

    public long SubmissionId { get; set; }

    public string ActionName { get; set; } = null!;

    public string? ActionLabel { get; set; }

    public string Status { get; set; } = null!;

    public string? Log { get; set; }

    public DateTime CreatedAtGmt { get; set; }

    public DateTime UpdatedAtGmt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
