using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;

namespace WebApp.Pages.Forms
{
    public class CustomSushiModel : PageModel
    {
        [BindProperty]
        public SushisModel Sushi { get; set; }
        public float SushiPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            SushiPrice = Sushi.BasePrice;

            if (Sushi.Rice) SushiPrice += 1;
            if (Sushi.CreamCheese) SushiPrice += 2;
            if (Sushi.Tuna) SushiPrice += 7;
            if (Sushi.Salmon) SushiPrice += 6;
            if (Sushi.Avacado) SushiPrice += 3;
            if (Sushi.Cucumber) SushiPrice += 1;
            if (Sushi.Masago) SushiPrice += 3;
            if (Sushi.Shrimp) SushiPrice += 5;
            

            return RedirectToPage("/Checkout/Checkout", new { Sushi.SushiName, SushiPrice });
        }
    }
}
