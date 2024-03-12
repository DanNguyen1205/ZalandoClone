using ZaunShop.Models.DomainModels;

namespace ZaunShop.Models
{
    public class CartItemModel
    {
        public int id { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public string sessionid { get; set; }
        public string name { get; set; }
        public int productid { get; set; }
    }
}
