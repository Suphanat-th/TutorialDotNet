using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entitys;

namespace Domain.DTOs;
public class User : _BaseEntity, _IBaseEntity
{
    public string username {get;set;}
    public string password {get;set;}
}