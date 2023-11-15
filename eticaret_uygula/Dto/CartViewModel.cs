using eticaret_uygula.Models;

namespace eticaret_uygula.Dto
{
    public class CartViewModel
    {
        public List<CartItem> CartItems { get; set; }
        public decimal GrandTotal { get; set; } 
    }
}
