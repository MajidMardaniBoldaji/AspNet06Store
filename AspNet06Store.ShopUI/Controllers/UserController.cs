using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AspNet06Store.ShopUI.Models;
using AspNet06Store.ShopUI.ViewModels;

namespace AspNet06Store.ShopUI.Controllers
{
    public class UserController : Controller
    {
        private readonly StoreDbContext dbContext;
        public UserController(StoreDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var users = dbContext.Users.OrderByDescending(u=>u.Id).ToList();
            return View(users);
        }
        [HttpGet("Details")]
        public IActionResult Details(int id)
        {
            var user = dbContext.Users.Find(id);
            if (user == null)
            { return NotFound(); }
            return View(user);
        }
        [HttpPost("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var user = dbContext.Users.Find(id);
            dbContext.Remove(user);
            dbContext.SaveChanges();
            return View(user);
        }
        [HttpGet("Edit/{Id}")]
        public IActionResult Edit(int id)
        {
            var user = dbContext.Users.Find(id);
            ViewBag.userId = id;
            if (user == null) { return NotFound(); }
            return View(user);
        }
        [HttpPost("Edit/{id}")]
        public IActionResult Edit(int id, User user)
        {
            var curreuntUser = dbContext.Users.Find(user.Id);
            if (curreuntUser != null) // Fixing the null check on the found user
            {
                //curreuntUser.UserName = user.UserName;
                //curreuntUser.Password = user.Password;

                //curreuntUser.City = user.City;
                //curreuntUser.Email = user.Email;
                //curreuntUser.Address = user.Address;

                dbContext.SaveChanges(); // Save changes to the database
            }
            return RedirectToAction("GetAll");
        }

        // Action to display the Add User form
        [HttpGet("AddUser")]
        public IActionResult Register()
        {
            return View();
        }
        // Action to handle form submission
       [HttpPost("AddUser")]
        public async Task<IActionResult> Register( RegisterVm vm )
        {
            if (!ModelState.IsValid)
            {
                return View(vm); // اگر اعتبارسنجی‌ها شکست خورد، فرم را دوباره به کاربر نشان می‌دهیم
            }

            // چک کردن اینکه ایمیل تکراری نباشد
            if (dbContext.Users.Any(u => u.Email == vm.Email))
            {
                ModelState.AddModelError("", "این ایمیل قبلاً ثبت شده است");
                return View(vm);
            }

            var newUser = new User
            {
                FullName = vm.FullName,
                Email = vm.Email,
                PasswordHash = vm.Password, // در واقع باید پسورد را هش کنید
                IsConfirm = false // ایمیل تایید نشده
            };

            dbContext.Users.Add(newUser);
            await dbContext.SaveChangesAsync();

            // ارسال ایمیل تایید (در این مرحله نیاورده‌ایم، ولی بعداً می‌توانید اضافه کنید)
            return RedirectToAction("CompleteRegister");
        }
        public IActionResult CompleteRegister()
        {
            return View();
        }

        
    }
}
