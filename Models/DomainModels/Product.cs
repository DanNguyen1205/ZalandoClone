namespace ZaunShop.Models.DomainModels
{
    public class Product
    {
        public int id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public double price { get; set; }

        public int categoryid { get; set; }

        public Category category { get; set; }
    }
}
