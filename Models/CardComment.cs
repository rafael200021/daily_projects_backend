using System;
using System.Collections.Generic;

namespace Daily_Project.Models;

public partial class CardComment
{
    public int Id { get; set; }

    public int? CardId { get; set; }

    public int? UserId { get; set; }

    public string Comment { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Card? Card { get; set; }

    public virtual User? User { get; set; }
}
