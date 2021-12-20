using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataLayer
{
    public class DAO_Employee
    {
        MedicalTreatmentEntities db;

        private static DAO_Employee instance;
        private DAO_Employee()
        {
            db = new MedicalTreatmentEntities();
        }
        public static DAO_Employee getInstance()
        {
            if (instance == null)
            {
                instance = new DAO_Employee();
            }
            return instance;
        }


        public dynamic GetGP()
        {
            var list = from GP in db.Set<Employee>()
                       where GP.Position == "GP" 
                       select new
                       {
                           GP.EmployeeID,
                           GP.Name,
                           GP.Position,
                           GP.Salary,
                           GP.Email
                       };

            return list.ToList();
        }
    }
}
