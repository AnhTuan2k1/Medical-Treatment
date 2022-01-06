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
                       where !form.State.ToLower().Contains("paid")
                       select new {
                           patient.PatientID,
                           patient.Name,
                           patient.DateOfBirth,
                           patient.HealthInsuarance,
                           patient.Phone,
                           patient.Gender,
                           form.State,
                           form.ExaminationFormID
                       };

            return list.ToList();
        }

        public dynamic GetUnPayPatients(string namePatient)
        {
            var list = from form in db.Set<ExaminationForm>()
                       join patient in db.Set<Patient>()
                       on form.PatientID equals patient.PatientID
                       where !form.State.ToLower().Contains("paid")
                       && patient.Name.Contains(namePatient)
                       select new
                       {
                           patient.PatientID,
                           patient.Name,
                           patient.DateOfBirth,
                           patient.HealthInsuarance,
                           patient.Phone,
                           patient.Gender,
                           form.State
                       };

            return list.ToList();
        }

        public void SetPaid(int patientID)
        {
            ExaminationForm form = db.ExaminationForms.Where(e => 
                e.PatientID == patientID 
                && !e.State.ToLower().Contains("paid")
                ).Single();

            form.State = "paid";
            db.SaveChanges();
        }

        public int GetFee(int patientID)
        {
            var list = from examination in db.Set<ExaminationForm>()
                       where examination.Date.Day == DateTime.Now.Day
                       && examination.Date.Month == DateTime.Now.Month
                       && examination.PatientID == patientID
                       select new { examination.Price };

            if (list.Count() == 0) return 15000;
            else return (int)list.ToList()[0].Price;

        }

        public int GetId(int idPatient)
        {
            ExaminationForm exForm = db.ExaminationForms.Where(e => e.PatientID == idPatient).FirstOrDefault();
            return exForm.ExaminationFormID;
        }

        public dynamic GetPatientsAt(string place = "inGP")
        {
            var list = from form in db.Set<ExaminationForm>()
                       join patient in db.Set<Patient>()
                       on form.PatientID equals patient.PatientID
                       where form.State.Contains(place)
                       select new
                       {
                           patient.PatientID,
                           patient.Name,
                           patient.DateOfBirth,
                           patient.HealthInsuarance,
                           patient.Phone,
                           patient.Gender
                       };

            return list.ToList();
        }

        public string GetReason(int patientID)
        {
            ExaminationForm examinationForm = db.ExaminationForms.Where(e => e.PatientID == patientID).FirstOrDefault();
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
        public void SetState(int idPatient, string text)
        {
            ExaminationForm form = db.ExaminationForms.Find(idPatient);
            form.State = text;
            db.SaveChanges();
        }

    }
}
