using System;
using System.Collections.Generic;

namespace demo0312.Models;

public partial class Order
{
    public int IdOrder { get; set; }

    public int IdUser { get; set; }

    public DateOnly? DateNach { get; set; }

    public DateOnly? DateEnd { get; set; }

    public int? IdPurpose { get; set; }

    public int? IdStatus { get; set; }

    public int? IdEmployee { get; set; }

    public int? IdVisitor { get; set; }

    public virtual Employee1? IdEmployeeNavigation { get; set; }

    public virtual Purpose? IdPurposeNavigation { get; set; }

    public virtual Status? IdStatusNavigation { get; set; }

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual Visitor? IdVisitorNavigation { get; set; }
}
