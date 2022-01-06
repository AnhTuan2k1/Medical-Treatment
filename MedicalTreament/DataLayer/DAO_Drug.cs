using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataLayer
{
    public class DAO_Drug
    {
        MedicalTreatmentEntities db;

        private static DAO_Drug instance;

        private DAO_Drug()
        {
            db = new MedicalTreatmentEntities();
        }

        public static DAO_Drug getInstance()
        {
            if (instance == null)
            {
                instance = new DAO_Drug();
            }
            return instance;
        }


        public void Add(string name, decimal price, string producer, int quantity, string type, string unit, DateTime date)
        {
            Drug drug = new Drug()
            {
                Name = name,
                Price = price,
                Producer = producer,
                Quantity = quantity,
                Type = type,
                Unit = unit,
                ExprirationDate = date.Date,
                ImportDate = DateTime.Now
            };

            db.Drugs.Add(drug);

            db.SaveChanges();

        }

        public int GetQuantity(int drugID)
        {
            var list = from drug in db.Set<Drug>()
                       where drug.DrugID == drugID
                       && drug.ExprirationDate > DateTime.Now
                       select new
                       {
                           drug.Quantity
                       };

            return (int)list.ToList()[0].Quantity;
        }

        public void Edit(int id, string name, string producer, DateTime exprirationDate,
            string unit, decimal price, int quantity, string type)
        {
            Drug drug = db.Drugs.Find(id);

            drug.Name = name;
            drug.Producer = producer;
            drug.ExprirationDate = exprirationDate;
            drug.Unit = unit;
            drug.Price = price;
            drug.Quantity = quantity;
            drug.Type = type;

            db.SaveChanges();
        }

        public void Delete(int drugID)
        {
            Drug drug = db.Drugs.Find(drugID);
            db.Drugs.Remove(drug);
            db.SaveChanges();
        }

        public int GetDrugID(string name)
        {
            Drug drug = db.Drugs.Where(d => d.Name == name).Single();
            return drug.DrugID;
        }

        public object GetDrug()
        {
            var list = from drug in db.Set<Drug>()
                       select new
                       {
                           drug.DrugID,
                           drug.Name,
                           drug.Producer,
                           drug.ExprirationDate,
                           drug.Unit,
                           Price = (int)drug.Price,
                           drug.Quantity,
                           drug.Type
                       };

            return list.ToList();

        }

        public object GetDrug(string nameDrug, string option = "all")
        {
            var list = from drug in db.Set<Drug>()
                       where drug.Name.Contains(nameDrug)
                       select new
                       {
                           drug.DrugID,
                           drug.Name,
                           drug.Producer,
                           drug.ExprirationDate,
                           drug.Unit,
                           Price = (int)drug.Price,
                           drug.Quantity,
                           drug.Type
                       };

            switch (option.ToLower())
            {
                case "all":
                    return list.ToList();

                case "expired":
                    return list.Where(drug => drug.ExprirationDate < DateTime.Now).ToList();

                case "soldout":
                    return list.Where(drug => drug.Quantity <= 0).ToList();

                default:
                    return list.ToList();
            }
        }

        public object GetSellableDrugs(string search = "")
        {
            var list = from drug in db.Set<Drug>()
                       where drug.Name.Contains(search)
                       && drug.ExprirationDate > DateTime.Now
                       && drug.Quantity > 0
                       select new
                       {
                           drug.DrugID,
                           drug.Name,
                           drug.Type,
                           drug.ExprirationDate,
                           drug.Unit,
                           Price = (int)drug.Price,
                           drug.Quantity
                          
                       };

            return list.ToList();
        }

        public int GetLength()
        {
            var list = from drug in db.Set<Drug>()
                       select new
                       { };
            int lenght = list.ToList().Count;
            return lenght;
        }

        public object GetNewestDrug()
        {
            var list = from drug in db.Set<Drug>()
                       orderby drug.DrugID descending
                       select new
                       {
                           drug.DrugID,
                           drug.Name,
                           drug.Producer,
                           drug.ExprirationDate,
                           drug.Unit,
                           Price = (int)drug.Price,
                           drug.Quantity,
                           drug.Type
                       };

            return list.ToList();
        }

        public object GetExpiredDrugs()
        {
            var list = from drug in db.Set<Drug>()
                       where drug.ExprirationDate < DateTime.Now
                       select new
                       {
                           drug.DrugID,
                           drug.Name,
                           drug.Producer,
                           drug.ExprirationDate,
                           drug.Unit,
                           Price = (int)drug.Price,
                           drug.Quantity,
                           drug.Type
                       };

            return list.ToList();

        }

        public object GetOralTablet()
        {
            var list = from drug in db.Set<Drug>()
                       where drug.Type == "oral tablet"
                       select new
                       {
                           drug.DrugID,
                           drug.Name,
                           drug.Producer,
                           drug.ExprirationDate,
                           drug.Unit,
                           Price = (int)drug.Price,
                           drug.Quantity,
                           drug.Type
                       };

            return list.ToList();

        }

        public object GetSoldOutDrugs()
        {
            var list = from drug in db.Set<Drug>()
                       where drug.Quantity == 0
                       select new
                       {
                           drug.DrugID,
                           drug.Name,
                           drug.Producer,
                           drug.ExprirationDate,
                           drug.Unit,
                           Price = (int)drug.Price,
                           drug.Quantity,
                           drug.Type
                       };

            return list.ToList();

        }

        public object GetEffervescent()
        {
            var list = from drug in db.Set<Drug>()
                       where drug.Type == "effervescent"
                       select new
                       {
                           drug.DrugID,
                           drug.Name,
                           drug.Producer,
                           drug.ExprirationDate,
                           drug.Unit,
                           Price = (int)drug.Price,
                           drug.Quantity,
                           drug.Type
                       };

            return list.ToList();
        }

        public object GetImport()
        {
            var list = from drug in db.Set<Drug>()
                       select new
                       {
                           drug.Name,
                           drug.Producer,
                           drug.Quantity,
                           drug.ImportDate
                       };

            return list.ToList();
        }

        public object GetExport()
        {
            var list = from druginvoicedetail in db.Set<DrugInvoiceDetail>()
                       join drug in db.Set<Drug>()
                       on druginvoicedetail.DrugID equals drug.DrugID
                       join invoice in db.Set<Invoice>()
                       on druginvoicedetail.InvoiceID equals invoice.InvoiceID
                       select new
                       {
                           drug.Name,
                           drug.Producer,
                           druginvoicedetail.Quantity,
                           invoice.Date
                       };
            return list.ToList();
        }

        public dynamic GetSearchDrug(string search)
        {
            var list = from drug in db.Set<Drug>()
                       where drug.Name.Contains(search)
                       select new
                       {
                           drug.DrugID,
                           drug.Name,
                           drug.Producer,
                           drug.ExprirationDate,
                           drug.Unit,
                           Price = (int)drug.Price,
                           drug.Quantity,
                           drug.Type
                       };

            return list.ToList();
        }
    }
}
