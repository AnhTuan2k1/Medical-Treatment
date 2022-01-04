using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataLayer
{
    public class DAO_SpecialistExaminationRequest
    {
        MedicalTreatmentEntities db;
        private static DAO_SpecialistExaminationRequest instance;
        private DAO_SpecialistExaminationRequest()
        {
            db = new MedicalTreatmentEntities();
        }
        public static DAO_SpecialistExaminationRequest getInstance()
        {
            if (instance == null)
            {
                instance = new DAO_SpecialistExaminationRequest();
            }
            return instance;
        }

        public void Add(int idSE, int idPatient, int idGP)
        {
            SpecialistExaminationRequest SErequest = new SpecialistExaminationRequest()
            {
                SpecialExaminationID = idSE,
                PatientID = idPatient,
                GPID = idGP,
                Date = DateTime.Now
            };
            db.SpecialistExaminationRequests.Add(SErequest);
            db.SaveChanges();
        }

        public dynamic ShowSErequest(int idPatient)
        {
            var list = from serequest in db.Set<SpecialistExaminationRequest>()
                       join see in db.Set<SpecialistExamination>()
                       on serequest.SpecialExaminationID equals see.SpecialExaminationID
                       where serequest.PatientID.Equals(idPatient)
                       select new
                       {
                           see.Name
                       };

            return list.ToList();
        }
    }
}
