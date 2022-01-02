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

namespace MedicalTreament.AdminForm
{
    public partial class NewEmployees : Form
    {
        BUS_Employee bUS_Employee;
        BUS_Account bUS_Account;
        DataGridView dgv;
        public NewEmployees(DataGridView datagv)
        {
            InitializeComponent();
            bUS_Employee = new BUS_Employee();
            bUS_Account = new BUS_Account();
            dgv = datagv;     
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;

            string username = txbUsername.Text.ToString();
            string password = txbPassword.Text.ToString();
            string name = txbName.Text.ToString();
            string position = cbbPosition.Text.ToString();
            string email = txbEmail.Text.ToString();
            decimal salary = Convert.ToDecimal(txbSalary.Text.ToString());

            if (bUS_Employee.AddEmployee(name, position, email, salary))
            {
                MessageBox.Show("Add employee successfully");
                bUS_Employee.ShowEmployee(dgv);
                if(bUS_Account.AddAccount(username, password, position, bUS_Employee.GetEmployeeID(name, email)))
                {
                    MessageBox.Show("Add account successfully");
                }
                ClearInput();
            }
        }

        bool CheckInput()
        {
            if (txbName.Text.Length == 0)
            {
                MessageBox.Show("Please enter Name");
                return false;
            }
            else if (txbUsername.Text.Length == 0)
            {
                MessageBox.Show("Please enter Username");
                return false;
            }
            else if (txbPassword.Text.Length == 0)
            {
                MessageBox.Show("Please enter Password");
                return false;
            }
            else if (cbbPosition.Text.Length == 0)
            {
                MessageBox.Show("Please select Position");
                return false;
            }
            else if (txbEmail.Text.Length == 0)
            {
                MessageBox.Show("Please enter Email");
                return false;
            }
            else if (txbSalary.Text.Length == 0)
            {
                MessageBox.Show("Please enter Salary");
                return false;
            }

            return true;
        }

        void ClearInput()
        {
            txbUsername.Text = "";
            txbPassword.Text = "";
            txbName.Text = "";
            cbbPosition.Text = "";
            txbEmail.Text = "";
            txbSalary.Text = "";
        }

        private void lbClear_Click(object sender, EventArgs e)
        {
            txbUsername.Clear();
            txbPassword.Clear();
            txbName.Clear();
            cbbPosition.SelectedIndex = -1;
            txbEmail.Clear();
            txbSalary.Clear();
            txbUsername.Focus();
        }
    }
}
