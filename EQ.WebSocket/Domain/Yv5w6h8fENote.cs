using System;
using System.Collections.Generic;

namespace EQ.WebSocket.Domain;

public partial class Yv5w6h8fENote
{
    public long Id { get; set; }

    /// <summary>
    /// Clean url where the note was created.
    /// </summary>
    public string? RouteUrl { get; set; }

    public string? RouteTitle { get; set; }

    /// <summary>
    /// The post id of the route that the note was created on.
    /// </summary>
    public long? RoutePostId { get; set; }

    public long? PostId { get; set; }

    /// <summary>
    /// The Elementor element ID the note is attached to.
    /// </summary>
    public string? ElementId { get; set; }

    public long ParentId { get; set; }

    public long? AuthorId { get; set; }

    /// <summary>
    /// Save the author name when the author was deleted.
    /// </summary>
    public string? AuthorDisplayName { get; set; }

    public string Status { get; set; } = null!;

    /// <summary>
    /// A JSON string that represents the position of the note inside the element in percentages. e.g. {x:10, y:15}
    /// </summary>
    public string? Position { get; set; }

    public string? Content { get; set; }

    public bool IsResolved { get; set; }

    public bool? IsPublic { get; set; }

    public DateTime? LastActivityAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
