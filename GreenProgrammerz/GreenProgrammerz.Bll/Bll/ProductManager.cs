using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenProgrammerz.Model.Model;
using GreenProgrammerz.Repository.Repository;

namespace GreenProgrammerz.Bll.Bll
{
    public class ProductManager
    {
        ProductRepository _productRepository=new ProductRepository();

        public bool SaveInfo(Product _product)
        {
            return _productRepository.SaveInfo(_product);
        }

        public bool Update(Product _product)
        {
            return _productRepository.Update(_product);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetBy(int id)
        {
            return _productRepository.GetBy(id);
        }
    }
}
