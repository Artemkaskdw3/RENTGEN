using RENTnew.BD;
using System;
using System.Collections.Generic;

namespace RENTnew;

public partial class Departament
{
    public int Id { get; set; }

    public string NameDep { get; set; } = null!;

    public string? Title { get; set; }

    public virtual ICollection<Reserch> Reserches { get; set; } = new List<Reserch>();
}
