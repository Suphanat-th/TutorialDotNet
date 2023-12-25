using Tutorial.Models.Login;
using Tutorial.Models.Register;

namespace Tutorial.Services.USER
{
    public interface IServicesUser
    {
        Task<List<loginDtos>> getAllUser();
        Task<loginDtos?> getUserByUsername(string username);
        Task<RegisterDto?> setUserwithRegister(string username, string password,string fullname);
    }
}
