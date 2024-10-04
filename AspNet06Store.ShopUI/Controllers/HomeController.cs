using AspNet06Store.ShopUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNet06Store.ShopUI.Controllers
{
    public class HomeController : Controller
    {
        public IProductRepoitory ProductRepoitory { get; }
        private int pageSize = 2;
        public HomeController(IProductRepoitory productRepoitory)
        {
            ProductRepoitory = productRepoitory;
        }

        public IActionResult Index(int pageNumber=1)
        {
            return View(ProductRepoitory.GetAll(pageNumber, pageSize));
        }
      //  public IActionResult getAll()
       // {
            
        //}
    }
}
