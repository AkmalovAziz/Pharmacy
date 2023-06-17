using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Entities.Country;

public sealed class Countrys : Auditable
{
    [MaxLength(50)]
    public string CountryName { get; set; } = string.Empty;

    [MaxLength(50)]
    public string FirmaName { get; set; } = string.Empty;
    public DateOnly Created_year { get; set; }
    public string Discriptions { get; set; } = string.Empty;
}
