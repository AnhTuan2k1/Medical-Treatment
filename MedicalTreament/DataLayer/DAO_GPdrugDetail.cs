using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DAO_GPdrugDetail
    {
        MedicalTreatmentEntities db;

        private static DAO_GPdrugDetail instance;
        private DAO_GPdrugDetail()
        {
            db = new MedicalTreatmentEntities();
        }
        public static DAO_GPdrugDetail getInstance()
        {
            if (instance == null)
            {
                instance = new DAO_GPdrugDetail();
            }
            return instance;
        }

        public void Adddrugdetail(string drugName, int drugQuantity, int prescriptionID, int idPatient, int idGP)
        {
            GPdrugDetail drugDetail = new GPdrugDetail()
            {
                Quantity = drugQuantity,
                PrescriptionID = prescriptionID,
                PatientID = idPatient,
                GPID = idGP,
                NameDrug = drugName
            };
            db.GPdrugDetails.Add(drugDetail);
            db.SaveChanges();
        }

        public dynamic GetDrugs(int prescriptionID)
        {
            var list = from drugs in db.Set<GPdrugDetail>()
                       where drugs.PrescriptionID == prescriptionID
                       select new
                       {
                           drugs.NameDrug,
                           drugs.Quantity
                       };

            return list.ToList();
        }
    }
}
