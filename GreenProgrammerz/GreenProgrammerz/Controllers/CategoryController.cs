using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GreenProgrammerz.Bll.Bll;
using GreenProgrammerz.Model.Model;

namespace GreenProgrammerz.Controllers
{
    public class CategoryController : Controller
    {
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
        [HttpGet]

        public ActionResult CategoryUpdate()
        {
            Category category = new Category();
            return View(category);
        }
        [HttpPost]
        public ActionResult CategoryUpdate(Category category)
        {
            string message = "";
            message += "Code: " + category.Code;
            message += "Name: " + category.Name;
            if (_categoryManager.Update(category))
            {
                message += "Updated!";
            }
            else
            {
                message += "Not Updated!";
            }
            return View(category);
        }
    }
}