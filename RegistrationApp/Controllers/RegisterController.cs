using Microsoft.AspNetCore.Mvc;

namespace RegistrationApp.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Models.Register User)
        {
            if (ModelState.IsValid)
            {

                return Content(
                    $"Registration successfull\nname : {User.Name}  \n Email : {User.Email}\n Password :{User.Password}\n  Age : {User.Age} ");
            }
            return View(User);
        }
    }
}
