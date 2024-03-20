using System;
using System.Collections.Generic;

namespace RENTnew.BD;

public partial class ReserchsName
{
    public int Id { get; set; }

    public string NameRerserch { get; set; } = null!;

    public int GroupId { get; set; }

    public int SystemId { get; set; }

    public string? Title { get; set; }

    public virtual GroupingReserch Group { get; set; } = null!;

    public virtual ICollection<Reserch> Reserches { get; set; } = new List<Reserch>();

    public virtual SystemsRe System { get; set; } = null!;
}
