using Microsoft.AspNetCore.Mvc;

namespace Actionresult.Controllers
{
    public class Studentcontroller : Controller
    {
        [Route("input/{id}")]
        public IActionResult Input(int id , string name)
        {
            string message = $"Student ID: {id} ,Student Name : {name}";
            return Content(message);
        }
    }
}
