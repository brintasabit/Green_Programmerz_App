using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenProgrammerz.Model.Model;

namespace GreenProgrammerz.DatabaseContext.DatabaseContext
{
    public class ProjectDbContext:DbContext
    {
        public ProjectDbContext()
        {
            Configuration.LazyLoadingEnabled = false; // Disable Lazy loading
        }
        public DbSet<Category>Categories{ get;set;}
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseDetails> PurchaseDetailses { get; set; }
    }
}
