using Microsoft.AspNetCore.Mvc;

namespace RoutingDemoMVC.Controllers
{
    public class StudentController : Controller
    {
        [Route("Details/{id}")]
        public IActionResult Details(int id)
        {
            return Content("student ID is: " + id);

        }
        [Route("Marks/{id}/{subject}")]

        public IActionResult Marks(int id, string subject)
        {
            return Content($"Student ID : {id} . Subject : {subject}.");
        }
    }
}