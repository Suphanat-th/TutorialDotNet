﻿using AutoMapper;
using Domain;

namespace Core;
public class ServicesUser : IServicesUser
{
    private readonly IUserRepository userRepository;
    private readonly IMapper mapper;

    public ServicesUser(IUserRepository userRepository, IMapper mapper)
    {
        this.userRepository = userRepository;
        this.mapper = mapper;
    }

    public async Task<List<userResponse>?> getAllUser()
    {
        var data = await userRepository.getAllUser();
        return await Task.FromResult(mapper.Map<List<userResponse>>(data));
    }

    public async Task<userResponse?> getUserByUsername(string username)
    {
        var data = await userRepository.getByUsername(username);
        return await Task.FromResult(mapper.Map<userResponse>(data));
    }

    public async Task<userResponse?> setUserwithRegister(string username, string password)
    {
        var data = new userResponse
        {
            username = username.ToLower(),
            password = password
        };
        var checkUser = await userRepository.getByUsername(username.ToLower());
        if (checkUser != null)
            return null;

        var result = await userRepository.createUsers(mapper.Map<User>(data));
        if (!result)
            return null;
        return await Task.FromResult<userResponse?>(data);
    }
}