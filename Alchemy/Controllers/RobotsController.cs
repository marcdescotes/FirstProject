namespace Alchemy.Controllers;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

public class CreateRobotRequest
{
    public string Name { get; set; }
    public string Weight { get; set; }
    public string Height { get; set; }
    public string Country { get; set; }
}

public class CreateRobotResponse
{
    public bool? Succeed { get; set; }
}
public class RobotsController : Controller
{
    [HttpGet]

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]

    [ActionName("create-robot")]

    public IActionResult CreateRobot([FromBody] CreateRobotRequest req)
    {
        ViewData["Name"] = req.Name;
        ViewData["ImageUrl"] = $"https://robohash.org/{req.Name}";
        ViewData["Weight"] = req.Weight;
        ViewData["Height"] = req.Height;
        ViewData["Country"] = req.Country;
        Console.WriteLine(req.Name, req.Weight, req.Country, req.Height, ViewData["ImageUrl"]);
        return View("RobotPartial");
    }
}