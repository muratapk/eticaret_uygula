using eticaret_uygula.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace eticaret_uygula.Component
{
    public class TrendList:ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public TrendList(ApplicationDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var result=_context.Products.ToList();
            return View(result);
        }
    }
}
