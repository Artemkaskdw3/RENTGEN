using System;
using System.Collections.Generic;

namespace RENTnew;

public partial class Patient
{
    public int Id { get; set; }

    public string Surname { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public DateTime Age { get; set; }

    public bool Sex { get; set; }

    public string? Title { get; set; }

    public string? City { get; set; }

    public string? Street { get; set; }

    public string? Building { get; set; }

    public string? Letter { get; set; }

    public string? Appartaments { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual ICollection<Reserch> Reserches { get; set; } = new List<Reserch>();
}
