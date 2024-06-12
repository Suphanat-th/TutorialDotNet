using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entitys;

namespace Domain.DTOs;
public class OrderItem : _BaseEntity, _IBaseEntity
{
    public double price { get; set; }
    public int quantity { get; set; }


    #region   EF  Relation
    public virtual ICollection<Product> Product { get; set; }
    public Order Order { get; set; }
    public int Order_Id { get; set; }
    #endregion  END  - EF Relation
}