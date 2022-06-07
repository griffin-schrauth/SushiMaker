using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;
namespace WebApp.Pages
{
    public class SushiModel : PageModel
    {
        public List<SushisModel> fakeSushiDB = new List<SushisModel>()
        {
            new SushisModel()
            {
            ImageTitle="Mexican",
            SushiName="Mexican",
            BasePrice = 2,
            Rice = true,
            Shrimp = true,
            Avacado = true,
            Masago = true,
            FinalPrice=15
            },
            new SushisModel()
            {
            ImageTitle="RainbowRoll",
            SushiName="RainbowRoll",
            BasePrice = 2,
            Rice=true,
            Tuna = true,
            Salmon = true,
            Shrimp=true,
            Avacado = true,
            FinalPrice=16
            },
            new SushisModel()
            {
            ImageTitle="Tuna",
            SushiName="Tuna",
            BasePrice = 2,
            Rice=true,
            Tuna = true,
            FinalPrice=10
            },
            new SushisModel()
            {
            ImageTitle="Salmon",
            SushiName="Salmon",
            BasePrice = 2,
            Rice=true,
            Salmon = true,
            CreamCheese = true,
            Avacado = true,
            FinalPrice=11
            },
            new SushisModel()
            {
            ImageTitle="SpicyTuna",
            SushiName="SpicyTuna",
            BasePrice = 2,
            Rice=true,
            Tuna = true,
            CreamCheese = true,
            Avacado = true,
            Spicy = true,
            FinalPrice=14
            },
            new SushisModel()
            {
            ImageTitle="CrunchyTuna",
            SushiName="CrunchyTuna",
            BasePrice = 2,
            Rice=true,
            Tuna = true,
            CreamCheese = true,
            Masago = true,
            Tempura = true,
            FinalPrice=15
            },
            new SushisModel()
            {
            ImageTitle="JBRoll",
            SushiName="JBRoll",
            BasePrice = 2,
            Rice=true,
            Salmon = true,
            CreamCheese = true,
            Tempura = true,
            FinalPrice=11
            },
            new SushisModel()
            {
            ImageTitle="ShrimpTempura",
            SushiName="ShrimpTempura",
            BasePrice = 2,
            Rice=true,
            Shrimp = true,
            CreamCheese = true,
            Avacado = true,
            Tempura=true,
            FinalPrice=12
            },
            new SushisModel()
            {
            ImageTitle="TheWorks",
            SushiName="TheWorks",
            BasePrice = 2,
            Rice=true,
            Salmon = true,
            Tuna = true,
            Shrimp =true,   
            CreamCheese = true,
            Avacado = true,
            Masago=true,
            Tempura = true,
            FinalPrice=20
            },


        };
        public void OnGet()
        {
        }
    }
}
