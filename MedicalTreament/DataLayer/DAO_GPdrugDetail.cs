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
    }
}
