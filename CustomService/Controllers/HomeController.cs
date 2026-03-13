using CustomService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CustomService.Services;

namespace CustomService.Controllers
{
    public class HomeController : Controller
    {
        private readonly Isomething _something;

        public HomeController(Isomething something)
        {
            _something = something;
        }

        public IActionResult Index()
        {
            var message = _something.DisplayMsg(" abcdef");
            ViewBag.message = message;
            return View();
        }

    }
}
