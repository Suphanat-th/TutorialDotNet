using Tutorial.Database;
using Tutorial.Database.DTOs;

namespace Tutorial;
public class UserRepository : IUserRepository
{
    protected readonly DataContext _DbContext;
    public UserRepository(DataContext dbContext)
    {
        this._DbContext = dbContext;
    }
    public async Task<IEnumerable<Users>> getAllUser() => await Task.FromResult(_DbContext.Set<Users>());
    public async Task<Users?> getByID(int id) => await Task.FromResult(_DbContext.Set<Users>().Find(id));
    public async Task<Users?> getByUsername(string username) => await Task.FromResult(_DbContext.Set<Users>().FirstOrDefault(x => x.username == username));
    public async Task<bool> createUsers(Users request)
    {
        try
        {
            await _DbContext.Set<Users>().AddAsync(request);
            await _DbContext.SaveChangesAsync();

            return await Task.FromResult(true);
        }
        catch
        {
            return await Task.FromResult(false);
        }
    }
}