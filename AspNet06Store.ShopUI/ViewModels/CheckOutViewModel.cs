using System.ComponentModel.DataAnnotations;

namespace AspNet06Store.ShopUI.ViewModels
{
    public class CheckOutViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
    }
}
