using Domain.Entity;

namespace Domain;
public class User : _BaseEntity, _IBaseEntity
{
    public string username { get; set; } = string.Empty;
    public string password { get; set; } = string.Empty;
}
