using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fWcAdminNote
{
    public long NoteId { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Locale { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public string? ContentData { get; set; }

    public string Status { get; set; } = null!;

    public string Source { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public DateTime? DateReminder { get; set; }

    public bool IsSnoozable { get; set; }

    public string Layout { get; set; } = null!;

    public string? Image { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsRead { get; set; }

    public string Icon { get; set; } = null!;
}
