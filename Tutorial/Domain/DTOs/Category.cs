using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entitys;

namespace Domain.DTOs;
public class Category : _BaseEntity, _IBaseEntity
{
    public string cat_name_th { get; set; }
    public string cat_name_en { get; set; }
}