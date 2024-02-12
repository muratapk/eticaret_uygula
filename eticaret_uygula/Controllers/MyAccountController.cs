using Microsoft.AspNetCore.Mvc;

namespace eticaret_uygula.Controllers
{
    public class MyAccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
