using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using coreApp.Models;

namespace coreApp.Controllers
{
    
    public class ProductController : Controller
    {
         public Generic_Class<Product> products;
        

         public ProductController(){
             DataContext context = new DataContext();
             products = new Generic_Class<Product>(context);
         }

        public ActionResult Index(){
            return View(products.Collection());
        }


        [HttpGet]
        public ActionResult Create(){
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product){
            products.addItem(product);
            products.Commit();
            return RedirectToAction("Index");
        }
    }
}