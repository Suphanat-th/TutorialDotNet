using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entitys;

namespace Domain.DTOs;
public class ProductDetail : _BaseEntity, _IBaseEntity
{
    public string product_detail_name_th { get; set; }
    public string product_detail_name_en { get; set; }
    public string product_detail_name_image { get; set; }
}