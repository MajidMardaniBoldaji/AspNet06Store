namespace AspNet06Store.ShopUI.Models
{
    public class EfProductRepository : IProductRepoitory
    {
        private readonly StoreDbContext storeDbContext;

        public EfProductRepository(StoreDbContext storeDbContext)
        {
            this.storeDbContext = storeDbContext;
        }

        public List<Product> GetAll()
        {
            return storeDbContext.Products.ToList();    
        }
    }
}
