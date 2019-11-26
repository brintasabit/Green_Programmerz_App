using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using GreenProgrammerz.Model.Model;
using GreenProgrammerz.Bll.Bll;
using GreenProgrammerz.Models;

namespace GreenProgrammerz.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        ProductManager _productManager=new ProductManager();
        [HttpGet]
        public ActionResult ProductAdd()
        {
            ProductViewModel productViewModel = new ProductViewModel();
            productViewModel.Products = _productManager.GetAll();
            return View(productViewModel);
            //return View();
        }
        [HttpPost]
        public ActionResult ProductAdd(ProductViewModel productViewModel)
        {
            Product product = Mapper.Map<Product>(productViewModel);
            string message = "";
            message += "Category: " + productViewModel.Category;
            message += "Code: " + productViewModel.Code;
            message += "Name: " + productViewModel.Name;
            message += "ReOrderLevel: " + productViewModel.ReOrderLevel;
            message += "Description: " + productViewModel.Description;
            //return message;
            if (_productManager.SaveInfo(product))
            {
                message += "Saved!";
            }
            else
            {
                message += "Not Saved!";
            }
            return View(productViewModel);
        }
        [HttpGet]
        public ActionResult ProductUpdate()
        {
            ProductViewModel productViewModel = new ProductViewModel();
            productViewModel.Products = _productManager.GetAll();
            return View(productViewModel);
            //return View();
        }
        [HttpPost]
        public ActionResult ProductUpdate(ProductViewModel productViewModel)
        {
            Product product = Mapper.Map<Product>(productViewModel);
            string message = "";
            message += "Category: " + productViewModel.Category;
            message += "Code: " + productViewModel.Code;
            message += "Name: " + productViewModel.Name;
            message += "ReOrderLevel: " + productViewModel.ReOrderLevel;
            message += "Description: " + productViewModel.Description;
            //return message;
            if (_productManager.Update(product))
            {
                message += "Updated!";
            }
            else
            {
                message += "Not Updated!";
            }
            return View(productViewModel);
        }
        //[HttpGet]
        //public ActionResult Search()
        //{
        //    Product aProduct = new Product();
        //    aProduct.Products = _productManager.GetAll();
        //    studentViewModel.DepartmentSelectListItems = _departmentManager
        //        .GetAll()
        //        .Select(c => new SelectListItem()
        //            {
        //                Value = c.Id.ToString(),
        //                Text = c.Name

        //            }
        //        ).ToList();

        //    return View(studentViewModel);

        //}

        //[HttpPost]
        //public ActionResult Search(StudentViewModel studentViewModel)
        //{
        //    var students = _studentManager.GetAll();

        //    if (studentViewModel.RollNo != null)
        //    {
        //        students = students.Where(c => c.RollNo.Contains(studentViewModel.RollNo)).ToList();

        //    }

        //    if (studentViewModel.Name != null)
        //    {
        //        students = students.Where(c => c.Name.ToLower().Contains(studentViewModel.Name.ToLower())).ToList();

        //    }



        //    studentViewModel.Students = students;
        //    studentViewModel.DepartmentSelectListItems = _departmentManager
        //        .GetAll()
        //        .Select(c => new SelectListItem()
        //            {
        //                Value = c.Id.ToString(),
        //                Text = c.Name

        //            }
        //        ).ToList();

        //    return View(studentViewModel);
        //}
    }
}