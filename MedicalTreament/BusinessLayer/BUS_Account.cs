﻿using System;
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
                throw;
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
                throw;
            }            
        }
    }
}