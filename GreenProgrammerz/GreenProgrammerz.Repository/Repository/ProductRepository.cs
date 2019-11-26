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
        public bool Update(Product _product)
        {
            try
            {
                //Supplier aSupplier = dbContext.Suppliers.FirstOrDefault(c => c.Id == _supplier.Id);
                dbContext.Entry(_product).State = EntityState.Modified;
                //dbContext.Suppliers.AddOrUpdate(aSupplier);
                return dbContext.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
                //return dbContext.SaveChanges() > 0;
                throw;
            }

        }
        public List<Product> GetAll()
        {
            return dbContext.Products.ToList();
        }

        public Product GetBy(int id)
        {
            return dbContext.Products.First(c => c.Id == id);
        }
    }
}
