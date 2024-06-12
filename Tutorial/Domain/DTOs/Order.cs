using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entitys;

namespace Domain.DTOs;
public class Order : _BaseEntity, _IBaseEntity
{
    public int price { get; set; }

    #region   EF  Relation
    public virtual ICollection<OrderItem> OrderItems { get; set; }
    public User User { get; set; }
    public int User_Id { get; set; }
    #endregion  END  - EF Relation
}
