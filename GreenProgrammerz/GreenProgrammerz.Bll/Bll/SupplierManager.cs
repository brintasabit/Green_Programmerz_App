using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenProgrammerz.Model.Model;
using GreenProgrammerz.Repository.Repository;

namespace GreenProgrammerz.Bll.Bll
{
    public class SupplierManager
    {
        SupplierRepository _supplierRepository=new SupplierRepository();
        public bool SaveInfo(Supplier _supplier)
        {
            return _supplierRepository.SaveInfo(_supplier);
        }

        public bool Update(Supplier _supplier)
        {
            return _supplierRepository.Update(_supplier);
        }
    }
}
