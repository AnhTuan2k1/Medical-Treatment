using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace MedicalTreament
{
    public partial class LoginForm : Form
    {
        BUS_Account bus_Acount;
        public LoginForm()
        {
            InitializeComponent();
            txbPassword.PasswordChar = '*';
            bus_Acount = new BUS_Account();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(CheckInput())
            {
                string pass = txbPassword.Text;
                string username = txbUsername.Text;

                int employeeID = -1;
                string employeeType = "";

                if(bus_Acount.checkAccount(pass, username))
                {
                    if (bus_Acount.Get(pass, username, ref employeeID, ref employeeType))
                    {

                        switch(employeeType.ToLower())
                        {
                            case "secretary":
                                new FormSecretary(employeeID, this).Show();
                                this.Hide();
                                break;
                            case "gp":
                                new FormGP(employeeID,this).Show();
                                this.Hide();
                                break;
                            case "specialist":
                                new FormSpecialist(employeeID, this).Show();
                                this.Hide();
                                break;
                            case "pharmacist":
                                new FormPharmacist(employeeID, this).Show();
                                this.Hide();
                                break;
                        }                 
                    }
                }
                
            }

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {
            txbUsername.Clear();
            txbPassword.Clear();
            txbUsername.Focus();
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool CheckInput()
        {
            if (txbPassword.Text.Length == 0)
            {
                MessageBox.Show("Enter Password, please");
                return false;
            }
            if (txbUsername.Text.Length == 0)
            {
                MessageBox.Show("Enter Username, please");
                return false;
            }

            return true;
        }
    }
}
