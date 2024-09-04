using System;
using System.Collections.Generic;

namespace EmpolyeeManagement.Models;

public partial class State
{
    public int StateId { get; set; }

    public string StateName { get; set; } = null!;

    public int? CountryId { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual Country? Country { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
