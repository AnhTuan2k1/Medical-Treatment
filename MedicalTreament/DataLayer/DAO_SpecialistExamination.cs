using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataLayer
{
    public class DAO_SpecialistExamination
    {
        MedicalTreatmentEntities db;

        private static DAO_SpecialistExamination instance;
        private DAO_SpecialistExamination()
        {
            db = new MedicalTreatmentEntities();
        }
        public static DAO_SpecialistExamination getInstance()
        {
            if (instance == null)
            {
                instance = new DAO_SpecialistExamination();
            }
            return instance;
        }

        public void Add(string name, string price)
        {
            decimal d = decimal.Parse(price);
            SpecialistExamination specialistExamination = new SpecialistExamination()
            {
                Name = name,
                Price = d
            };
            db.SpecialistExaminations.Add(specialistExamination);
            db.SaveChanges();
        }

        public void Remove(int id)
        {
            SpecialistExamination specialistExamination = db.SpecialistExaminations.Find(id);
            db.SpecialistExaminations.Remove(specialistExamination);
            db.SaveChanges();
        }

        public dynamic GetListSpecialistExamination()
        {
            var list = from specialistExamination in db.Set<SpecialistExamination>()
                       orderby specialistExamination.SpecialExaminationID
                       select new
                       {
                           specialistExamination.SpecialExaminationID,
                           specialistExamination.Name,
                           specialistExamination.Price
                       };

            return list.ToList();
        }

        public void Edit(int id,string name, string price)
        {
            decimal d = decimal.Parse(price);
            SpecialistExamination specialistExamination = db.SpecialistExaminations.Find(id);
            specialistExamination.Name = name;
            specialistExamination.Price = d;

            db.SaveChanges();
        }

        public int GetID(string a)
        {
            SpecialistExamination se = db.SpecialistExaminations.Where(s => s.Name == a).Single();
            return se.SpecialExaminationID;
        }
    }
}
