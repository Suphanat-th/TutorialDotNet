using Tutorial.Models.Login;

namespace Tutorial.Services.USER
{
    public class ServicesUser : IServicesUser
    {
        private readonly List<loginDtos> _user;
        public ServicesUser()
        {
            _user = initialUser();
        }
        private static List<loginDtos> initialUser()
        {
            var data = new List<loginDtos>()
            {new loginDtos() { username = "test", password = "Test", fullname = "Mr.Test" },
            new loginDtos() { username = "a", password = "abc", fullname = "Mr.A" }
            };
            return data;
        }
        public Task<List<loginDtos>> getAllUser()
        {
            return Task.FromResult(_user);
        }
        public Task<loginDtos?> getUserByUsername(string username)
        {
            var data = _user.FirstOrDefault(x => x.username.ToLower() == username.ToLower());
            return Task.FromResult(data);
        }
    }
}
