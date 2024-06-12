using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entitys;

namespace Domain.DTOs;
public class Product : _BaseEntity, _IBaseEntity
{
    public string product_name_th { get; set; }
    public string product_name_en { get; set; }
    public double price { get; set; }
    public int quantity { get; set; }

    #region   EF  Relation
    public ICollection<ProductDetail> ProductDetail { get; set; }
    public Category Category { get; set; }
    public int Category_Id { get; set; }
    #endregion  END  - EF Relation
}