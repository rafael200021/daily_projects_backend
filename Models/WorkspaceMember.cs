using System;
using System.Collections.Generic;

namespace Daily_Project.Models;

public partial class WorkspaceMember
{
    public int? Id { get; set; }

    public int? UserId { get; set; }

    public int? WorkspaceId { get; set; }

    public string? Role { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual User? User { get; set; }

    public virtual Workspace? Workspace { get; set; }
}
