namespace AspNet06Store.ShopUI.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        public StoreDbContext StoreDbContext { get; }
        public EFOrderRepository(StoreDbContext storeDbContext)
        {
            StoreDbContext = storeDbContext;
        }

     

        public void Save(Order order)
        {
            StoreDbContext.AttachRange(order.OrderDetails.Select(d => d.Product));
            StoreDbContext.Add(order);
            StoreDbContext.SaveChanges();
        }
    }
}
