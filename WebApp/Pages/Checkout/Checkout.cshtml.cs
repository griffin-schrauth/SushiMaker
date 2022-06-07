using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        
        public string SushiName { get; set; }
        public float SushiPrice { get; set; }
        public string ImageTitle { get; set; }

        private readonly ApplicationDbContext _context;

        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context; 
        }
        public void OnGet()
        {

            if(string.IsNullOrWhiteSpace(SushiName))
            {
                SushiName = "Custom";

            }
            if(string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }

            SushiOrder sushiOrder = new SushiOrder();
            sushiOrder.SushiName = SushiName;
            sushiOrder.BasePrice = SushiPrice;

            _context.SushiOrders.Add(sushiOrder);
            _context.SaveChanges();
        }
    }
}
