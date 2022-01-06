using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataLayer
{
    public class DAO_DrugInvoiceDetail
    {
        MedicalTreatmentEntities db;

        private static DAO_DrugInvoiceDetail instance;
        private DAO_DrugInvoiceDetail()
        {
            db = new MedicalTreatmentEntities();
        }
        public static DAO_DrugInvoiceDetail getInstance()
        {
            if (instance == null)
            {
                instance = new DAO_DrugInvoiceDetail();
            }
            return instance;
        }

        public void Add(int quantity, int invoiceID, int drugID)
        {
            DrugInvoiceDetail drugdetail = new DrugInvoiceDetail()
            {
                Quantity = quantity,
                InvoiceID = invoiceID,
                DrugID = drugID
            };

            db.DrugInvoiceDetails.Add(drugdetail);
            db.SaveChanges();
            updateDrug(quantity, drugID);
        }

        public void updateDrug(int quantity, int drugID)
        {
            Drug drug = db.Drugs.Find(drugID);
            drug.Quantity -= quantity;

            db.SaveChanges();
        }

    }


}
