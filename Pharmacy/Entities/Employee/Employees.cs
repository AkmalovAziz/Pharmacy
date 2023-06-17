using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Entities.Employee;

public sealed class Employees : Auditable
{
    [MaxLength(50)]
    public string FirstName { get; set; } = string.Empty;

    [MaxLength(50)]
    public string LastName { get; set; } = string.Empty;

    public short Experience { get; set; }

    [MaxLength(9)]
    public string PassportSeriaNumbers { get; set; } = string.Empty;

    public bool IsMale { get; set; }

    public string Discriptions { get; set; } = string.Empty;

}
