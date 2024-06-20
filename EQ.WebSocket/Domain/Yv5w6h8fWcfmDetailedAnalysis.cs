using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fWcfmDetailedAnalysis
{
    public long Id { get; set; }

    public bool IsShop { get; set; }

    public bool IsStore { get; set; }

    public bool IsProduct { get; set; }

    public long ProductId { get; set; }

    public long AuthorId { get; set; }

    public string Referer { get; set; } = null!;

    public string IpAddress { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string State { get; set; } = null!;

    public string City { get; set; } = null!;

    public DateTime Visited { get; set; }
}
