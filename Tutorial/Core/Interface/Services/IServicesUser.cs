using Domain;

namespace Core;
public interface IServicesUser
{
    Task<List<userResponse>?> getAllUser();
    Task<userResponse?> getUserByUsername(string username);
    Task<userResponse?> setUserwithRegister(string username, string password);
    Task<userResponse?> getUserByID(int id);
    Task<userResponse?> chanagePasswordById(int id,string password);
    Task<userResponse?> chanagePasswordByUsername(string username, string password);
    Task<userResponse?> deleteUser(int id);
}
