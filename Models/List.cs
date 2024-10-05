using System;
using System.Collections.Generic;

namespace Daily_Project.Models;

public partial class List
{
    public int? Id { get; set; }
    
    public int? BoardTypeId { get; set; }

    public int? BoardId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Board? Board { get; set; }

    public virtual BoardType? BoardType { get; set; } = null!;

    public virtual ICollection<Card> Cards { get; set; } = new List<Card>();
}
