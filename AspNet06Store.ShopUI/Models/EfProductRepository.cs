﻿
namespace AspNet06Store.ShopUI.Models
{
    public class EfProductRepository : IProductRepoitory
    {
        private readonly StoreDbContext storeDbContext;

        public EfProductRepository(StoreDbContext storeDbContext)
        {
            this.storeDbContext = storeDbContext;
        }

        public PagedData<Product> GetAll(int pageNumber , int pageSize,string category)
        {
            var result = new PagedData<Product>
            {
                PageInfo = new PageInfo
                {
                    PageNumber = pageNumber,
                    PageSize = pageSize
                }
            };

            result.Data = storeDbContext.Products.Where(c=>string.IsNullOrWhiteSpace(category) || c.Category==category).ToList(); //.Skip(pageSize * (pageNumber - 1)).Take(pageSize)
            result.PageInfo.TotalCount = storeDbContext.Products.Where(c => string.IsNullOrWhiteSpace(category) || c.Category == category).Count();
            return result;
        }

        public List<string> GetCategories()
        {
            return storeDbContext.Products.Select(c => c.Category).Distinct().ToList();
        }

        public Product GetById(int id)
        {
            return storeDbContext.Products.FirstOrDefault(p=>p.ID ==id);
        }
    }
}
