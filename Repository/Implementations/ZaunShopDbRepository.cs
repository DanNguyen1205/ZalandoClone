using Microsoft.EntityFrameworkCore;
using ZaunShop.Data;
using ZaunShop.Models;
using ZaunShop.Models.DomainModels;
using ZaunShop.Models.TempModels;
using ZaunShop.Repository.Interface;

namespace ZaunShop.Repository.Implementations
{
    public class ZaunShopDbRepository : IZaunShopDbRepository
    {
        private readonly ZaunShopDbContext _context;
        public ZaunShopDbRepository(ZaunShopDbContext db)
        {
            _context = db;
        }

        public async Task<IEnumerable<Product>> GetAllProducts(int categoryId)
        {
            var products = await _context.products.Where(x => x.categoryid == categoryId).ToListAsync();

            return products;
        }

        public async Task<Product> GetSpecificProduct(int productId)
        {
            var product = await _context.products.FindAsync(productId);

            return product;
        }

        public async Task<CartItem> GetSpecificCartItem(int productId, string sessionId)
        {
            var cartItem = await _context.cartitems.FirstOrDefaultAsync(
                c => c.sessionid == sessionId && c.productid == productId);

            return cartItem;
        }

        public async Task<IEnumerable<CartItemModel>> GetSessionCartItems(string sessionId)
        {
            var item = (from ci in _context.cartitems join p in _context.products 
                        on ci.productid equals p.id 
                        where (ci.sessionid == sessionId) 
                        select new CartItemModel
                        {
                            name = p.name,
                            quantity = ci.quantity,
                            price = p.price,
                            productid = ci.productid,
                            sessionid = sessionId
                        }).ToList();

            //var sessionCartItems = await _context.cartitems.Where(x => x.sessionid == sessionId).ToListAsync();

            return item;
        }

        //Could do some checks to see if we actually create an item or not. 
        public async Task CreateCartItem(CartItem cartItem)
        {
            await _context.cartitems.AddAsync(cartItem);
            await _context.SaveChangesAsync();
        }


        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCartItem(CartItem cartItem)
        {
            _context.cartitems.Remove(cartItem);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
