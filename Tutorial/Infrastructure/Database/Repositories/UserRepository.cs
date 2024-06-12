using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Domain.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;
public class UserRepository : _BaseRepository<User>, IUserRepository
{
    public UserRepository(BaseContext context) : base(context)
    {

    }
    public async Task<User> GetUserAsyncWithUsername(string username)
    {
        return await base._context.Users
                    .FirstOrDefaultAsync(x => x.username == username);
    }
}