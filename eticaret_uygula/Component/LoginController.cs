using Microsoft.AspNetCore.Mvc;

namespace eticaret_uygula.Component
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult yeni()
        {
            return View();
        }
    }
}
