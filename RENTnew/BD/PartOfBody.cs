using System;
using System.Collections.Generic;

namespace RENTnew.BD;

public partial class PartOfBody
{
    public int Id { get; set; }

    public string? PartOfBodyName { get; set; }

    public virtual ICollection<Pathology> Pathologies { get; set; } = new List<Pathology>();
}
