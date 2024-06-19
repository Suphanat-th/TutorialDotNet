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
        [Route("/user/{id}")]
        public async Task<IActionResult> getUserByID(int id)
        {
            var data = await userServices.getUserByID(id);
            if (data == null)
                return await Task.FromResult(StatusCode(StatusCodes.Status500InternalServerError, $"ไม่พบข้อมูลผู้ใช้งาน ID : {id} "));
            return await Task.FromResult(StatusCode(StatusCodes.Status200OK, data));
        }
        [HttpGet]
        [Route("/user/username/{username}")]
        public async Task<IActionResult> getUserByUsername(string username)
        {
            var data = await userServices.getUserByUsername(username);
            if (data == null)
                return await Task.FromResult(StatusCode(StatusCodes.Status500InternalServerError, $"ไม่พบข้อมูลผู้ใช้งาน USERNAME : {username} "));
            return await Task.FromResult(StatusCode(StatusCodes.Status200OK, data));
        }

        [HttpPost]
        [Route("/users")]
        public async Task<IActionResult> createUsers(userResponse request)
        {
            try
            {
                var result = await userServices.createUser(request.username, request.password);
                return await Task.FromResult(StatusCode(StatusCodes.Status200OK, result));
            }
            catch (Exception err)
            {
                return await Task.FromResult(StatusCode(StatusCodes.Status500InternalServerError, err.Message));
            }

        }

        [HttpPut]
        [Route("/users/{id}")]
        public async Task<IActionResult> chanagePasswordById(int id, string password)
        {
            try
            {
                await userServices.updatePasswordByID(id, password);
                return await Task.FromResult(StatusCode(StatusCodes.Status200OK, "เปลี่ยนรหัสผ่านเรียบร้อย"));
            }
            catch (Exception err)
            {
                return await Task.FromResult(StatusCode(StatusCodes.Status500InternalServerError, err.Message));
            }
        }

        [HttpPut]
        [Route("/users/username/{username}")]
        public async Task<IActionResult> chanagePasswordByUsername(string username, string password)
        {
            try
            {
                await userServices.updatePasswordByUsername(username, password);
                return await Task.FromResult(StatusCode(StatusCodes.Status200OK, "เปลี่ยนรหัสผ่านเรียบร้อย"));
            }
            catch (Exception err)
            {
                return await Task.FromResult(StatusCode(StatusCodes.Status500InternalServerError, err.Message));
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
