using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Amir_Jelodarian_Dotnet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Amir_Jelodarian_Dotnet.Controllers
{
    [Route("[controller]")]
    public class ShoppingController : Controller
    {
        private readonly ContextDBS db; 
        private readonly ILogger<ShoppingController> _logger;

        public ShoppingController(ILogger<ShoppingController> logger, ContextDBS contextDBS)
        {
            _logger = logger;
            this.db = contextDBS;
        }
        [HttpGet("/Shopping")]
        public IActionResult Index()
        {
            
            var query = db.Products.ToList();
            return View(query);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
        public IActionResult SaveForms(Products products){
            string UniqueFileName = Guid.NewGuid() + products.pic.FileName;
            db.Products.Add(products);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}