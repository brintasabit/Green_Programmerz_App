using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using GreenProgrammerz.Model.Model;
using GreenProgrammerz.DatabaseContext.DatabaseContext;

namespace GreenProgrammerz.Repository.Repository
{
    public class ProductRepository
    {
        ProjectDbContext dbContext = new ProjectDbContext();
        public bool SaveInfo(Product _product)
        {
            
            dbContext.Products.Add(_product);

            return dbContext.SaveChanges() > 0;
        }
    }
}
