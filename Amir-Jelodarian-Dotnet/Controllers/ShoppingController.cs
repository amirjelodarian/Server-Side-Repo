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

        private readonly IWebHostEnvironment webHostEnvironment;

        public ShoppingController(ILogger<ShoppingController> logger, ContextDBS contextDBS, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            this.webHostEnvironment = webHostEnvironment;
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
        [HttpPost("/Shopping")]
        public IActionResult SaveForms(Products products){
            string UniqueFileName = Guid.NewGuid() + products.pic.FileName;
            string UploadFolder = Path.Combine(webHostEnvironment.WebRootPath + "\\Images", UniqueFileName);
            using (FileStream fs = new FileStream(UploadFolder, FileMode.Create)){
                products.pic.CopyTo(fs);
            };
            products.picPath = "/Images/" + UniqueFileName;
            db.Products.Add(products);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}