using Microsoft.AspNetCore.Mvc;

namespace RegistrationForm.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index(Models.Register user)
        {
            if (ModelState.IsValid)
            {
                return Content(
                    $"Registration successful for {user.Name} with email {user.Email}.");
            }

            return View(user);
        }
    }
}
