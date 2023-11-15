using eticaret_uygula.Data;
using eticaret_uygula.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eticaret_uygula.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly ApplicationDbContext _context;
		public HomeController(ILogger<HomeController> logger,ApplicationDbContext context)
		{
			_logger = logger;
			_context = context;
		}

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Detay(int id)
		{
			var result = _context.Products.Find(id);
			return View(result);
		}
		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}