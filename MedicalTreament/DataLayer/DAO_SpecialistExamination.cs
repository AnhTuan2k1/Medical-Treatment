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

        public dynamic GetListSpecialistExamination()
        {
            var list = from specialistExamination in db.Set<SpecialistExamination>()
                       orderby specialistExamination.SpecialExaminationID
                       select new
                       {
                           specialistExamination.Name,
                           specialistExamination.Price
                       };

            return list.ToList();
        }
    }
}
