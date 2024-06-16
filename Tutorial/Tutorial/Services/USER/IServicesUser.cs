﻿using Tutorial.Models;
using Tutorial.Models.Login;
using Tutorial.Models.Register;

namespace Tutorial.Services;
public interface IServicesUser
{
    Task<List<userResponse>?> getAllUser();
    Task<userResponse?> getUserByUsername(string username);
    Task<userResponse?> setUserwithRegister(string username, string password);
}
