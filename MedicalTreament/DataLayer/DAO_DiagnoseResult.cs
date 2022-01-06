using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DAO_DiagnoseResult
    {
        MedicalTreatmentEntities db;

        private static DAO_DiagnoseResult instance;
        private DAO_DiagnoseResult()
        {
            db = new MedicalTreatmentEntities();
        }
        public static DAO_DiagnoseResult getInstance()
        {
            if (instance == null)
            {
                instance = new DAO_DiagnoseResult();
            }
            return instance;
        }

        public void Add(string txtDiagnoseResult, string txtDirection, int idEx, int idPatient, int idGP)
        {
            DiagnoseResult dr = new DiagnoseResult()
            {
                Date = DateTime.Now,
                Result = txtDiagnoseResult,
                Direction = txtDirection,
                ExaminationFormID = idEx,
                PatientID = idPatient,
                GPID = idGP
            };

            db.DiagnoseResults.Add(dr);
            db.SaveChanges();
        }

        public string GetResult(int patientID)
        {
            var list = from result in db.Set<DiagnoseResult>()

                       where result.PatientID.Equals(patientID)
                       && result.Date.Day == DateTime.Now.Day
                       && result.Date.Month == DateTime.Now.Month
                       && result.Date.Year == DateTime.Now.Year
                       select new
                       {
                           result.Result
                       };

            return list.ToList()[0].Result;
        }
    }
}
