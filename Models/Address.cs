using System;
using System.Collections.Generic;

namespace EmpolyeeManagement.Models;

public partial class Address
{
    public int AddressId { get; set; }

    public int? EmployeeId { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public int? StateId { get; set; }

    public int? CountryId { get; set; }

    public string? PostalCode { get; set; }

    public bool IsDeleted { get; set; }

    public virtual Country? Country { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual State? State { get; set; }
}
