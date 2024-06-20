using AutoMapper;
using Domain;

namespace Core;
public class UserDTO : Profile
{
    public UserDTO()
    {
        CreateMap<userResponse, User>();
        CreateMap<User, userResponse>();
    }
}
public class userResponse : User
{

}
