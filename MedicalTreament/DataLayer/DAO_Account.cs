using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataLayer
{
    public class DAO_Account
    {
        MedicalTreatmentEntities db;

        private static DAO_Account instance;

        private DAO_Account()
        {
            db = new MedicalTreatmentEntities();
        }

        public static DAO_Account getInstance()
        {
            if (instance == null)
            {
                instance = new DAO_Account();
            }
            return instance;
        }

        public bool CheckAccount(string pass, string username)
        {
            Account account = db.Accounts.Where(ac => ac.Password == pass && ac.Username == username).Single();

            return true;
        }

        public void Get(string pass, string username, ref int employeeID, ref string employeeType)
        {
            Account account = db.Accounts.Where(ac => ac.Password == pass && ac.Username == username).Single();

            employeeID = account.EmployeeID;
            employeeType = account.type;
      
        }
    }
}
