using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fWcCustomerLookup
{
    public long CustomerId { get; set; }

    public long? UserId { get; set; }

    public string Username { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Email { get; set; }

    public DateTime? DateLastActive { get; set; }

    public DateTime? DateRegistered { get; set; }

    public string Country { get; set; } = null!;

    public string Postcode { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;
}
