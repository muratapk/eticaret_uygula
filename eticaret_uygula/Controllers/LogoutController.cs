using eticaret_uygula.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace eticaret_uygula.Controllers
{
    public class LogoutController : Controller
    {
        private readonly SignInManager<AppUser> _singInManager;

        public LogoutController(SignInManager<AppUser> singInManager)
        {
            _singInManager = singInManager;
        }

        public async Task<IActionResult> Index()
        {
            await _singInManager.SignOutAsync();
            ViewBag.Mesaj = "Sistemden Çıkış Yapıldı";
            return RedirectToAction("Index", "Home");
        }
    }
}
