using Core.Interface;
using Domain;

namespace Core;
public interface IUserRepository : _IBaseRepository<User>
{
    Task<User?> GetByUsernameAsync(string  username);
}
