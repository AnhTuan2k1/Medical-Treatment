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
    }
}
