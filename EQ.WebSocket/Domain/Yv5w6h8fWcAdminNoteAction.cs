using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fWcAdminNoteAction
{
    public long ActionId { get; set; }

    public long NoteId { get; set; }

    public string Name { get; set; } = null!;

    public string Label { get; set; } = null!;

    public string Query { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string ActionedText { get; set; } = null!;

    public string? NonceAction { get; set; }

    public string? NonceName { get; set; }
}
