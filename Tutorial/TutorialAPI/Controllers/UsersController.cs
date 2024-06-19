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
        public UsersController(IServicesUser userServices)
        {
            this.userServices = userServices;
        }
        [HttpGet]
        [Route("/users")]
        public async Task<IActionResult> getAllUsers()
        {
            var data = await userServices.getAllUser();
            return await Task.FromResult(StatusCode(StatusCodes.Status200OK, data));
        }

        [HttpGet]
        [Route("/{id}/users")]
        public async Task<IActionResult> getUserByID(int id)
        {
            var data = await userServices.getUserByID(id);
            if (data == null)
            {
                return await Task.FromResult(StatusCode(StatusCodes.Status500InternalServerError));
            }
            return await Task.FromResult(StatusCode(StatusCodes.Status200OK, data));
        }

        [HttpPost]
        [Route("/users")]
        public async Task<IActionResult> createUsers(userResponse request)
        {
            if (string.IsNullOrEmpty(request.username) || string.IsNullOrEmpty(request.password))
            {
                return await Task.FromResult(StatusCode(StatusCodes.Status500InternalServerError));
            }
            var register_user = await userServices.setUserwithRegister(request.username, request.password);
            return await Task.FromResult(StatusCode(StatusCodes.Status200OK,register_user));
        }

        [HttpPut]
        [Route("/users/id")]
        public async Task<IActionResult> chanagePasswordById(int id)
        {
            return await Task.FromResult(StatusCode(StatusCodes.Status200OK, "What  is  result ?"));
        }

        [HttpPut]
        [Route("/users/username")]
        public async Task<IActionResult> chanagePasswordByUsername(string username)
        {
            return await Task.FromResult(StatusCode(StatusCodes.Status200OK, "What  is  result ?"));
        }

        [HttpDelete]
        [Route("/users/{id}")]
        public async Task<IActionResult> deleteUser(int id)
        {
            return await Task.FromResult(StatusCode(StatusCodes.Status200OK, "What  is  result ?"));
        }

    }
}
