using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenProgrammerz.Model.Model
{
    public class Category
    {
        public  int Id { get; set; }
        private string code;
        private string name;
       // public string Search { get; set; }

        public string Code
        {
            get => code;
            set => code = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

    }
}
