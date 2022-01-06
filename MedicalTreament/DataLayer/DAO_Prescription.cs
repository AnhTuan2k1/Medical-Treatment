using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DAO_Prescription
    {
        MedicalTreatmentEntities db;

        private static DAO_Prescription instance;
        private DAO_Prescription()
        {
            db = new MedicalTreatmentEntities();
        }
        public static DAO_Prescription getInstance()
        {
            if (instance == null)
            {
                instance = new DAO_Prescription();
            }
            return instance;
        }

        public void AddPrescription(string txtInstruction, int idPatient, int idGP)
        {
            Prescription prescription = new Prescription()
            {
                Date = DateTime.Now,
                DoctorDirection = txtInstruction,
                PatientID = idPatient,
                GPID = idGP
            };
            db.Prescriptions.Add(prescription);
            db.SaveChanges();
        }

        public int GetPrescriptionID(int idGP, int idPatient)
        {
            Prescription prescription = db.Prescriptions.Where(p => p.GPID == idGP && p.PatientID == idPatient).FirstOrDefault();
            return prescription.PrescriptionID;
        }

        public int GetPrescriptionID(int idPatient)
        {
            Prescription prescription = db.Prescriptions.Where(p => 
            p.Date.Day == DateTime.Now.Day
            && p.Date.Month == DateTime.Now.Month
            && p.Date.Year == DateTime.Now.Year
            && p.PatientID == idPatient)
                .Single();

            return prescription.PrescriptionID;
        }

        public string GetDirection(int patientID)
        {
            Prescription prescription = db.Prescriptions.Where(p =>
           p.Date.Day == DateTime.Now.Day
           && p.Date.Month == DateTime.Now.Month
           && p.Date.Year == DateTime.Now.Year
           && p.PatientID == patientID)
               .Single();

            return prescription.DoctorDirection;
        }
    }
}
