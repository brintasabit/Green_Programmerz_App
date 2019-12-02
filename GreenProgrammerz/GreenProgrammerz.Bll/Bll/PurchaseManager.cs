using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenProgrammerz.Model.Model;
using GreenProgrammerz.Repository.Repository;

namespace GreenProgrammerz.Bll.Bll
{
    public class PurchaseManager
    {
        PurchaseRepository _purchaseRepository=new PurchaseRepository();
        public bool SaveInfo(PurchaseDetails _purchaseDetails)
        {
            return _purchaseRepository.SaveInfo(_purchaseDetails);
        }
    }
}
