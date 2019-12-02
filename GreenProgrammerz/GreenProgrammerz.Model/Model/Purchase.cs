using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenProgrammerz.Model.Model
{
    public class Purchase
    {
        public Purchase()
        {
            PurchaseDetailses=new List<PurchaseDetails>();
        }
        public int Id { get; set; }
        public string Date { get; set; }
        public string BillInvoiceNo { get; set; }
        public string SupplierName { get; set; }

        public List<PurchaseDetails>PurchaseDetailses { get; set; }
    }
}
