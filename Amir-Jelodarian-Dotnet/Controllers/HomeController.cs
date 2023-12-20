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

    public void saveUser(Users user){
        Users user = new Users();
        user.Name = "amir";
        user.email = "amirjelodarian@gmail.com";
        user.Password = "123";
        db.Users.Add(user);
        db.SaveChanges();

        db.Users.Add(user);
        db.SaveChanges();
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
    public IActionResult Shop()
    {
        List<Products> ListProducts = new List<Products>();

        Products product1 = new Products();
        product1.Id = 1;
        product1.picPath = "/Images/1.webp";
        product1.title = "Iphone 13";
        product1.price = "10 tomn";
        product1.count = "3";
        product1.description = "آیفون 1";
        ListProducts.Add(product1);

        Products product2 = new Products();
        product2.Id = 2;
        product2.picPath = "/Images/2.jpg";
        product2.title = "Iphone 14";
        product2.price = "14 tomn";
        product2.count = "2";
        product2.description = "آیفون 2";
        ListProducts.Add(product2);

        Products product3 = new Products();
        product3.Id = 3;
        product3.picPath = "/Images/3.jpg";
        product3.title = "Iphone 13";
        product3.price = "30 tomn";
        product3.count = "6";
        product3.description = "آیفون 3";
        ListProducts.Add(product3);

        var query = ListProducts.ToList();

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
