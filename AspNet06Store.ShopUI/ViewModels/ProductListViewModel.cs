using AspNet06Store.ShopUI.Models;

namespace AspNet06Store.ShopUI.ViewModels
{
    public class ProductListViewModel
    {
        public PagedData<Product> Data { get; set; }
        public string CurrentCategory { get; set; }
    }
}
