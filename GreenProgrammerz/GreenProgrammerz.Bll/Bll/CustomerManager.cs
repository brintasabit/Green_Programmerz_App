using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenProgrammerz.Repository.Repository;
using GreenProgrammerz.Model.Model;

namespace GreenProgrammerz.Bll.Bll
{
   public class CustomerManager
    {

        CustomerRepository _customerRepository = new CustomerRepository();
        public bool SaveInfo(Customer _customer)
        {
            return _customerRepository.SaveInfo(_customer);
        }

        public bool Update(Customer _customer)
        {
            return _customerRepository.Update(_customer);
        }
    }
}

