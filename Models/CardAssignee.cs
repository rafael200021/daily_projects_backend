using System;
using System.Collections.Generic;

namespace Daily_Project.Models;

public partial class CardAssignee
{
    public int Id { get; set; }

    public int? CardId { get; set; }

    public int? UserId { get; set; }

    public DateTime? AssignedAt { get; set; }

    public virtual Card? Card { get; set; }

    public virtual User? User { get; set; }
}
