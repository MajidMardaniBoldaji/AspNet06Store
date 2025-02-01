using System.ComponentModel.DataAnnotations;

namespace AspNet06Store.ShopUI.ViewModels
{
    public class RegisterVm
    {
        [Required(ErrorMessage ="وارد کردن ایمیل الزامی می باشد")]
        [EmailAddress(ErrorMessage ="وارد کردن ایمیل به شکل صحیح الزامی می باشد")]
        public string Email { get; set; }

        [Required(ErrorMessage = "وارد کردن پسورد الزامی می باشد")]
        public string Password { get; set; }

        [Required(ErrorMessage = "وارد کردن تکرار پسورد  الزامی می باشد")]
        public string ConfirmPassword { get; set; }

        public string? FullName { get; set; }

  
    }
}
