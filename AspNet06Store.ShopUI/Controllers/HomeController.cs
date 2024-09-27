using AspNet06Store.ShopUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNet06Store.ShopUI.Controllers
{
    public class HomeController : Controller
    {
        public IProductRepoitory ProductRepoitory { get; }

        public HomeController(IProductRepoitory productRepoitory)
        {
            ProductRepoitory = productRepoitory;
        }

        public IActionResult Index()
        {
            return View(ProductRepoitory.GetAll());
        }
      //  public IActionResult getAll()
       // {
            
        //}
    }
}
