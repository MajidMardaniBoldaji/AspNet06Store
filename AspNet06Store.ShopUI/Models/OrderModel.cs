namespace AspNet06Store.ShopUI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public string Address { get; set; } 
        public string City { get; set; }
        public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }

    public class OrderDetail
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
