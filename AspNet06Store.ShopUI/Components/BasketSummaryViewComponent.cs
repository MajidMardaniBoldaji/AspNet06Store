using AspNet06Store.ShopUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNet06Store.ShopUI.Components
{
    public class BasketSummaryViewComponent: ViewComponent
    {
        private readonly Basket basket;
        public BasketSummaryViewComponent(Basket basket)
        {
            this.basket = basket;
        }
        public IViewComponentResult Invoke()
        {

            return View(basket);
        }
    }
}
