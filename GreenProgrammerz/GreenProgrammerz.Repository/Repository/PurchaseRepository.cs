using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenProgrammerz.DatabaseContext.DatabaseContext;
using GreenProgrammerz.Model.Model;

namespace GreenProgrammerz.Repository.Repository
{
    public class PurchaseRepository
    {
        ProjectDbContext dbContext = new ProjectDbContext();
        public bool SaveInfo(Purchase _purchase)
        {

                dbContext.Purchases.Add(_purchase);

                return dbContext.SaveChanges() > 0;
            



        }
    }
}
