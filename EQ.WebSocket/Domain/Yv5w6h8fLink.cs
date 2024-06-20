using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fLink
{
    public long LinkId { get; set; }

    public string LinkUrl { get; set; } = null!;

    public string LinkName { get; set; } = null!;

    public string LinkImage { get; set; } = null!;

    public string LinkTarget { get; set; } = null!;

    public string LinkDescription { get; set; } = null!;

    public string LinkVisible { get; set; } = null!;

    public long LinkOwner { get; set; }

    public int LinkRating { get; set; }

    public DateTime LinkUpdated { get; set; }

    public string LinkRel { get; set; } = null!;

    public string LinkNotes { get; set; } = null!;

    public string LinkRss { get; set; } = null!;
}
