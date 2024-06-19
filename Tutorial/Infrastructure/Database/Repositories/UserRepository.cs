
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
    public async Task<bool> chanagePasswordById(User request)
    {
        try
        {
            var user = _DbContext.Set<User>().Find(request.id);
            if (user == null)
            {
                return await Task.FromResult(false);
            }
            user.password = request.password;
            await _DbContext.SaveChangesAsync();
            return await Task.FromResult(true);
        }
        catch (Exception)
        {
            return await Task.FromResult(false);
        }
    }
    public async Task<bool> chanagePasswordByUsername(User request)
    {
        try
        {
            var user = _DbContext.Set<User>().Find(request.username);
            if (user == null)
            {
                return await Task.FromResult(false);
            }
            user.password = request.password;
            await _DbContext.SaveChangesAsync();
            return await Task.FromResult(true);
        }
        catch (Exception)
        {
            return await Task.FromResult(false);
        }
    }
    public async Task<bool> deleteUser(int id)
    {
        try
        {
            var user = await _DbContext.Users.FindAsync(id);
            if (user == null)
            {
                return false; // User not found
            }

            _DbContext.Users.Remove(user);
            await _DbContext.SaveChangesAsync();

            return true;
        }
        catch (Exception)
        {
            // Log the exception (not shown here for brevity)
            return false;
        }
    }

}