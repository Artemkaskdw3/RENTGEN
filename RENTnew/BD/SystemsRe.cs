using System;
using System.Collections.Generic;

namespace RENTnew;

public partial class SystemsRe
{
    public int Id { get; set; }

    public string NameSystem { get; set; } = null!;

    public string? Title { get; set; }

    public virtual ICollection<ReserchsName> ReserchsNames { get; set; } = new List<ReserchsName>();
}
