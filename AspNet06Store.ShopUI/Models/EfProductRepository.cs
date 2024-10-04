namespace AspNet06Store.ShopUI.Models
{
    public class EfProductRepository : IProductRepoitory
    {
        private readonly StoreDbContext storeDbContext;

        public EfProductRepository(StoreDbContext storeDbContext)
        {
            this.storeDbContext = storeDbContext;
        }

        public PagedData<Product> GetAll(int pageNumber , int pageSize)
        {
            var result = new PagedData<Product>
            {
                PageInfo = new PageInfo
                {
                    PageNumber = pageNumber,
                    PageSize = pageSize

                }
            };

            result.Data = storeDbContext.Products.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList(); 
            result.PageInfo.TotalCount = storeDbContext.Products.Count();
            return result;
        }
    }
}
