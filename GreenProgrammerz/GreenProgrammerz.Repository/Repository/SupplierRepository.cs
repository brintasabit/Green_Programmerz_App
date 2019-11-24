using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
            try
            {
                dbContext.Suppliers.Add(_supplier);
            
                
            }
            catch (Exception exception)
            {
                //Console.WriteLine(e);
                
            }
            return dbContext.SaveChanges() > 0;
        }
    }
}
