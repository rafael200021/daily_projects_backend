using System;
using System.Collections.Generic;

namespace Daily_Project.Models;

public partial class Label
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Color { get; set; } = null!;

    public int? BoardId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Board? Board { get; set; }

    public virtual ICollection<CardLabel> CardLabels { get; set; } = new List<CardLabel>();
}
