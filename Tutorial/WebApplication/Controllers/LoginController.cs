using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly IUserServices _userServices;

        public LoginController(ILogger<LoginController> logger, IUserServices userServices)
        {
            _logger = logger;
            this._userServices = userServices;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _userServices.GetUserAsyncWithUsername("asd");
            return View();
        }
        [HttpPost]
        public IActionResult Index(loginViewModel request)
        {
            return View(request);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}