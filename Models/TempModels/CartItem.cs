using ZaunShop.Models.DomainModels;

namespace ZaunShop.Models.TempModels
{
    public class CartItem
    {
        public int id { get; set; }
        public int quantity { get; set; }
        public System.DateTime datecreated { get; set; }
        public string sessionid { get; set; }
        public int productid { get; set; }
        public Product product { get; set; }
    }
}
