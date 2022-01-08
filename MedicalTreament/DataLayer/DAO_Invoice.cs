using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataLayer
{
    public class DAO_Invoice
    {
        MedicalTreatmentEntities db;

        private static DAO_Invoice instance;
        private DAO_Invoice()
        {
            db = new MedicalTreatmentEntities();
        }
        public static DAO_Invoice getInstance()
        {
            if (instance == null)
            {
                instance = new DAO_Invoice();
            }
            return instance;
        }
        public dynamic GetIncomeByYear(int year)
        {
            var list = from invoice in db.Set<Invoice>()
                       where invoice.Date.Year == year
                       select new
                       {
                           invoice.InvoiceID,
                           invoice.Date,
                           TotalPrice = (int)invoice.TotalPrice
                       };

            return list.ToList();
        }
        public dynamic GetVisitorHistory()
        {
            var list = from invoice in db.Set<Invoice>()
                       join patient in db.Set<Patient>()
                       on invoice.PatientID equals patient.PatientID
                       orderby invoice.Date descending
                       select new
                       {
                           invoice.PatientID,
                           patient.Name,
                           invoice.Date,
                           TotalPrice = (int)invoice.TotalPrice
                       };

            return list.ToList();
        }
        public decimal GetTotalPrice()
        {
            var list = from invoice in db.Set<Invoice>()
                       select new
                       {
                           invoice.TotalPrice
                       };
            decimal total = 0;
            foreach (var item in list)
            {
                total += decimal.Parse(item.TotalPrice.ToString());
            }
            return total;
        }

        public void Add(decimal total, int patientID, int pharmacistID)
        {

            Invoice invoice = new Invoice()
            {
                Date = DateTime.Now,
                TotalPrice = total,
                PatientID = patientID,
                PharmacistID = pharmacistID
            };

            db.Invoices.Add(invoice);
            db.SaveChanges();
        }

        public int GetID(int patientID)
        {
            var list = from invoice in db.Set<Invoice>()
                       where invoice.PatientID == patientID
                       && invoice.Date.Day == DateTime.Now.Day
                       && invoice.Date.Month == DateTime.Now.Month
                       select new
                       {
                           invoice.InvoiceID
                       };

            return list.ToList()[0].InvoiceID;
        }

        public decimal GetTotalIncomeByYear(int year)
        {
            var list = from invoice in db.Set<Invoice>()
                       where invoice.Date.Year == year
                       select new
                       {
                           invoice.TotalPrice
                       };
            decimal total = 0;
            foreach (var item in list)
            {
                total += decimal.Parse(item.TotalPrice.ToString());
            }
            return total;
        }
        public decimal GetTotalEmployeePaymentByYear(int year)
        {
            var list = from paysalary in db.Set<PaySalary>()
                       where paysalary.Date.Year == year
                       select new
                       {
                           paysalary.Value
                       };
            decimal total = 0;
            foreach (var item in list)
            {
                total += decimal.Parse(item.Value.ToString());
            }
            return total;
        }
        public decimal GetTotalDrugPaymentByYear(int year)
        {
            var list = from drug in db.Set<Drug>()
                       where drug.ImportDate.Year == year
                       select new
                       {
                           drug.Quantity,
                           drug.Price
                       };
            decimal total = 0;
            foreach (var item in list)
            {
                total += (decimal.Parse(item.Quantity.ToString()) * decimal.Parse(item.Price.ToString()));
            }
            return total;
        }
        public dynamic GetEmployeePaymentByYear(int year)
        {
            var list = from paysalary in db.Set<PaySalary>()
                       where paysalary.Date.Year == year
                       select new
                       {
                           paysalary.PaySalaryID,
                           paysalary.Date,
                           Value = (int)paysalary.Value
                       };

            return list.ToList();
        }
        public dynamic GetDrugPaymentByYear(int year)
        {
            var list = from drug in db.Set<Drug>()
                       where drug.ImportDate.Year == year
                       select new
                       {
                           drug.DrugID,
                           drug.ImportDate,
                           drug.Quantity,
                           Price = (int)drug.Price
                       };

            return list.ToList();
        }
        //--Get Total Revenue of Each Month in Selected Year--//
        public decimal GetJan(int year)
        {
            var list = from invoice in db.Set<Invoice>()
                       where invoice.Date.Month == 1 && invoice.Date.Year == year
                       select new
                       {
                           invoice.TotalPrice
                       };
            decimal total = 0;
            foreach (var item in list)
            {
                total += decimal.Parse(item.TotalPrice.ToString());
            }
            return total;
        }
        public decimal GetFeb(int year)
        {
            var list = from invoice in db.Set<Invoice>()
                       where invoice.Date.Month == 2 && invoice.Date.Year == year
                       select new
                       {
                           invoice.TotalPrice
                       };
            decimal total = 0;
            foreach (var item in list)
            {
                total += decimal.Parse(item.TotalPrice.ToString());
            }
            return total;
        }
        public decimal GetMar(int year)
        {
            var list = from invoice in db.Set<Invoice>()
                       where invoice.Date.Month == 3 && invoice.Date.Year == year
                       select new
                       {
                           invoice.TotalPrice
                       };
            decimal total = 0;
            foreach (var item in list)
            {
                total += decimal.Parse(item.TotalPrice.ToString());
            }
            return total;
        }
        public decimal GetApr(int year)
        {
            var list = from invoice in db.Set<Invoice>()
                       where invoice.Date.Month == 4 && invoice.Date.Year == year
                       select new
                       {
                           invoice.TotalPrice
                       };
            decimal total = 0;
            foreach (var item in list)
            {
                total += decimal.Parse(item.TotalPrice.ToString());
            }
            return total;
        }
        public decimal GetMay(int year)
        {
            var list = from invoice in db.Set<Invoice>()
                       where invoice.Date.Month == 5 && invoice.Date.Year == year
                       select new
                       {
                           invoice.TotalPrice
                       };
            decimal total = 0;
            foreach (var item in list)
            {
                total += decimal.Parse(item.TotalPrice.ToString());
            }
            return total;
        }
        public decimal GetJun(int year)
        {
            var list = from invoice in db.Set<Invoice>()
                       where invoice.Date.Month == 6 && invoice.Date.Year == year
                       select new
                       {
                           invoice.TotalPrice
                       };
            decimal total = 0;
            foreach (var item in list)
            {
                total += decimal.Parse(item.TotalPrice.ToString());
            }
            return total;
        }
        public decimal GetJul(int year)
        {
            var list = from invoice in db.Set<Invoice>()
                       where invoice.Date.Month == 7 && invoice.Date.Year == year
                       select new
                       {
                           invoice.TotalPrice
                       };
            decimal total = 0;
            foreach (var item in list)
            {
                total += decimal.Parse(item.TotalPrice.ToString());
            }
            return total;
        }
        public decimal GetAug(int year)
        {
            var list = from invoice in db.Set<Invoice>()
                       where invoice.Date.Month == 8 && invoice.Date.Year == year
                       select new
                       {
                           invoice.TotalPrice
                       };
            decimal total = 0;
            foreach (var item in list)
            {
                total += decimal.Parse(item.TotalPrice.ToString());
            }
            return total;
        }
        public decimal GetSep(int year)
        {
            var list = from invoice in db.Set<Invoice>()
                       where invoice.Date.Month == 9 && invoice.Date.Year == year
                       select new
                       {
                           invoice.TotalPrice
                       };
            decimal total = 0;
            foreach (var item in list)
            {
                total += decimal.Parse(item.TotalPrice.ToString());
            }
            return total;
        }
        public decimal GetOct(int year)
        {
            var list = from invoice in db.Set<Invoice>()
                       where invoice.Date.Month == 10 && invoice.Date.Year == year
                       select new
                       {
                           invoice.TotalPrice
                       };
            decimal total = 0;
            foreach (var item in list)
            {
                total += decimal.Parse(item.TotalPrice.ToString());
            }
            return total;
        }
        public decimal GetNov(int year)
        {
            var list = from invoice in db.Set<Invoice>()
                       where invoice.Date.Month == 11 && invoice.Date.Year == year
                       select new
                       {
                           invoice.TotalPrice
                       };
            decimal total = 0;
            foreach (var item in list)
            {
                total += decimal.Parse(item.TotalPrice.ToString());
            }
            return total;
        }
        public decimal GetDec(int year)
        {
            var list = from invoice in db.Set<Invoice>()
                       where invoice.Date.Month == 12 && invoice.Date.Year == year
                       select new
                       {
                           invoice.TotalPrice
                       };
            decimal total = 0;
            foreach (var item in list)
            {
                total += decimal.Parse(item.TotalPrice.ToString());
            }
            return total;
        }
        //-------//
    }
}