using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GreenProgrammerz.Bll.Bll;
using GreenProgrammerz.Model.Model;

namespace GreenProgrammerz.Controllers
{
    public class SupplierController : Controller
    {
        SupplierManager _supplierManager=new SupplierManager();
        // GET: Supplier
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