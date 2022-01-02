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
        public partial class EditEmployee : Form
        {
            BUS_Employee bUS_Employee;
            BUS_Account bUS_Account;
            DataGridView dgv;
            DataGridViewRow row;

            public EditEmployee(DataGridView datagv, DataGridViewRow row = null)
            {
                InitializeComponent();
                bUS_Employee = new BUS_Employee();
                bUS_Account = new BUS_Account();
                dgv = datagv;
                this.row = row;
                if (row == null) btEdit.Enabled = false;
                else 
                { 
                    SetInput(); 
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

            void SetInput()
            {
                txtid.Text = row.Cells["EmployeeID"].Value.ToString();
                txbUsername.Text = bUS_Account.GetAccUsername(Convert.ToInt32(row.Cells["EmployeeID"].Value));
                txbPassword.Text = bUS_Account.GetAccPassword(Convert.ToInt32(row.Cells["EmployeeID"].Value));
                txbName.Text = row.Cells["Name"].Value.ToString();
                cbbPosition.Text = row.Cells["Position"].Value.ToString();
                txbEmail.Text = row.Cells["Email"].Value.ToString();
                txbSalary.Text = row.Cells["Salary"].Value.ToString();
            }

        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEdit_Click_1(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                if (bUS_Employee.EditEmployee(Convert.ToInt32(txtid.Text), txbName.Text, cbbPosition.Text, txbEmail.Text, decimal.Parse(txbSalary.Text)))
                {
                    MessageBox.Show("Edit employee successfully");
                    bUS_Employee.ShowEmployee(dgv);
                }
                if (bUS_Account.EditAccount(Convert.ToInt32(txtid.Text), txbUsername.Text, txbPassword.Text, cbbPosition.Text, Convert.ToInt32(txtid.Text)))
                {
                    MessageBox.Show("Edit account successfully");
                }
            }
        }
    }
    
}
