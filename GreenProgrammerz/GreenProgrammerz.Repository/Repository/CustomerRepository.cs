using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenProgrammerz.DatabaseContext.DatabaseContext;
using GreenProgrammerz.Model.Model;
using System.Data.Entity;
namespace GreenProgrammerz.Repository.Repository
{
    public class CustomerRepository
    {
        ProjectDbContext dbContext = new ProjectDbContext();

        public bool SaveInfo(Customer _customer)
        {
            dbContext.Customers.Add(_customer);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(Customer _customer)
        {
            try
            {
                //Supplier aSupplier = dbContext.Suppliers.FirstOrDefault(c => c.Id == _supplier.Id);
                dbContext.Entry(_customer).State = EntityState.Modified;
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
    }
}
