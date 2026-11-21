using Microsoft.AspNetCore.Mvc;
using MVCApplication_C.Models;
using MVCApplication_C.Models.Entities;
using System.Diagnostics;

namespace MVCApplication_C.Controllers
{
    public class HomeController : Controller
    {
        private DatabaseContext _context;

        public HomeController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var users = _context.Users.ToList();
            return View(users);
        }
        public IActionResult Edit(int Id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == Id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }
        [HttpPost]
        public IActionResult Edit(User user)
        {
            if ((string.IsNullOrEmpty(user.Name) || string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Gender.ToString())))
                return BadRequest("Name, Email, and Gender are required fields.");
            else {
                var existingUser = _context.Users.FirstOrDefault(u => u.Id == user.Id);
                if (existingUser != null)
                {
                    existingUser.Name = user.Name;
                    existingUser.Email = user.Email;
                    existingUser.Gender = user.Gender;
                    _context.Users.Update(existingUser);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(user);
            }
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
