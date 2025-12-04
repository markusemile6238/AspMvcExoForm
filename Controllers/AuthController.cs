using Microsoft.AspNetCore.Mvc;

namespace EXOformulaire.Controllers
{
    public class AuthController : Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
    }
}
