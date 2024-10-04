namespace AspNet06Store.ShopUI.Models
{
    public interface IProductRepoitory
    {
        PagedData<Product> GetAll(int pageNumber,int pageSize);
    }
}
