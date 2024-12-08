using System;
using System.Collections.Generic;

namespace demo0312.Models;

public partial class Employee1
{
    public int Userid { get; set; }

    public string? Usersurname { get; set; }

    public string? Username { get; set; }

    public string? Userpatronymic { get; set; }

    public string? Otdel { get; set; }

    public int? IdDep { get; set; }

    public long? Employeecode { get; set; }

    public virtual Department? IdDepNavigation { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
