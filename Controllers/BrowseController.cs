using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Drawing;
using System;
using ZaunShop.Models.DomainModels;
using ZaunShop.Models.Enums;
using ZaunShop.Repository.Interface;
using ZaunShop.Models.TempModels;

namespace ZaunShop.Controllers
{
    //Refactor this to CartController
    public class BrowseController : BaseController
    {
        public BrowseController(IZaunShopDbRepository _zaunShopDbRepository) : base(_zaunShopDbRepository)
        {
        }

        [HttpGet]
        public async Task<IActionResult> Catalog(string id, int pg=1)
        {
            //Query database and get data for category. Return the view with category. 
            //Category name get the enum number, to query DB with.
            var categoryId = (int)((CategoryEnums.Category)Enum.Parse(typeof(CategoryEnums.Category), id));

            var products = await _zaunShopDbRepository.GetAllProducts(categoryId);

            const int pageSize = 9;
  
            int recsCount = products.Count();
            var pager = new Pager(recsCount, pg, pageSize);

            //Logic to decide which page we wanna retrieve. If pg=1 means we skip 0 products. Therefore we take the first 9 products in the list. 
            //If we skip 1*page size we go to next page and take all products from second page. 
            int recSkip = (pg-1) * pageSize;
            var data = products.Skip(recSkip).Take(pager.PageSize).ToList();

            this.ViewBag.Pager = pager;
            this.ViewBag.Category = id;
            this.ViewBag.cartQuantity = GetSessionCount().Result;


            return View(data);
        }

        [HttpGet]
        [Route("Browse/Catalog/{category}/{id:int}")]
        public async Task<IActionResult> Catalog(int id)
        {
            var product = await _zaunShopDbRepository.GetSpecificProduct(id);
            this.ViewBag.cartQuantity = GetSessionCount().Result;


            return View("~/Views/Browse/ProductPage.cshtml", product);
        }


        public IActionResult Browse()
        {
            return View();
        }
    }
}
