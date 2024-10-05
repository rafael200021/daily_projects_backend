using System;
using System.Collections.Generic;

namespace Daily_Project.Models;

public partial class Workspace
{
    public int? Id { get; set; }

    public string? Name { get; set; } = null!;

    public string? Description { get; set; } = null!;

    public int? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Board> Boards { get; set; } = new List<Board>();

    //public virtual User? CreatedByNavigation { get; set; }

    public virtual ICollection<WorkspaceMember> WorkspaceMembers { get; set; } = new List<WorkspaceMember>();
}
