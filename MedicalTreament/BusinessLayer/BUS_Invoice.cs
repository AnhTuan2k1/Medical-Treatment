using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace BusinessLayer
{
    public class BUS_Invoice
    {
        DAO_Invoice daoInvoice;

        public BUS_Invoice()
        {
            daoInvoice = DAO_Invoice.getInstance();
        }
        public void ShowVisitorHistory(DataGridView dgv)
        {
            dgv.DataSource = daoInvoice.GetVisitorHistory();
        }
        public void ShowIncomeByYear(DataGridView dgv, int year)
        {
            dgv.DataSource = daoInvoice.GetIncomeByYear(year);
        }
        public void ShowEmployeePaymentByYear(DataGridView dgv, int year)
        {
            dgv.DataSource = daoInvoice.GetEmployeePaymentByYear(year);
        }
        public void ShowDrugPaymentByYear(DataGridView dgv, int year)
        {
            dgv.DataSource = daoInvoice.GetDrugPaymentByYear(year);
        }
        public decimal ShowTotalPrice()
        {
            return daoInvoice.GetTotalPrice();
        }
        public decimal ShowTotalDrugPaymentByYear(int year)
        {
            return daoInvoice.GetTotalDrugPaymentByYear(year);
        }
        public decimal ShowTotalIncomeByYear(int year)
        {
            return daoInvoice.GetTotalIncomeByYear(year);
        }
        public decimal ShowTotalEmployeePaymentByYear(int year)
        {
            return daoInvoice.GetTotalEmployeePaymentByYear(year);
        }
        public decimal ShowJan(int year)
        {
            return daoInvoice.GetJan(year);
        }
        public decimal ShowFeb(int year)
        {
            return daoInvoice.GetFeb(year);
        }
        public decimal ShowMar(int year)
        {
            return daoInvoice.GetMar(year);
        }

        public void Add(decimal total, int patientID, int pharmacistID)
        {
            daoInvoice.Add(total, patientID, pharmacistID);
        }

        public int GetID(int patientID)
        {
            try
            {
                return daoInvoice.GetID(patientID);
            }
            catch (Exception)
            {

                return -1;
            }
        }

        public decimal ShowApr(int year)
        {
            return daoInvoice.GetApr(year);
        }
        public decimal ShowMay(int year)
        {
            return daoInvoice.GetMay(year);
        }
        public decimal ShowJun(int year)
        {
            return daoInvoice.GetJun(year);
        }
        public decimal ShowJul(int year)
        {
            return daoInvoice.GetJul(year);
        }
        public decimal ShowAug(int year)
        {
            return daoInvoice.GetAug(year);
        }
        public decimal ShowSep(int year)
        {
            return daoInvoice.GetSep(year);
        }
        public decimal ShowOct(int year)
        {
            return daoInvoice.GetOct(year);
        }
        public decimal ShowNov(int year)
        {
            return daoInvoice.GetNov(year);
        }
        public decimal ShowDec(int year)
        {
            return daoInvoice.GetDec(year);
        }
    }
}
