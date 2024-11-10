using AspNet06Store.ShopUI.Models;
using AspNet06Store.ShopUI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace AspNet06Store.ShopUI.Controllers
{
    public class BasketController : Controller
    {
        private readonly IProductRepoitory productRepoitory;
        private readonly Basket sessionBasket;

        public BasketController(IProductRepoitory productRepoitory, Basket sessionBasket)
        {
            this.productRepoitory = productRepoitory;
            this.sessionBasket = sessionBasket;
        }
        public IActionResult Index(string returnUrl)
        {
            BasketViewModel basketViewModel = new()
            {
                // Basket = GetBasket(), deploye in basket
                Basket = sessionBasket,
                ReturnUrl = returnUrl
            };

            return View(basketViewModel);
        }
        [HttpPost]
        public IActionResult AddToBasket(int productId, string returnUrl)
        {
            var product = productRepoitory.GetById(productId);
            //  var basket = GetBasket();
            sessionBasket.Add(product, 1);
            //  saveToBasket(basket);
            return RedirectToAction("Index", new { ReturnUrl = returnUrl });
        }

        public IActionResult RemoveFromBasket(int productId, string returnUrl)
        {
            var product = productRepoitory.GetById(productId);
           // var basket = GetBasket();  //Deploye in Baket
            sessionBasket.Remove(product);
           // saveToBasket(basket);
            return RedirectToAction("Index", new { ReturnUrl = returnUrl });
        }
        //This two Method Deploye in Basket session Basket
        //public Basket GetBasket()
        //{
        //    var basketItem = HttpContext.Session.GetString("Basket");
        //    if (string.IsNullOrEmpty(basketItem))
        //    {
        //        return new Basket();
        //    }
        //    else
        //        return JsonConvert.DeserializeObject<Basket>(basketItem);

        //}
        //public void saveToBasket(Basket basket)
        //{
        //    HttpContext.Session.SetString("Basket", JsonConvert.SerializeObject(basket));
        //}

    }
}
