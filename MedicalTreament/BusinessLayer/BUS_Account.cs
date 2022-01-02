using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace BusinessLayer
{
    public class BUS_Account
    {
        DAO_Account daoAccount;

        public BUS_Account()
        {
            daoAccount = DAO_Account.getInstance();
        }


        public bool checkAccount(string pass, string username)
        {
            try
            {
                if (daoAccount.CheckAccount(pass, username))
                {
                    return true;
                }
                else return false;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message/* + "\nCan't find account"*/);
                return false;
            }
            
        }

        public bool Get(string pass, string username, ref int employeeID, ref string employeeType)
        {

            try
            {
                daoAccount.Get(pass, username, ref employeeID, ref employeeType);
                return true;
            }
            catch (Exception)
            {
                return false;
            }            
        }
        public bool AddAccount(string username, string password, string type, int employeeid)
        {

            try
            {
                daoAccount.AddAccount(username, password, type, employeeid);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }
        public bool EditAccount(int accountid, string username, string password, string type, int employeeid)
        {

            try
            {
                daoAccount.EditAccount(accountid, username, password, type, employeeid);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool DeleteAccount(int accountid)
        {

            try
            {
                daoAccount.DeleteAccount(accountid);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public string GetAccUsername(int employeeid)
        {
            string username = daoAccount.GetAccUsername(employeeid);
            return username;
        }
        public string GetAccPassword(int employeeid)
        {
            string password = daoAccount.GetAccPassword(employeeid);
            return password;
        }
    }
}
