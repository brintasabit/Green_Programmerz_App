using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GreenProgrammerz.Model.Model;

namespace GreenProgrammerz.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ReOrderLevel { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
}