using ZaunShop.Models;
using ZaunShop.Models.DomainModels;
using ZaunShop.Models.TempModels;

namespace ZaunShop.Repository.Interface
{
    public interface IZaunShopDbRepository : IDisposable
    {
        Task<IEnumerable<Product>> GetAllProducts(int categoryId);

        Task<Product> GetSpecificProduct(int productId);

        Task<IEnumerable<CartItemModel>> GetSessionCartItems(string sessionId);
        Task<CartItem> GetSpecificCartItem(int productId, string sessionId);
        Task CreateCartItem(CartItem cartItem);

        Task DeleteCartItem(CartItem cartItem);

        Task SaveChanges();
    }
}
