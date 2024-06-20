
using Core;
using Domain;
using Infrastructure.Database;

namespace Infrastructure;
public class UserRepository : _BaseRepository<User>, IUserRepository
{
    public UserRepository(DataContext dbContext) : base(dbContext)
    {
    }
    public async Task<User?> GetByUsernameAsync(string username) => await Task.FromResult(base._context.Set<User>().FirstOrDefault(x => x.username == username));

}