
using Core;
using Domain;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;
public class UserRepository : IUserRepository

{
    protected readonly DataContext _DbContext;
    public UserRepository(DataContext dbContext)
    {
        this._DbContext = dbContext;
    }
    public async Task<IEnumerable<User>> getAllUser() => await Task.FromResult(_DbContext.Set<User>());
    public async Task<User?> getByID(int id) => await Task.FromResult(_DbContext.Set<User>().Find(id));
    public async Task<User?> getByUsername(string username) => await Task.FromResult(_DbContext.Set<User>().FirstOrDefault(x => x.username == username));
    public async Task<bool> createUsers(User request)
    {
        try
        {
            await _DbContext.Set<User>().AddAsync(request);
            await _DbContext.SaveChangesAsync();

            return await Task.FromResult(true);
        }
        catch
        {
            return await Task.FromResult(false);
        }
    }

}