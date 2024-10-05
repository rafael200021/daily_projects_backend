using System;
using System.Collections.Generic;

namespace Daily_Project.Models;

public partial class User
{
    public int? Id { get; set; }

    public string? Name { get; set; } = null!;

    public string? Email { get; set; } = null!;

    public string? Password { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    //public virtual ICollection<BoardMember> BoardMembers { get; set; } = new List<BoardMember>();

    //public virtual ICollection<Board> Boards { get; set; } = new List<Board>();

    //public virtual ICollection<CardAssignee> CardAssignees { get; set; } = new List<CardAssignee>();

    //public virtual ICollection<CardComment> CardComments { get; set; } = new List<CardComment>();

    //public virtual ICollection<WorkspaceMember> WorkspaceMembers { get; set; } = new List<WorkspaceMember>();

    //public virtual ICollection<Workspace> Workspaces { get; set; } = new List<Workspace>();
}
