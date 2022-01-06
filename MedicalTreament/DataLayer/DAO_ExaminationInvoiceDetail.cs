using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataLayer
{
    public class DAO_ExaminationInvoiceDetail
    {
        MedicalTreatmentEntities db;

        private static DAO_ExaminationInvoiceDetail instance;
        private DAO_ExaminationInvoiceDetail()
        {
            db = new MedicalTreatmentEntities();
        }
        public static DAO_ExaminationInvoiceDetail getInstance()
        {
            if (instance == null)
            {
                instance = new DAO_ExaminationInvoiceDetail();
            }
            return instance;
        }

        public void Add(int quantity, int invoiceID, int examID)
        {
            ExaminationInvoiceDetail exam = new ExaminationInvoiceDetail()
            {
                Quantity = quantity,
                InvoiceID = invoiceID,
                SpecialExaminationID = examID
            };

            db.ExaminationInvoiceDetails.Add(exam);
            db.SaveChanges();
        }
    }
}
