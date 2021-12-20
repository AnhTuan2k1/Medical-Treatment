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
    }
}
