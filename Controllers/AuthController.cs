using EXOformulaire.Models.Auth;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
            return View("_Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                Debug.WriteLine("oki login recu");

                try
                {

                    return RedirectToAction("Dashboard", "Home");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Erreur lors de l'enregistrement");
                }

            }
                Debug.WriteLine("no oki login non recu");
            return View("_Login");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View("_Register");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    return RedirectToAction("Dashboard", "Home");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Erreur lors de l'enregistrement");
                }

            }
            return View("_Register");
        }
            
    }
}
