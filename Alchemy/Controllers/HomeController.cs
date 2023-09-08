using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Alchemy.Models;

namespace Alchemy.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

public IActionResult Index()
{
    var robot = new List<Robot>
    {
        new Robot { Name = "Bob", ImageUrl = "https://robohash.org/piccolo?set=set2", Country = "USA", Height = "180", Weight = "120" },
        new Robot { Name = "Alice", ImageUrl = "https://robohash.org/Radditz?set=set2", Country = "Canada", Height = "180", Weight = "120" },
        new Robot { Name = "Cédric", ImageUrl = "https://robohash.org/krilin?set=set2", Country = "France", Height = "180", Weight = "120"  }
    };

    ViewData["Title"] = "Most Wanted";
    ViewData["Robot"] = robot;
    
    return View();
}


[HttpPost]
public IActionResult ShowRobot(string selectedRobot)
{
     var robot = new List<Robot>
    {
        new Robot { Name = "Bob", ImageUrl = "https://robohash.org/piccolo?set=set2", Country = "USA", Height = "180", Weight = "120" },
        new Robot { Name = "Alice", ImageUrl = "https://robohash.org/Radditz?set=set2", Country = "Canada", Height = "140", Weight = "100" },
        new Robot { Name = "Cédric", ImageUrl = "https://robohash.org/krilin?set=set2", Country = "France", Height = "110", Weight = "190" }
    };
    ViewData["Title"] = "Most Wanted";
    ViewData["SelectedName"] = selectedRobot;
    ViewData["Robot"] = robot;
    return View("Index");
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
