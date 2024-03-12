using ZaunShop.Models.DomainModels;

namespace ZaunShop.Models.TempModels
{
    public class ShoppingSession
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public double total { get; set; }
    }
}
