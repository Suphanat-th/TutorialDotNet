using Domain;

namespace Core;
public interface IUserRepository
{
    Task<IEnumerable<User>> getAllUser();
    Task<User?> getByID(int id);
    Task<User?> getByUsername(string username);
    Task<bool> createUsers(User request);
}
