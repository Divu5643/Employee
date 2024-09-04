using System;
using System.Collections.Generic;

namespace EmpolyeeManagement.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public int? CountryId { get; set; }

    public int? StateId { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual Country? Country { get; set; }

    public virtual ICollection<Phone> Phones { get; set; } = new List<Phone>();

    public virtual State? State { get; set; }
}
