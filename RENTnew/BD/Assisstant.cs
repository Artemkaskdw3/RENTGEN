using System;
using System.Collections.Generic;

namespace RENTnew;

public partial class Assisstant
{
    public int Id { get; set; }

    public string Surname { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string LoginA { get; set; } = null!;

    public string PasswordA { get; set; } = null!;

    public bool RoleA { get; set; }
}
