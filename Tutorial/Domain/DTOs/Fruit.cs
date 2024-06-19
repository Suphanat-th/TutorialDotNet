using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entity;

namespace Domain;
public class Fruit : _BaseEntity, _IBaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Name_th { get; set; } = string.Empty;
    public string Name_en { get; set; } = string.Empty;
    public byte[] Content { get; set; } = new byte[0];
    public string ContentType { get; set; } = string.Empty;
}