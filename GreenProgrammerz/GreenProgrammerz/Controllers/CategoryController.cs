using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GreenProgrammerz.Model.Model;

namespace GreenProgrammerz.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
        public string Add(Category category)
        {
            string message="";
            message+="Code: "+category.Code;
            message+="Name: "+category.Name;

            return message;
        }
    }
}