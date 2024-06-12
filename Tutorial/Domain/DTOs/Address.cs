using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entitys;

namespace Domain.DTOs;
public class Address: _BaseEntity, _IBaseEntity
{
    public decimal lat { get; set; }
    public decimal lng { get; set; }
    public string city { get; set; }
    public string address { get; set; }
    public int postal_code { get; set; }
}