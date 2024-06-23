using Domain;

namespace Core;
public interface IServicesUser
{
    Task<List<userResponse>?> getAllUser();
    Task<userResponse?> getUserByID(int id);
    Task<userResponse?> getUserByUsername(string username);
    Task<userResponse?> createUser(string username, string password);
    Task updatePasswordByID(int id, string password);
    Task updatePasswordByUsername(string Username, string password);
    Task DeleteByID(int id);
}
