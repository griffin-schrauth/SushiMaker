namespace WebApp.Models
{
    public class SushisModel
    {
        public string ImageTitle { get; set; }
        public string SushiName { get; set; }
        public float BasePrice { get; set; } = 2;
        public bool Rice { get; set; }
        public bool CreamCheese { get; set; }
        public bool Tuna { get; set; }
        public bool Salmon { get; set; }
        public bool Avacado { get; set; }
        public bool Cucumber { get; set; }
        public bool Masago { get; set; }
        public bool Shrimp { get; set; }
        public bool Spicy { get; set; }
        public bool Tempura { get; set; }
        public float FinalPrice { get; set; }

    }
}
