using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GreenProgrammerz.Model.Model;
using GreenProgrammerz.Bll.Bll;


namespace GreenProgrammerz.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager _customerManager= new CustomerManager();
        [HttpGet]
        public ActionResult CustomerAdd()
        {
            Customer customer= new Customer();
            return View(customer);
            //return View();
        }
        [HttpPost]
        // GET: Customer
        public ActionResult CustomerAdd(Customer customer)

        {
            string message = "";

            message += "Code: " + customer.Code;
            message += "Name: " + customer.Name;
            message += "Address: " + customer.Address;
            message += "Email: " + customer.Email;
            message += "Contact: " + customer.Contact;
            message += "LoyaltyPoint: " + customer.LoyaltyPoint;
            //return message;
            if (_customerManager.SaveInfo(customer))
            {
                message += "Saved!";
            }
            else
            {
                message += "Not Saved!";
            }
            return View(customer);
        }

        [HttpGet]
        public ActionResult CustomerUpdate()
        {
            Customer customer = new Customer();
            return View(customer);
            //return View();
        }
        [HttpPost]
        public ActionResult CustomerUpdate(Customer customer)
        {
            string message = "";

            message += "Code: " + customer.Code;
            message += "Name: " + customer.Name;
            message += "Address: " + customer.Address;
            message += "Email: " + customer.Email;
            message += "Contact: " + customer.Contact;
            message += "LoyaltyPoint: " + customer.LoyaltyPoint;
            //return message;
            if (_customerManager.Update(customer))
            {
                message += "Updated!";
            }
            else
            {
                message += "Not Updated!";
            }
            return View(customer);
        }

    }
}

    


