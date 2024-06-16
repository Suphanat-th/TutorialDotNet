using Tutorial.Database.DTOs;

namespace Tutorial;
public interface IUserRepository
{
    Task<IEnumerable<Users>> getAllUser();
    Task<Users?> getByID(int id);
    Task<Users?> getByUsername(string username);
    Task<bool> createUsers(Users request);
}
