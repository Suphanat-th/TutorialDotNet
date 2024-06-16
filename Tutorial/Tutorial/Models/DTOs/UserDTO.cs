using AutoMapper;
using Tutorial.Database.DTOs;

namespace Tutorial.Models;
public class UserDTO : Profile
{
    public UserDTO()
    {
        CreateMap<userResponse, Users>();
        CreateMap<Users, userResponse>();
    }
}
public class userResponse : Users
{

}
