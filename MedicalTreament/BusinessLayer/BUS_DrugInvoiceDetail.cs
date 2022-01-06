using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class BUS_DrugInvoiceDetail
    {
        DAO_DrugInvoiceDetail daoDrugDetail;

        public BUS_DrugInvoiceDetail()
        {
            daoDrugDetail = DAO_DrugInvoiceDetail.getInstance();
        }

        public void Add(int quantity, int invoiceID, int drugID)
        {
            daoDrugDetail.Add(quantity, invoiceID, drugID);
        }
    }
}
