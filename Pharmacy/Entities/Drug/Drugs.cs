using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Entities.Drug;

public sealed class Drugs : Auditable
{
    public long CountryId { get; set; }

    [MaxLength(50)]
    public string Types { get; set; } = string.Empty;
    public DateTime DateOfManufacture { get; set; } 
    public DateTime EndDate { get; set; }
    public float Price { get; set; }
    public short Count { get; set; }

    [MaxLength(50)]
    public string DrugsLocations { get; set; } = string.Empty;
    public string Discriptions { get; set; } = string.Empty;
}
