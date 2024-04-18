using System;
using System.Collections.Generic;

namespace RENTnew.BD;

public partial class Reserch
{
    public int Id { get; set; }

    public DateTime DateReserch { get; set; }

    public int NameRerserchId { get; set; }

    public int NumOfPicture { get; set; }

    public bool? PlanOrEmerg { get; set; }

    public bool? InpatientOutpatient { get; set; }

    public int? DepartamentId { get; set; }

    public int? Hcfid { get; set; }

    public int DoctorId { get; set; }

    public int PatientId { get; set; }

    public int ResultId { get; set; }

    public decimal Dose { get; set; }

    public int? Assisstant { get; set; }

    public virtual Assisstant? AssisstantNavigation { get; set; }

    public virtual Departament? Departament { get; set; }

    public virtual Doctor Doctor { get; set; } = null!;

    public virtual HeathCf? Hcf { get; set; }

    public virtual ReserchsName NameRerserch { get; set; } = null!;

    public virtual Patient Patient { get; set; } = null!;

    public virtual Pathology Result { get; set; } = null!;
}
