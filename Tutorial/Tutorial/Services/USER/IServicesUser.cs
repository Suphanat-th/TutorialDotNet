using Tutorial.Models.Login;

namespace Tutorial.Services.USER
{
    public interface IServicesUser
    {
        Task<List<loginDtos>> getAllUser();
        Task<loginDtos?> getUserByUsername(string username);
    }
}
