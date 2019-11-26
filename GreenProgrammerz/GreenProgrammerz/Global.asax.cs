using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using GreenProgrammerz.Models;
using GreenProgrammerz.Model.Model;

namespace GreenProgrammerz
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<ProductViewModel, Product>();
                    cfg.CreateMap<Product, ProductViewModel>();
                }
            );
        }
    }
}
