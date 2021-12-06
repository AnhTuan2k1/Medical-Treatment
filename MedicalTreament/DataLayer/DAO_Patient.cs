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

        public DAO_Patient()
        {
            db = new MedicalTreatmentEntities();
        }

        public dynamic GetPatients()
        {
            var list = db.Patients.Select(p => new
            {
                p.Name,
                p.Phone,
                p.Gender,
                p.DateOfBirth
            }).ToList();

            return list;
        }
    }
}
