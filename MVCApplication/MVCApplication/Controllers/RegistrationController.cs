using Microsoft.AspNetCore.Mvc;

namespace MVCApplication.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            // Handle form submission
            return View();
        }
    }
}
