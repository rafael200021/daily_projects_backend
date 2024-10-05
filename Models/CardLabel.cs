using System;
using System.Collections.Generic;

namespace Daily_Project.Models;

public partial class CardLabel
{
    public int Id { get; set; }

    public int? CardId { get; set; }

    public int? LabelId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Card? Card { get; set; }

    public virtual Label? Label { get; set; }
}
