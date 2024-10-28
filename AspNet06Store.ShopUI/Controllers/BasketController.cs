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

        public BasketController(IProductRepoitory productRepoitory)
        {
            this.productRepoitory = productRepoitory;
        }
        public IActionResult Index(string returnUrl)
        {
            BasketViewModel basketViewModel = new BasketViewModel()
            {
                Basket = GetBasket(),
                ReturnUrl = returnUrl
            };

            return View(basketViewModel);
        }
        [HttpPost]
        public IActionResult AddToBasket(int productId, string returnUrl)
        {
            var prouct = productRepoitory.GetById(productId);
            var basket = GetBasket();
            basket.AddToBasket(prouct, 1);
            saveToBasket(basket);
            return RedirectToAction("Index", new { returnUrl = returnUrl });
        }
        public Basket GetBasket()
        {
            var basketItem = HttpContext.Session.GetString("Basket");
            if (string.IsNullOrEmpty(basketItem))
            {
                return new Basket();
            }
            else
                return JsonConvert.DeserializeObject<Basket>(basketItem);

        }
        public void saveToBasket(Basket basket)
        {
            HttpContext.Session.SetString("Basket", JsonConvert.SerializeObject(basket));
        }

    }
}
