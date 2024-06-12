using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitys;
public abstract class _BaseEntity
{
    public int Id { get; set; }
    public string CreateBy { get; set; }
    public DateTime CreateDateUTC { get; set; }
    public string UpdateBy { get; set; }
    public DateTime UpdateDateUTC { get; set; }
    public bool isActive { get; set; }
}