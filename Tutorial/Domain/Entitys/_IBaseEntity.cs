using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitys;
public interface _IBaseEntity
{
    int Id { get; set; }
    string CreateBy { get; set; }
    DateTime CreateDateUTC { get; set; }
    string UpdateBy { get; set; }
    DateTime UpdateDateUTC { get; set; }
    bool isActive { get; set; }
}