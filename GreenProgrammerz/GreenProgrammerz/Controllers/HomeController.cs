using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GreenProgrammerz.Bll.Bll;
using GreenProgrammerz.Model.Model;

namespace GreenProgrammerz.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        
        public ActionResult Index()
        {
            return View();
        }
        private CategoryManager _categoryManager = new CategoryManager();
        // GET: Category
        [HttpGet]

        public ActionResult Add()
        {
            Category category=new Category();
            return View(category);
        }
        [HttpPost]
        public ActionResult Add(Category category)
        {
            string message="";
            message+="Code: "+category.Code;
            message+="Name: "+category.Name;
            if (_categoryManager.SaveInfo(category))
            {
                message += "Saved!";
            }
            else
            {
                message += "Not Saved!";
            }
            return View(category);
        }
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
        SupplierManager _supplierManager=new SupplierManager();
        [HttpGet]
        public ActionResult SupplierAdd()
        {
            Supplier supplier=new Supplier();
            return View(supplier);
            //return View();
        }
        [HttpPost]
        public ActionResult SupplierAdd(Supplier supplier)
        {
            string message = "";
            
            message += "Code: " +supplier.Code;
            message += "Name: " + supplier.Name;
            message += "Address: " +supplier.Address;
            message += "Email: " + supplier.Email;
            message += "Contact: " + supplier.Contact;
            message += "ContactPerson: " +supplier.ContactPerson;
            //return message;
            if (_supplierManager.SaveInfo(supplier))
            {
                message += "Saved!";
            }
            else
            {
                message += "Not Saved!";
            }
            return View(supplier);
        }
    }
}