using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages
{
    public class OrdersModel : PageModel
    {
        public List<SushiOrder> SushiOrders = new List<SushiOrder>();

        private readonly ApplicationDbContext _context;
        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            SushiOrders = _context.SushiOrders.ToList();
        }
    }
}
