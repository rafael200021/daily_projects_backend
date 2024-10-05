using System;
using System.Collections.Generic;

namespace Daily_Project.Models;

public partial class Card
{
    public int? Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? ListId { get; set; }

    public int? Position { get; set; }

    public sbyte? HasFinalDate { get; set; }

    public DateTime? FinalDate { get; set; }

    public sbyte? WasCompleted { get; set; }

    public DateTime? DateCompleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<CardAssignee> CardAssignees { get; set; } = new List<CardAssignee>();

    public virtual ICollection<CardAttachment> CardAttachments { get; set; } = new List<CardAttachment>();

    public virtual ICollection<CardComment> CardComments { get; set; } = new List<CardComment>();

    public virtual ICollection<CardLabel> CardLabels { get; set; } = new List<CardLabel>();

    public virtual List? List { get; set; }
}
