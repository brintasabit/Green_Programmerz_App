using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GreenProgrammerz.Model.Model;
using GreenProgrammerz.Bll.Bll;

namespace GreenProgrammerz.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        ProductManager _productManager=new ProductManager();
        [HttpGet]
        public ActionResult ProductAdd()
        {
            Product product = new Product();
            return View(product);
            //return View();
        }
        [HttpPost]
        public ActionResult ProductAdd(Product product)
        {
            string message = "";
            message += "Category: " +product.Category;
            message += "Code: " +product.Code;
            message += "Name: " + product.Name;
            message += "ReOrderLevel: " + product.ReOrderLevel;
            message += "Description: " + product.Description;
            //return message;
            if (_productManager.SaveInfo(product))
            {
                message += "Saved!";
            }
            else
            {
                message += "Not Saved!";
            }
            return View(product);
        }
        
    }
}