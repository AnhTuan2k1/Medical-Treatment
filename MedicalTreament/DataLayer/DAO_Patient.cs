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

        public int GetPatientID(string name, string phone)
        {
            Patient patient = db.Patients.Where(p => p.Name == name && p.Phone == phone).Single();
            return patient.PatientID;
        }

        public object GetPatients(string namePatient)
        {
            var list = from patient in db.Set<Patient>()
                       where patient.Name.Contains(namePatient)
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

  

        public int GetPatientIDByName(string name)
        {
            Patient patient = db.Patients.Where(p => p.Name == name).FirstOrDefault();
            return patient.PatientID;
        }

        public dynamic GetPatients()
        {
            var list = from patient in db.Set<Patient>()
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

        public object SearchPatients_GP(string text)
        {
            var list = from form in db.Set<ExaminationForm>()
                       join patient in db.Set<Patient>()
                       on form.PatientID equals patient.PatientID
                       where form.State.Equals("inGP") && patient.Name.Contains(text)
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

        public dynamic GetPatients_GP()
        {
            var list = from form in db.Set<ExaminationForm>()
                       join patient in db.Set<Patient>()
                       on form.PatientID equals patient.PatientID where (form.State.Equals("inGP") || form.State.Equals("inSP")) 
                       && form.Date.Day == DateTime.Now.Day
                       && form.Date.Month == DateTime.Now.Month
                       select new 
                       {
                           //PatientID = form.PatientID, 
                           // PatientName = patient.Name 
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

        public dynamic GetPatients_SP()
        {
            var list = from patient in db.Set<Patient>()
                       join request in db.Set<SpecialistExaminationRequest>()
                       on patient.PatientID equals request.PatientID
                       join exf in db.Set<ExaminationForm>()
                       on patient.PatientID equals exf.PatientID where exf.State.Equals("inSP") 
                       && exf.Date.Day == DateTime.Now.Day
                       && exf.Date.Month == DateTime.Now.Month
                       group patient by patient.Name into g
                       select new
                       {
                           
                          // PatientID = g.Key,
                           Name = g.Key,
                           count = g.Count()                       
                       };


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

        public bool CheckPatient(string name, int id, string phone)
        {
            Patient patient = db.Patients.Where(p => p.Name == name && p.Phone == phone && p.PatientID == id).Single();
            return true;
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
        public dynamic GetNewestPatients()
        {
            var list = from patient in db.Set<Patient>()
                       orderby patient.PatientID descending
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
        public object GetMalePatients(string gender)
        {
            var list = from patient in db.Set<Patient>()
                       where patient.Gender == gender
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
        public object SearchPatients(string search)
        {
            var list = from patient in db.Set<Patient>()
                       where patient.Name.Contains(search)
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
        public object GetFemalePatients(string gender)
        {
            var list = from patient in db.Set<Patient>()
                       where patient.Gender == gender
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
        public int GetLength()
        {
            var list = from patient in db.Set<Patient>()
                       select new
                       { };
            int length = list.ToList().Count;
            return length;
        }

        public dynamic GetPatientInvoice()
        {
            var list = from patient in db.Set<Patient>()
                       join precription in db.Set<Prescription>()
                       on patient.PatientID equals precription.PatientID
                       orderby precription.Date descending
                       select new
                       {
                           patient.Name,
                           precription.PatientID,
                           patient.HealthInsuarance,
                           precription.Date
                       };

            return list.ToList();
        }
    }
}
