using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenProgrammerz.Model.Model;
using GreenProgrammerz.Repository.Repository;

namespace GreenProgrammerz.Bll.Bll
{
    public class CategoryManager
    {
        CategoryRepository _categoryRepository=new CategoryRepository();
        public bool SaveInfo(Category _category)
        {
            return _categoryRepository.SaveInfo(_category);
        }

        public bool Update(Category _category)
        {
            return _categoryRepository.Update(_category);
        }
    }
}
