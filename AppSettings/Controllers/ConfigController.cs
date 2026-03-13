using Microsoft.AspNetCore.Mvc;

public class ConfigController : Controller
{
    private readonly IConfiguration _config;

    public ConfigController(IConfiguration config)
    {
        _config = config;
    }

    public IActionResult Index()
    {
        ViewBag.AppName  = _config["AppSettings:ApplicationName"];

        ViewBag.Version = _config["AppSettings:Version"];

        ViewBag.Developer = _config["AppSettings:Developer"];
        return View();
    }
}
