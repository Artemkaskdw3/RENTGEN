using System;
using System.Collections.Generic;

namespace RENTnew;

public partial class GroupingReserch
{
    public int Id { get; set; }

    public string NameGroup { get; set; } = null!;

    public string? Title { get; set; }

    public virtual ICollection<ReserchsName> ReserchsNames { get; set; } = new List<ReserchsName>();
}
