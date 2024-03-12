using Microsoft.EntityFrameworkCore;
using ZaunShop.Models.DomainModels;
using ZaunShop.Models.TempModels;


namespace ZaunShop.Data
{
    public class ZaunShopDbContext : DbContext
    {
        public ZaunShopDbContext(DbContextOptions<ZaunShopDbContext> options) : base(options)
        {
            
        }

        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<OrderItems> orderitems { get; set; }
        public DbSet<PaymentDetails> paymentdetails { get; set; }
        public DbSet<OrderDetails> orderdetails { get; set; }
        public DbSet<CartItem> cartitems { get; set; }

    }
}
