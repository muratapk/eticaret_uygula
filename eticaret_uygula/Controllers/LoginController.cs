using eticaret_uygula.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace eticaret_uygula.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public LoginController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel gelen)
        {
            var result = await _signInManager.PasswordSignInAsync(gelen.UserName, gelen.Password, false, true);
            if (result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(gelen.UserName);
                if (user.EmailConfirmed==true)
                {
                    return RedirectToAction("Index", "MyAccount");
                }
            }
            return View();
        }
    }
}
