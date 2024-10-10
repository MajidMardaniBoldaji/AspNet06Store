using AspNet06Store.ShopUI.Models;

using Microsoft.AspNetCore.Mvc;

namespace AspNet06Store.ShopUI.Controllers
{
    public class HomeController : Controller
    {
        public IProductRepoitory ProductRepoitory { get; }
        private int pageSize = 4;
        public HomeController(IProductRepoitory productRepoitory)
        {
            ProductRepoitory = productRepoitory;
        }

        public IActionResult Index(string category="",int pageNumber=1)
        {
            var viewModel = new ViewModels.ProductListViewModel
            {
                Data = ProductRepoitory.GetAll(pageNumber, pageSize, category),
                CurrentCategory = category
            };
            return View(viewModel);
        }

    }
}
