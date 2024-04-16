using System;
using System.Collections.Generic;

namespace RENTnew;

public partial class HeathCf
{
    public int Id { get; set; }

    public string NameHcf { get; set; } = null!;

    public string? Title { get; set; }

    public virtual ICollection<Reserch> Reserches { get; set; } = new List<Reserch>();
}
