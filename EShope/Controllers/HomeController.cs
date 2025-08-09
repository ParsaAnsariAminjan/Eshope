using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace EShope.Controllers;

public class HomeController : Controller
{
    private List<string> Products = new List<string>
    {
        "Laptop",
        "Smartphone",
        "Tablet",
        "Smartwatch"
    };
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        ViewBag.Products = Products;
        ViewData["Products"] = Products;
        return View ();
    }

    public IActionResult Privacy()
    {
        return View();
    }


}
