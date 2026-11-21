using Microsoft.AspNetCore.Mvc;
using MVCApplication_C.Models;
using MVCApplication_C.Models.Entities;

namespace MVCApplication_C.Controllers
{
    public class RegistrationController : Controller
    {
        public DatabaseContext _context;

        public RegistrationController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(user);
        }
    }
}
