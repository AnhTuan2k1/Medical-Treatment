﻿using System;
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
