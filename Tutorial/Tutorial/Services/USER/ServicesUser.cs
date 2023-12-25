using Microsoft.AspNetCore.Mvc.Formatters;
using Tutorial.Models.Login;
using Tutorial.Models.Register;

namespace Tutorial.Services.USER
{
    /*public interface IServicesUser
    {
        Task<List<loginDtos>> getAllUser();
        Task<loginDtos?> getUserByUsername(string username);
        Task<RegisterDto?> setUserwithRegister(string username, string password, string fullname);
    }*/
    public class ServicesUser : IServicesUser
    {
        private List<loginDtos> _user = new List<loginDtos>()
            {
                    new loginDtos() { username = "test", password = "Test", fullname = "Mr.Test" },
                    new loginDtos() { username = "a", password = "abc", fullname = "Mr.A" }
            };

        private readonly List<RegisterDto> _regis;

        public ServicesUser()
        {
            _regis = new List<RegisterDto>();
            //_user = initialUser();
        }

        //private static List<loginDtos> initialUser()
        //{
        //    var data
        //    return data;
        //}

        public async Task<List<loginDtos>> getAllUser()
        {
            return await Task.FromResult(_user);
        }

        public async Task<loginDtos?> getUserByUsername(string username)
        {
            var data = _user.FirstOrDefault(x => x.username.ToLower() == username.ToLower());
            return await Task.FromResult(data);
        }

        public async Task<RegisterDto?> setUserwithRegister(string username, string password, string fullname)
        {
            var data = new RegisterDto
            {
                username = username,
                password = password,
                fullname = fullname
            };

            _regis.Add(data);

            var loginData = new loginDtos
            {
                username = username,
                password = password,
                fullname = fullname,
            };

            _user.Add(loginData);

            return await Task.FromResult<RegisterDto?>(data);
        }
    }
}
