using System;
using System.Collections.Generic;

namespace demo0312.Models;

public partial class Purpose
{
    public int IdPurpose { get; set; }

    public string? Purpose1 { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
