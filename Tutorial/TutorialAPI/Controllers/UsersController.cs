using Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TutorialAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IServicesUser userServices;
        private readonly IUserRepository userRepository;
        public UsersController(IServicesUser userServices, IUserRepository userRepository)
        {
            this.userServices = userServices;
            this.userRepository = userRepository;
        }

        [HttpGet]
        [Route("/users")]
        public async Task<IActionResult> getAllUsers()
        {
            var data = await userServices.getAllUser();
            return await Task.FromResult(StatusCode(StatusCodes.Status200OK, data));
        }

        //Add getUserByUsername
        [HttpGet]
        [Route("/users/{username}")]
        public async Task<IActionResult> getUserByUsername(string username)
        {
            var data = await userServices.getUserByUsername(username);
            if (data != null)
            {
                return await Task.FromResult(StatusCode(StatusCodes.Status200OK, data));
            }
            else
            {
                return await Task.FromResult(StatusCode(StatusCodes.Status400BadRequest, "No data"));
            }
        }


        [HttpGet]
        [Route("/{id}/users")]
        public async Task<IActionResult> getUserByID(int id)
        {
            var data = await userRepository.getByID(id);
            if (data != null)
            {
                return await Task.FromResult(StatusCode(StatusCodes.Status200OK, data));
            }
            else
            {
                return await Task.FromResult(StatusCode(StatusCodes.Status400BadRequest, "No userId"));
            }
        }

        [HttpPost]
        [Route("/users")]
        public async Task<IActionResult> createUsers(userResponse request)
        {
            //Check username have in Database or not
            var checkUesername = await userRepository.getByUsername(request.username.ToLower());
            if (checkUesername != null)
                return await Task.FromResult(StatusCode(StatusCodes.Status400BadRequest, "This username already have"));


            //Create username 
            var data = await userRepository.createUsers(request);
            if (data == true)
            {
                return await Task.FromResult(StatusCode(StatusCodes.Status200OK, "Create User Success!!"));
            }
            else
            {
                return await Task.FromResult(StatusCode(StatusCodes.Status400BadRequest, "Create User Failed!!"));

            }
        }

        [HttpPut]
        [Route("/users/id")]
        public async Task<IActionResult> chanagePasswordById(int id)
        {

            return await Task.FromResult(StatusCode(StatusCodes.Status200OK, "What  is  result ?"));
        }

        [HttpPut]
        [Route("/users/{username}")]
        public async Task<IActionResult> chanagePasswordByUsername(string username)
        {
            var data = await userRepository.getByUsername(username.ToLower());
            if (data != null)
            {
                return await Task.FromResult(StatusCode(StatusCodes.Status200OK, data));

            }
            else
            {
                return await Task.FromResult(StatusCode(StatusCodes.Status400BadRequest, "Doesn't have username in system"));
            }
        }

        [HttpDelete]
        [Route("/users/{id}")]
        public async Task<IActionResult> deleteUser(int id)
        {
            return await Task.FromResult(StatusCode(StatusCodes.Status200OK, "What  is  result ?"));
        }

    }
}
