using AspNet06Store.ShopUI.Models;
using AspNet06Store.ShopUI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
                curreuntUser.UserName = user.UserName;
                curreuntUser.Password = user.Password;

                curreuntUser.City = user.City;
                curreuntUser.Email = user.Email;
                curreuntUser.Address = user.Address;

                dbContext.SaveChanges(); // Save changes to the database
            }
            return RedirectToAction("GetAll");
        }

        // Action to display the Add User form
        [HttpGet("AddUser")]
        public IActionResult AddUser()
        {
            return View();
        }
        // Action to handle form submission
       [HttpPost("AddUser")]
        public IActionResult AddUser( User user)
        {
            if (ModelState.IsValid)
            {
                dbContext.Users.Add(user);
                dbContext.SaveChanges();
            }
            return RedirectToAction("GetAll");
        }
    }
}
