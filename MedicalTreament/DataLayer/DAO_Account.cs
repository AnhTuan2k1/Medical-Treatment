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
        public dynamic GetAccount()
        {
            var list = from accounts in db.Set<Account>()
                       orderby accounts.AccountID
                       select new
                       {
                           accounts.AccountID,
                           accounts.Username,
                           accounts.Password,
                           accounts.type,
                           accounts.EmployeeID
                       };

            return list.ToList();
        }

        public void AddAccount(string username, string password, string type, int employeeid)
        {
            Account account = new Account()
            {
                Username = username,
                Password = password,
                type = type,
                EmployeeID = employeeid
            };

            db.Accounts.Add(account);
            db.SaveChanges();

        }
        public void EditAccount(int accountid, string username, string password, string type, int employeeid)
        {
            Account account = db.Accounts.Find(accountid);
            account.Username = username;
            account.Password = password;
            account.type = type;
            account.EmployeeID = employeeid;

            db.SaveChanges();
        }
        public void DeleteAccount(int accountid)
        {
            Account account = db.Accounts.Find(accountid);
            db.Accounts.Remove(account);
            db.SaveChanges();
        }
        public string GetAccUsername(int employeeid)
        {
            Account account = db.Accounts.Where(ac => ac.EmployeeID == employeeid).Single();
            return account.Username;
        }
        public string GetAccPassword(int employeeid)
        {
            Account account = db.Accounts.Where(ac => ac.EmployeeID == employeeid).Single();
            return account.Password;
        }
    }
}
