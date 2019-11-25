using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenProgrammerz.DatabaseContext.DatabaseContext;
using GreenProgrammerz.Model.Model;

namespace GreenProgrammerz.Repository.Repository
{
    public class SupplierRepository
    {
        ProjectDbContext dbContext=new ProjectDbContext();
        public bool SaveInfo(Supplier _supplier)
        {
            dbContext.Suppliers.Add(_supplier);                       
            return dbContext.SaveChanges() > 0;
        }
        public bool Update(Supplier _supplier)
        {
            try
            {
                //Supplier aSupplier = dbContext.Suppliers.FirstOrDefault(c => c.Id == _supplier.Id);
                dbContext.Entry(_supplier).State = EntityState.Modified;
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
