using eticaret_uygula.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace eticaret_uygula.Controllers
{
    public class ConfirmMailController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ConfirmMailController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var value = TempData["Mail"];
            ViewBag.Email = value;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(ConfirmUser gelen)
        {
            var user = await _userManager.FindByEmailAsync(gelen.Mail);
            if (user.ConfirmCode==gelen.ConfirmCode)
            {
                user.EmailConfirmed = true;
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Index","Login");

            }
            return View();  
        }
    }
}
