using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.DTOs;

namespace Core;
public interface IUserRepository : _IBaseRepository<User>
{
    public Task<User> GetUserAsyncWithUsername(string username);
}