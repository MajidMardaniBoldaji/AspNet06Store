using AspNet06Store.ShopUI.Models;
using AspNet06Store.ShopUI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNet06Store.ShopUI.Controllers
{
    public class UserController : Controller
    {
        public IUserRepository UserRepository { get; }

        public UserController(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert(UserViewModel userVM)
        {
            var user = new User
            {
                UserName = userVM.UserName,
                Password = userVM.Password,
                FullName = userVM.FullName,
                Tell = userVM.Tell,
                Address = userVM.Address,
                City = userVM.City,
                Mobile = userVM.Mobile
            };
       
            UserRepository.Insert(user);
            return View(user);
        }

    }
}
