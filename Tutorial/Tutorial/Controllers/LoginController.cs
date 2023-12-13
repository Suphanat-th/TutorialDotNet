using Microsoft.AspNetCore.Mvc;
using Tutorial.Models.Login;
using Tutorial.Services.USER;

namespace Tutorial.Controllers
{
    public class LoginController : Controller
    {
        private readonly IServicesUser _user;
        public LoginController(IServicesUser servicesUser)
        {
            _user = servicesUser;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(loginDtos req)
        {
            ModelState.Clear();
            if (string.IsNullOrEmpty(req.username))
            {
                ModelState.AddModelError("error", "กรุณากรอก Username Or Password");
                return View(req);
            }
            if (string.IsNullOrEmpty(req.password))
            {
                ModelState.AddModelError("error", "กรุณากรอก Username Or Password");
                return View(req);
            }
            var user = await _user.getUserByUsername(req.username);

            if (user == null)
            {
                ModelState.AddModelError("error", "ไม่พบบัญชีผู้ใช้งาน");
                return View(req);
            }
            var Passowrd = user.password == req.password;
            if (!Passowrd)
            {
                ModelState.AddModelError("error", "กรุณากรอกรหัสผู้ใช้งานให้ถูกต้อง");
                return View(req);
            }

            return RedirectToAction("index", "Home");
        }
    }
}
