using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fWcfmMarketplaceReviewsResponse
{
    public long Id { get; set; }

    public long ReviewId { get; set; }

    public long VendorId { get; set; }

    public long AuthorId { get; set; }

    public string AuthorName { get; set; } = null!;

    public string AuthorEmail { get; set; } = null!;

    public string Reply { get; set; } = null!;

    public long ReplyBy { get; set; }

    public DateTime Posted { get; set; }
}
