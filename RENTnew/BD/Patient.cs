using System;
using System.Collections.Generic;

namespace RENTnew.BD;

public partial class Patient
{
    public int Id { get; set; }

    public string Surname { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public DateTime Age { get; set; }

    public bool Sex { get; set; }

    public int AdressId { get; set; }

    public string? Title { get; set; }

    public virtual Adress Adress { get; set; } = null!;

    public virtual ICollection<Reserch> Reserches { get; set; } = new List<Reserch>();
}
