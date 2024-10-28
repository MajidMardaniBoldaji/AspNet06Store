namespace AspNet06Store.ShopUI.Models
{
    public interface IProductRepoitory
    {
        PagedData<Product> GetAll(int pageNumber,int pageSize,string category);
        List<string> GetCategories();   
        Product GetById(int id);
    }
}
