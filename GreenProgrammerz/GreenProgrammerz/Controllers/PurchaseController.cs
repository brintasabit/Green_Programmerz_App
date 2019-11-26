using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GreenProgrammerz.Bll.Bll;
using GreenProgrammerz.Model.Model;

namespace GreenProgrammerz.Controllers
{
    public class PurchaseController : Controller
    {
        private PurchaseManager _purchaseManager = new PurchaseManager();
        // GET: Purchase
        [HttpGet]
        public ActionResult PurchaseAdd()
        {
            Purchase purchase = new Purchase();
            return View(purchase);
            //return View();
        }
        [HttpPost]
        public ActionResult PurchaseAdd(Purchase purchase)
        {
            string message = "";

            message += "Date: " + purchase.Date;
            message += "BillInvoice: " + purchase.BillInvoice;
            message += "SupplierName: " + purchase.SupplierName;
            message += "Category: " + purchase.Category;
            message += "Products: " + purchase.Products;
            
            message += "Code: " + purchase.Code;
            message += "AvailableQuantity: " + purchase.AvailableQuantity;
            message += "ManufacturedDate: " + purchase.ManufacturedDate;
            message += "ExpireDate: " + purchase.ExpireDate;
            message += "Remarks: " + purchase.Remarks;
            message += "Quantity: " + purchase.Quantity;
            message += "UnitPrice: " + purchase.UnitPrice;
            message += "TotalPrice: " + purchase.TotalPrice;
            message += "PreviousUnitPrice: " + purchase.PreviousUnitPrice;
            message += "PreviousMrp: " + purchase.PreviousMRP;
            message += "MRP: " + purchase.MRP;
            //return message;
            if (_purchaseManager.SaveInfo(purchase))
            {
                message += "Saved!";
            }
            else
            {
                message += "Not Saved!";
            }
            return View(purchase);
        }
    }
}