using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ZaunShop.Models;
using ZaunShop.Repository.Implementations;
using ZaunShop.Repository.Interface;

namespace ZaunShop.Controllers
{

    public class HomeController : BaseController
    {
        private int cartQuantity;

        public HomeController(IZaunShopDbRepository _zaunShopDbRepository) : base(_zaunShopDbRepository)
        {
        }

        public async Task<IActionResult> Index()
        {
            cartQuantity = GetSessionCount().Result;
            this.ViewBag.cartQuantity = cartQuantity;

            var products = await _zaunShopDbRepository.GetAllProducts(1);
            products = products.Take(5).ToList();
            var url = "/content/images/jojoposeguy.jpg";

            BannerModel bannerModel1 = new BannerModel()
            {
                picString = "/content/images/jojoposeguy.jpg",
                products = (List<Models.DomainModels.Product>)products
            };

            BannerModel bannerModel2 = new BannerModel()
            {
                picString = "/content/images/jojoposeguy.jpg",
                products = (List<Models.DomainModels.Product>)products
            };

            List<BannerModel> bannerList = new List<BannerModel>();

            bannerList.Add(bannerModel1);
            bannerList.Add(bannerModel2);

            return View(bannerList);
        }

        public IActionResult Browse() 
        {
            return View();
        }

    }
}