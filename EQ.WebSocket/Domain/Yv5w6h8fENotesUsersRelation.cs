using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fENotesUsersRelation
{
    public long Id { get; set; }

    /// <summary>
    /// The relation type between user and note (e.g mention, watch, read).
    /// </summary>
    public string Type { get; set; } = null!;

    public long NoteId { get; set; }

    public long UserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
