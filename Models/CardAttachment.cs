using System;
using System.Collections.Generic;

namespace Daily_Project.Models;

public partial class CardAttachment
{
    public int Id { get; set; }

    public int? CardId { get; set; }

    public string FilePath { get; set; } = null!;

    public string FileName { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Card? Card { get; set; }
}
