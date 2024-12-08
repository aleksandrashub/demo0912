using System;
using System.Collections.Generic;

namespace demo0312.Models;

public partial class Department
{
    public int IdDep { get; set; }

    public string? Dep { get; set; }

    public virtual ICollection<Employee1> Employee1s { get; set; } = new List<Employee1>();
}
