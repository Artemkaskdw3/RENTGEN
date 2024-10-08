﻿using System;
using System.Collections.Generic;

namespace RENTnew.BD;

public partial class Doctor
{
    public int Id { get; set; }

    public string Surname { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string? Title { get; set; }

    public virtual ICollection<Reserch> Reserches { get; set; } = new List<Reserch>();
}
