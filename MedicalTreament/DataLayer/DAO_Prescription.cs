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

    }
}
