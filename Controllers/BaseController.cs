using Microsoft.AspNetCore.Mvc;
using ZaunShop.Business;
using ZaunShop.Repository.Interface;

namespace ZaunShop.Controllers
{
    public class BaseController : Controller
    {
        protected IZaunShopDbRepository _zaunShopDbRepository;
        private string sessionId;
        private int quantity;

        public BaseController(IZaunShopDbRepository _zaunShopDbRepository)
        {
            this._zaunShopDbRepository = _zaunShopDbRepository;
        }

        [HttpGet]
        public IEnumerable<string> GetSessionInfo()
        {
            List<string> sessionInfo = new List<string>();

            if (string.IsNullOrWhiteSpace(HttpContext.Session.GetString(SessionVariables.SessionKeyEnum.SessionKeyUsername.ToString())))
            {
                HttpContext.Session.SetString(SessionVariables.SessionKeyEnum.SessionKeyUsername.ToString(), "Current user test1");
                HttpContext.Session.SetString(SessionVariables.SessionKeyEnum.SessionKeySessionId.ToString(), Guid.NewGuid().ToString());

            }

            var username = HttpContext.Session.GetString(SessionVariables.SessionKeyEnum.SessionKeyUsername.ToString());
            var sessionId = HttpContext.Session.GetString(SessionVariables.SessionKeyEnum.SessionKeySessionId.ToString());

            sessionInfo.Add(username);
            sessionInfo.Add(sessionId);

            return sessionInfo;
        }

        [HttpGet]
        public async Task<int> GetSessionCount()
        {
            sessionId = GetSessionInfo().ElementAt(1);

            var cartItems = await _zaunShopDbRepository.GetSessionCartItems(sessionId);

            foreach(var cartItem in cartItems)
            {
                quantity += cartItem.quantity;
            }

            return quantity;
        }
    }
}
