﻿namespace Core;
public interface IServicesUser
{
    Task<List<userResponse>?> getAllUser();
    Task<userResponse?> getUserByUsername(string username);
    Task<userResponse?> setUserwithRegister(string username, string password);
}
