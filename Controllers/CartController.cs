using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using ZaunShop.Business;
using ZaunShop.Models.DomainModels;
using ZaunShop.Models.TempModels;

using ZaunShop.Repository.Interface;

namespace ZaunShop.Controllers
{
    public class CartController : BaseController
    {
        //private IZaunShopDbRepository _zaunShopDbRepository;
        private string sessionId;

        public CartController(IZaunShopDbRepository _zaunShopDbRepository) : base(_zaunShopDbRepository)
        {
            //this._zaunShopDbRepository = _zaunShopDbRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            //Get cart items here. 
            sessionId = GetSessionInfo().ElementAt(1);

            var cartItems = await _zaunShopDbRepository.GetSessionCartItems(sessionId);

            this.ViewBag.cartQuantity = GetSessionCount().Result;

            return View(cartItems);
        }


        [HttpPost]
        public async Task AddToCart(int productId)
        {
            //Retrieve session ID
            sessionId = GetSessionInfo().ElementAt(1);

            var cartItem = _zaunShopDbRepository.GetSpecificCartItem(productId, sessionId).Result;

            if (cartItem is null)
            {
                //If no cart item exist we add one
                cartItem = new CartItem
                {
                    quantity = 1,
                    datecreated = DateTime.Now,
                    sessionid = sessionId,
                    productid = productId
                };

                await _zaunShopDbRepository.CreateCartItem(cartItem);
            }
            //Cart item exist add to quantity of that cart item.
            else
            {
                cartItem.quantity++;
                await _zaunShopDbRepository.SaveChanges();
            }

            this.ViewBag.cartQuantity = GetSessionCount().Result;
        }

        //Utility function to get sessioninfo
        //[HttpGet]
        //public IEnumerable<string> GetSessionInfo()
        //{
        //    List<string> sessionInfo = new List<string>();

        //    if (string.IsNullOrWhiteSpace(HttpContext.Session.GetString(SessionVariables.SessionKeyEnum.SessionKeyUsername.ToString())))
        //    {
        //        HttpContext.Session.SetString(SessionVariables.SessionKeyEnum.SessionKeyUsername.ToString(), "Current user test1");
        //        HttpContext.Session.SetString(SessionVariables.SessionKeyEnum.SessionKeySessionId.ToString(), Guid.NewGuid().ToString());

        //    }

        //    var username = HttpContext.Session.GetString(SessionVariables.SessionKeyEnum.SessionKeyUsername.ToString());
        //    var sessionId = HttpContext.Session.GetString(SessionVariables.SessionKeyEnum.SessionKeySessionId.ToString());

        //    sessionInfo.Add(username);
        //    sessionInfo.Add(sessionId);

        //    return sessionInfo;
        //}



        [HttpGet]
        public async Task<IActionResult> GetCartItems()
        {
            sessionId = GetSessionInfo().ElementAt(1);

            var cartItems = await _zaunShopDbRepository.GetSessionCartItems(sessionId);

            return View(cartItems);
        }

        public async Task AddQuantity(int productId)
        {
            sessionId = GetSessionInfo().ElementAt(1);

            var cartItem = _zaunShopDbRepository.GetSpecificCartItem(productId, sessionId).Result;

            if (cartItem is not null)
            {
                cartItem.quantity++;
                await _zaunShopDbRepository.SaveChanges();
            }
        }


        public async Task RemoveQuantity(int productId)
        {
            sessionId = GetSessionInfo().ElementAt(1);

            var cartItem = _zaunShopDbRepository.GetSpecificCartItem(productId, sessionId).Result;

            if (cartItem is not null)
            {

                if(cartItem.quantity == 1)
                {
                    await _zaunShopDbRepository.DeleteCartItem(cartItem);
                }
                else
                {
                    cartItem.quantity--;
                    await _zaunShopDbRepository.SaveChanges();
                }
            }
        }



    }
}
