using System;
using System.Collections.Generic;

namespace Daily_Project.Models;

public partial class BoardMember
{
    public int? Id { get; set; }

    public int? BoardId { get; set; }

    public int? UserId { get; set; }

    public string Role { get; set; } = null!;

    public DateTime? AddedAt { get; set; }

    public virtual Board? Board { get; set; }

    public virtual User? User { get; set; }
}
