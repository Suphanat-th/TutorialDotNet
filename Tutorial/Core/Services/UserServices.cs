using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace Core;
public class UserServices : IUserServices
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _Mapper;
    public UserServices(IUserRepository userRepository, IMapper mapper)
    {
        this._userRepository = userRepository;
        this._Mapper = mapper;
    }
    public async Task<UserServiceReponse> GetUserAsyncWithUsername(string username)
    {
        var data = await _userRepository.GetByIdAsync(1);
        var result = _Mapper.Map<UserServiceReponse>(data);
        return await Task.FromResult(result);
    }
}