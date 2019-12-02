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
            PurchaseDetails purchase = new PurchaseDetails();
            return View(purchase);
            //return View();
        }
        [HttpPost]
        public ActionResult PurchaseAdd(PurchaseDetails purchaseDetails)
        {
            string message = "";

            message += "Date: " + purchaseDetails.Date;
            message += "BillInvoice: " + purchaseDetails.BillInvoice;
            message += "SupplierName: " + purchaseDetails.SupplierName;
            message += "Category: " + purchaseDetails.Category;
            message += "Products: " + purchaseDetails.Products;
            
            message += "Code: " + purchaseDetails.Code;
            message += "AvailableQuantity: " + purchaseDetails.AvailableQuantity;
            message += "ManufacturedDate: " + purchaseDetails.ManufacturedDate;
            message += "ExpireDate: " + purchaseDetails.ExpireDate;
            message += "Remarks: " + purchaseDetails.Remarks;
            message += "Quantity: " + purchaseDetails.Quantity;
            message += "UnitPrice: " + purchaseDetails.UnitPrice;
            message += "TotalPrice: " + purchaseDetails.TotalPrice;
            message += "PreviousUnitPrice: " + purchaseDetails.PreviousUnitPrice;
            message += "PreviousMrp: " + purchaseDetails.PreviousMRP;
            message += "MRP: " + purchaseDetails.MRP;
            //return message;
            if (_purchaseManager.SaveInfo(purchaseDetails))
            {
                message += "Saved!";
            }
            else
            {
                message += "Not Saved!";
            }
            return View(purchaseDetails);
        }
    }
}