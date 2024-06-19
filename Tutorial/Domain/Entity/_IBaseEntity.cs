using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity;
public interface _IBaseEntity
{
    int Id { get; set; }
    DateTime CreatedDateUTC { get; set; }
    string CreatedBy { get; set; }
    DateTime UpdatedDateUTC { get; set; }
    string UpdatedBy { get; set; }
    bool IsActive { get; set; }
}