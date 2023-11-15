using eticaret_uygula.Data;
using Microsoft.AspNetCore.Mvc;

namespace eticaret_uygula.Component
{
    public class SliderList:ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public SliderList(ApplicationDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var result = _context.Slider.ToList();
            return View(result);
        }
    }
}
