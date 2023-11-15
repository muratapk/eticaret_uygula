using eticaret_uygula.Data;
using eticaret_uygula.Dto;
using eticaret_uygula.Models;
using eticaret_uygula.Oturum;
using Microsoft.AspNetCore.Mvc;

namespace eticaret_uygula.Component
{
    public class CartSumList:ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public CartSumList(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();

            CartViewModel cartVm = new()
            {
                CartItems = cart,
                GrandTotal = cart.Sum(x => x.Quantity * x.Price)
            };
            return View(cartVm);
        }
        
    }
}
