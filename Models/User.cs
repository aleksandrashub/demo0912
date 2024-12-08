using System;
using System.Collections.Generic;

namespace demo0312.Models;

public partial class User
{
    public int IdUser { get; set; }

    public string? Mail { get; set; }

    public string? Login { get; set; }

    public string? Passwd { get; set; }

    public int? IdRole { get; set; }

    public virtual Role? IdRoleNavigation { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
