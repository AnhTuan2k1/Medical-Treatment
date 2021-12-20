using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataLayer
{
    public class DAO_Patient
    {
        MedicalTreatmentEntities db;

        private static DAO_Patient instance;
        private DAO_Patient()
        {
            db = new MedicalTreatmentEntities();
        }
        public static DAO_Patient getInstance()
        {
            if (instance == null)
            {
                instance = new DAO_Patient();
            }
            return instance;
        }

        public dynamic GetPatients()
        {
            var list = from patient in db.Set<Patient>()
                       orderby patient.Name
                       select new
                       {
                           patient.PatientID,
                           patient.Name,
                           patient.HealthInsuarance,
                           patient.Phone,
                           patient.Gender,
                           patient.DateOfBirth,
                           patient.Address,
                           patient.Nation,
                           patient.WorkPlace                         
                       };

            return list.ToList();
        }

        public dynamic GetUnPayPatients()
        {
            var list = from form in db.Set<ExaminationForm>()
                       join patient in db.Set<Patient>()
                       on form.PatientID equals patient.PatientID
                       select new { PatientID = form.PatientID, PatientName = patient.Name};

            return list.ToList();
        }

        public void AddPatient(string name, string phone, DateTime birth, string gender = "",
            string address = "", string healthInsurance = "", string nation = "", string workplace = "")
        {
            Patient patient = new Patient()
            {
                Name = name,
                Phone = phone,
                DateOfBirth = birth.Date,
                Gender = gender,
                Address = address,
                HealthInsuarance = healthInsurance,
                Nation = nation,
                WorkPlace = workplace
            };

            db.Patients.Add(patient);
            db.SaveChanges();

        }

        public void EditPatient(int PatientID, string name, string phone, DateTime birth, string gender,
            string address, string healthInsurance, string nation, string workplace)
        {
            Patient patient = db.Patients.Find(PatientID);
            patient.Name = name;
            patient.Phone = phone;
            patient.DateOfBirth = birth;
            patient.Gender = gender;
            patient.Address = address;
            patient.HealthInsuarance = healthInsurance;
            patient.Nation = nation;
            patient.WorkPlace = workplace;

            db.SaveChanges();
        }

        public void DeletePatient(int patientID)
        {
            Patient patient = db.Patients.Find(patientID);
            db.Patients.Remove(patient);
            db.SaveChanges();
        }
    }
}
