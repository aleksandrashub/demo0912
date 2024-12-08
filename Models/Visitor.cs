using System;
using System.Collections.Generic;

namespace demo0312.Models;

public partial class Visitor
{
    public int IdVisitor { get; set; }

    public string Usersurname { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Userpatronymic { get; set; } = null!;

    public string Dateofbirth { get; set; } = null!;

    public string? Phone { get; set; }

    public string? SeriyaPassp { get; set; }

    public string? NomPassp { get; set; }

    public string? Organization { get; set; }

    public string? Primechanie { get; set; }

    public string? FileOtherVisitors { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
