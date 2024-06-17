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
            return await Task.FromResult(StatusCode(StatusCodes.Status200OK, "What  is  result ?"));
        }

        [HttpPost]
        [Route("/users")]
        public async Task<IActionResult> createUsers(userResponse request)
        {
            return await Task.FromResult(StatusCode(StatusCodes.Status200OK, "What  is  result ?"));
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
