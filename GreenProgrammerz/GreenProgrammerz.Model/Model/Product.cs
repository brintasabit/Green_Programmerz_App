using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenProgrammerz.Model.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ReOrderLevel { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }
        // public string Search { get; set; }

        //public string Category
        //{
        //    get => category;
        //    set => category = value;
        //}

        //public string Code
        //{
        //    get => code;
        //    set => code = value;
        //}

        //public string Name
        //{
        //    get => name;
        //    set => name = value;
        //}

        //public string ReOrderLevel
        //{
        //    get => reOrderLevel;
        //    set => reOrderLevel = value;
        //}

        //public string Description
        //{
        //    get => description;
        //    set => description = value;
        //}
    }
}
