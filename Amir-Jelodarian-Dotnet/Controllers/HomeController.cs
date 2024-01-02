using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Amir_Jelodarian_Dotnet.Models;


namespace Amir_Jelodarian_Dotnet.Controllers;

public class HomeController : Controller
{
    private readonly ContextDBS db;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, ContextDBS contextDBS)
    {
        db = contextDBS;
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult SaveUser(Users user){
        db.Users.Add(user);
        db.SaveChanges();
        return RedirectToAction("ContactUs");
    }

    public IActionResult ContactUs()
    {

        var query = db.Users.ToList().OrderByDescending(user => user.Id);

        ViewBag.countUser = db.Users.ToList().Count;

        // double sumAllWeight = 0;
        // foreach(var item in query){
        //     if (item.Weight.HasValue)
        //     sumAllWeight += item.Weight.Value;
        // }

        return View(query);
    }
  
    public IActionResult AboutUs()
    {
        return View();
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
