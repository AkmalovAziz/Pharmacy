using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Entities.Email;

public sealed class Emails
{
    public long Id { get; set; }

    public long EmployeeId { get; set; }

    [MaxLength(50)]
    public string Email { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;
    public string Salt { get; set; } = string.Empty;
}

