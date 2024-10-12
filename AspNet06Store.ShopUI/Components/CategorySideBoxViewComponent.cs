using AspNet06Store.ShopUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNet06Store.ShopUI.Components
{
    public class CategorySideBoxViewComponent : ViewComponent
    {
        private readonly IProductRepoitory productRepoitory;

        public CategorySideBoxViewComponent(IProductRepoitory productRepoitory)
        {
            this.productRepoitory = productRepoitory;
        }

        public IViewComponentResult Invoke()
        {
            return View(productRepoitory.GetCategories());
        }
    }
}
