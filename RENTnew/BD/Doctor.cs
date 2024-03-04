using System;
using System.Collections.Generic;

namespace RENTnew;

public partial class Doctor
{
    public int Id { get; set; }

    public string Surname { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public virtual ICollection<Reserch> Reserches { get; set; } = new List<Reserch>();
}
