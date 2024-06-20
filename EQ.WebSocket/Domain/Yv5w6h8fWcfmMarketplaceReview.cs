using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fWcfmMarketplaceReview
{
    public long Id { get; set; }

    public long VendorId { get; set; }

    public long AuthorId { get; set; }

    public string AuthorName { get; set; } = null!;

    public string AuthorEmail { get; set; } = null!;

    public string ReviewTitle { get; set; } = null!;

    public string ReviewDescription { get; set; } = null!;

    public string ReviewRating { get; set; } = null!;

    public bool Approved { get; set; }

    public DateTime Created { get; set; }
}
