using System;
using System.Collections.Generic;

namespace EmpolyeeManagement.Models;

public partial class Phone
{
    public int PhoneId { get; set; }

    public int? EmployeeId { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public string PhoneType { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public virtual Employee? Employee { get; set; }
}
