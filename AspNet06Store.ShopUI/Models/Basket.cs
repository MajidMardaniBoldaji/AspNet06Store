namespace AspNet06Store.ShopUI.Models
{
    public class Basket
    {
        public List<BasketItem> _items = new();

        public void AddToBasket(Product product, int quant)
        {
            var itemBasket = _items.Where(c => c.Product.ID == product.ID).FirstOrDefault();
            if (itemBasket != null)
            {
                itemBasket.Quantity += quant;
            }
            else
            {
                _items.Add(new BasketItem
                {
                    Product = product,
                    Quantity = quant
                });
            }
        }
        public void RemoveFromBasket(Product product) =>
            _items.RemoveAll(c => c.Product.ID == product.ID);
        public int TotalPrice() =>
            _items.Sum(c => c.Product.Price * c.Quantity);
        public IEnumerable<BasketItem> Items => _items;

    }
    public class BasketItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

    }
}
