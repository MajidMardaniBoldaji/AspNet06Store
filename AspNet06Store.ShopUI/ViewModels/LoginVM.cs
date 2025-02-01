using System.ComponentModel.DataAnnotations;

namespace AspNet06Store.ShopUI.ViewModels;
public class LoginVm
    {
        [Required(ErrorMessage = "ایمیل الزامی است")]
        [EmailAddress(ErrorMessage = "فرمت ایمیل نادرست است")]
        public string Email { get; set; }

        [Required(ErrorMessage = "پسورد الزامی است")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }


