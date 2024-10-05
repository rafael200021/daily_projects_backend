using System;
using System.Collections.Generic;

namespace Daily_Project.Models;

public partial class BoardType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<List> Lists { get; set; } = new List<List>();
}
