using Microsoft.AspNetCore.Mvc;
using Tutorial.Models.Login;
using Tutorial.Models.Register;
using Tutorial.Services.USER;

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
        public async Task<IActionResult> Index(RegisterDto req)
        {
            if (string.IsNullOrEmpty(req.username) || string.IsNullOrEmpty(req.password))
            {
                ModelState.AddModelError("error", "กรุณากรอก Username และ Password");
                return View(req);
            }

            if (string.IsNullOrEmpty(req.fullname))
            {
                ModelState.AddModelError("error", "กรุณากรอกชื่อ นามสกุล");
                return View(req);
            }

            var register_user = await _regis.setUserwithRegister(req.username, req.password, req.fullname);

            return RedirectToAction("index", "Login");
        }

    }
}
