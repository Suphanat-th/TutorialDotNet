using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity;
public abstract class _BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedDateUTC { get; set; }
    public string CreatedBy { get; set; } = string.Empty;
    public DateTime UpdatedDateUTC { get; set; }
    public string UpdatedBy { get; set; } = string.Empty;
    public bool IsActive { get; set; }
}