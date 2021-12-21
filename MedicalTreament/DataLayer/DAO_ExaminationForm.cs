using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataLayer
{
    public class DAO_ExaminationForm
    {
        MedicalTreatmentEntities db;

        private static DAO_ExaminationForm instance;
        private DAO_ExaminationForm()
        {
            db = new MedicalTreatmentEntities();
        }
        public static DAO_ExaminationForm getInstance()
        {
            if (instance == null)
            {
                instance = new DAO_ExaminationForm();
            }
            return instance;
        }

        public int CountExFormToday()
        {
            var list = from examination in db.Set<ExaminationForm>()
                       where DateTime.Compare(examination.Date, DateTime.Now) == 0
                       select new { examination };

            return list.Count();
        }

        public void Add(int ordinal, int patientID, int secretaryID, decimal price, string reason = "")
        {
            ExaminationForm examination = new ExaminationForm()
            {
                Ordinal = ordinal,
                PatientID = patientID,
                SecretaryID = secretaryID,
                Price = price,
                Reason = reason,
                State = "inGP",
                Date = DateTime.Now,
            };

            db.ExaminationForms.Add(examination);
            db.SaveChanges();

        }



    }
}
