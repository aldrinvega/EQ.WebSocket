using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fWcfmFollowingFollower
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string UserEmail { get; set; } = null!;

    public long FollowerId { get; set; }

    public string FollowerName { get; set; } = null!;

    public string FollowerEmail { get; set; } = null!;

    public bool? Notify { get; set; }

    public DateTime Posted { get; set; }
}
