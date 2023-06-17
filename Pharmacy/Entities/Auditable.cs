using Pharmacy.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Entities;

public abstract class Auditable : BaseEntity
{
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public Auditable()
    {
        CreatedAt = TimeHelper.GetDateTime();
        UpdatedAt = TimeHelper.GetDateTime();
    }
}
