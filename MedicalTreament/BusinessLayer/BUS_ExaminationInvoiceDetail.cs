using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class BUS_ExaminationInvoiceDetail
    {
        DAO_ExaminationInvoiceDetail daoExamDetail;

        public BUS_ExaminationInvoiceDetail()
        {
            daoExamDetail = DAO_ExaminationInvoiceDetail.getInstance();
        }

        public void Add(int quantity, int invoiceID, int examID)
        {
            daoExamDetail.Add(quantity, invoiceID, examID);
        }
    }
}
