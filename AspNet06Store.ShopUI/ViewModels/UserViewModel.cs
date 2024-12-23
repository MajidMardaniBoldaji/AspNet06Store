using System.ComponentModel.DataAnnotations;

namespace AspNet06Store.ShopUI.ViewModels
{
    public class UserViewModel
    {
        [Required]
        [MaxLength(150)]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Tell { get; set; }
        public string Mobile { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }
}
