using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Amir_Jelodarian_Dotnet.Models;


namespace Amir_Jelodarian_Dotnet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    // start second sesson
  public IActionResult ContactUs()
    {
        List<Users> ListUsers = new List<Users>();

        Users users1 = new Users();
        users1.Id = 1;
        users1.Name = "amir";
        users1.Family = "jelodarian";
        users1.NameFather = "ali";
        users1.Password = "amir0000";
        users1.Gender = true;
        users1.Birthday = DateTime.Parse("2002/01/01");
        users1.Active = true;
        users1.Weight = 50.2;
        ListUsers.Add(users1);

        Users users2 = new Users();
        users2.Id = 2;
        users2.Name = "amir2";
        users2.Family = "jelodarian2";
        users2.NameFather = "ali2";
        users2.Password = "amir00002";
        users2.Gender = true;
        users2.Birthday = DateTime.Parse("2002/01/01");
        users2.Active = false;
        users2.Weight = 120.4;
        ListUsers.Add(users2);

        Users users3 = new Users();
        users3.Id = 3;
        users3.Name = "amir3";
        users3.Family = "jelodarian3";
        users3.NameFather = "ali3";
        users3.Password = "amir00003";
        users3.Gender = true;
        users3.Birthday = DateTime.Parse("2002/01/01");
        users3.Active = true;
        users3.Weight = 120.9;
        ListUsers.Add(users3);

        var query = ListUsers.ToList();

        /*string hi = "hello";
        ViewBag.sayHi = hi;*/

        double sumAllWeight = 0;
        foreach(var item in query){
            if (item.Weight.HasValue)
            sumAllWeight += item.Weight.Value;
        }

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
