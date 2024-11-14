using AspNet06Store.ShopUI.Models;
using AspNet06Store.ShopUI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNet06Store.ShopUI.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository orderRepository;
        private readonly Basket basket;

        public OrderController(IOrderRepository orderRepository, Basket basket)
        {
            this.orderRepository = orderRepository;
            this.basket = basket;
        }
        public IActionResult CheckOut()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CheckOut(CheckOutViewModel model)
        {
            if (!basket.Items.Any())
                ModelState.AddModelError("", "هیج آیتمی به سبد خرید اضافه نگردیده است");
            if (ModelState.IsValid)
            {
                var order = new Order
                {
                    Name = model.Name,
                    Address = model.Address,
                    City = model.City
                };
                foreach (var item in basket.Items)
                {
                    order.OrderDetails.Add(new OrderDetail
                    {
                        Product = item.Product,
                        Quantity = item.Quantity
                    });
                }
                orderRepository.Save(order);
                basket.Clear();
                return RedirectToAction("Complete");
            }
            return View(model);
        }
        public IActionResult Complete()
        {
            return View();  
        }
    }
}
