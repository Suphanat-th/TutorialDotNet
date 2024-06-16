using Microsoft.AspNetCore.Mvc;
using Tutorial.Models;
using Tutorial.Services;

namespace Tutorial.Controllers
{
    public class RegisterController : Controller
    {

        private readonly IServicesUser _regis;
        public RegisterController(IServicesUser regis)
        {

            _regis = regis;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(userResponse req)
        {
            if (string.IsNullOrEmpty(req.username) || string.IsNullOrEmpty(req.password))
            {
                ModelState.AddModelError("error", "กรุณากรอก Username และ Password");
                return View(req);
            }
            var register_user = await _regis.setUserwithRegister(req.username, req.password);

            return RedirectToAction("index", "Login");
        }

    }
}
