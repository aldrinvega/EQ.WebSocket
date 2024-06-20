using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fWcfmEnquiry
{
    public long Id { get; set; }

    public string Enquiry { get; set; } = null!;

    public string Reply { get; set; } = null!;

    public long ProductId { get; set; }

    public long AuthorId { get; set; }

    public long VendorId { get; set; }

    public long CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string CustomerEmail { get; set; } = null!;

    public long ReplyBy { get; set; }

    public bool IsPrivate { get; set; }

    public DateTime Posted { get; set; }

    public DateTime Replied { get; set; }
}
