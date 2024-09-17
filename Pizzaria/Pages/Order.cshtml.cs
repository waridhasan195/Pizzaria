using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzaria.Data;
using Pizzaria.Models;

namespace Pizzaria.Pages
{
    public class OrderModel : PageModel
    {
        public List<PizzaOrder> orders = new List<PizzaOrder>();

        private readonly ApplicationDbContext _context;
        public OrderModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            orders = _context.PizzaOrders.ToList();
        }
    }
}
