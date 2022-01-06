using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DAO_SpecialistExaminationResult
    {
        MedicalTreatmentEntities db;

        private static DAO_SpecialistExaminationResult instance;
        private DAO_SpecialistExaminationResult()
        {
            db = new MedicalTreatmentEntities();
        }
        public static DAO_SpecialistExaminationResult getInstance()
        {
            if (instance == null)
            {
                instance = new DAO_SpecialistExaminationResult();
            }
            return instance;
        }

        public void Add(string result, string conclusion, int idSE, int idPatient, int idSP)
        {
            SpecialistExaminationResult SEresult = new SpecialistExaminationResult()
            {
                Date = DateTime.Now,
                Result = result,
                Conclusion = conclusion,
                SpecialExaminationID = idSE,
                PatientID = idPatient,
                SpecialistID = idSP
                
            };

            db.SpecialistExaminationResults.Add(SEresult);
            db.SaveChanges();

        }

        public dynamic Get(int idPatient)
        {
            var list = from result in db.Set<SpecialistExaminationResult>()
                       join see in db.Set<SpecialistExamination>()
                       on result.SpecialExaminationID equals see.SpecialExaminationID

                       where result.PatientID.Equals(idPatient)
                       && result.Date.Day == DateTime.Now.Day
                       && result.Date.Month == DateTime.Now.Month
                       select new
                       {
                           see.Name,
                           Price = (int)see.Price,
                           see.SpecialExaminationID
                       };

            int x = list.ToList().Count;

            return list.ToList();
        }
    }
}
