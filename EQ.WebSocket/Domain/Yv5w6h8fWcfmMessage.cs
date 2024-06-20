using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fWcfmMessage
{
    public long Id { get; set; }

    public string Message { get; set; } = null!;

    public long AuthorId { get; set; }

    public long ReplyTo { get; set; }

    public long MessageTo { get; set; }

    public bool AuthorIsAdmin { get; set; }

    public bool AuthorIsVendor { get; set; }

    public bool AuthorIsCustomer { get; set; }

    public bool IsNotice { get; set; }

    public bool IsDirectMessage { get; set; }

    public bool IsPined { get; set; }

    public string MessageType { get; set; } = null!;

    public DateTime Created { get; set; }
}
