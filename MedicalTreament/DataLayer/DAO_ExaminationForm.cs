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
                       where examination.Date.Day == DateTime.Now.Day 
                       && examination.Date.Month == DateTime.Now.Month

                       select new { examination };

            return list.Count();
        }

        public bool IsExaminatinate(int patientID)
        {
            var list = from examination in db.Set<ExaminationForm>()
                       where examination.Date.Day == DateTime.Now.Day
                       && examination.Date.Month == DateTime.Now.Month
                       && examination.PatientID == patientID
                       select new { examination };

            if (list.Count() == 0) return false;
            else return true;
        }

        public dynamic GetUnPayPatients()
        {
            var list = from form in db.Set<ExaminationForm>()
                       join patient in db.Set<Patient>()
                       on form.PatientID equals patient.PatientID
                       select new { PatientID = form.PatientID, PatientName = patient.Name };

            return list.ToList();
        }

        public string GetReason(int patientID)
        {
            ExaminationForm examinationForm = db.ExaminationForms.Find(patientID);
            return examinationForm.Reason;
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
