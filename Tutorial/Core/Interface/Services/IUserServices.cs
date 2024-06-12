using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.DTOs;
using Domain.Entitys;

namespace Core;
public interface IUserServices
{
    Task<UserServiceReponse> GetUserAsyncWithUsername(string username);
}
public class userServiceMapper : Profile
{
    public userServiceMapper()
    {
        CreateMap<User, UserServiceReponse>();
    }
}
public class UserServiceReponse : User
{

}