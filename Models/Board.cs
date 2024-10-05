using System;
using System.Collections.Generic;

namespace Daily_Project.Models;

public partial class Board
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? WorkspaceId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<BoardMember> BoardMembers { get; set; } = new List<BoardMember>();

    //public virtual User? CreatedByNavigation { get; set; }

    public virtual ICollection<Label> Labels { get; set; } = new List<Label>();

    public virtual ICollection<List> Lists { get; set; } = new List<List>();

    public virtual Workspace? Workspace { get; set; }
}
