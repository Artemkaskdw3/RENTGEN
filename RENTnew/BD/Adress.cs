using System;
using System.Collections.Generic;

namespace RENTnew.BD;

public partial class Adress
{
    public int Id { get; set; }

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public string? Building { get; set; }

    public string? Letter { get; set; }

    public string? Appartaments { get; set; }

    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
}
