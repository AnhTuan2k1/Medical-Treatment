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
    public partial class EmployeesForm : Form
    {
        BUS_Employee bUS_Employee;
        BUS_Account bUS_Account;
        public EmployeesForm()
        {
            InitializeComponent();
            bUS_Employee = new BUS_Employee();
            bUS_Account = new BUS_Account();
        }
        private void ShowEmployee()
        {
            dtgvEmployee.DataSource = null;
            bUS_Employee.ShowEmployee(dtgvEmployee);
            dtgvEmployee.Columns["EmployeeID"].Width = (int)(dtgvEmployee.Width * 0.12);
            dtgvEmployee.Columns[1].Width = (int)(dtgvEmployee.Width * 0.12);
            dtgvEmployee.Columns[2].Width = (int)(dtgvEmployee.Width * 0.15);
        }
        private int ShowLength()
        {
            return bUS_Employee.ShowLength();
        }
        private void ShowNewestEmployee()
        {
            dtgvEmployee.DataSource = null;
            bUS_Employee.ShowNewestEmployee(dtgvEmployee);
            dtgvEmployee.Columns["EmployeeID"].Width = (int)(dtgvEmployee.Width * 0.12);
            dtgvEmployee.Columns[1].Width = (int)(dtgvEmployee.Width * 0.12);
            dtgvEmployee.Columns[2].Width = (int)(dtgvEmployee.Width * 0.15);
        }
        private void ShowSalaryOver()
        {
            dtgvEmployee.DataSource = null;
            bUS_Employee.ShowSalaryOver(dtgvEmployee);
            dtgvEmployee.Columns["EmployeeID"].Width = (int)(dtgvEmployee.Width * 0.12);
            dtgvEmployee.Columns[1].Width = (int)(dtgvEmployee.Width * 0.12);
            dtgvEmployee.Columns[2].Width = (int)(dtgvEmployee.Width * 0.15);
        }
        private void ShowSalaryUnder()
        {
            dtgvEmployee.DataSource = null;
            bUS_Employee.ShowSalryUnder(dtgvEmployee);
            dtgvEmployee.Columns["EmployeeID"].Width = (int)(dtgvEmployee.Width * 0.12);
            dtgvEmployee.Columns[1].Width = (int)(dtgvEmployee.Width * 0.12);
            dtgvEmployee.Columns[2].Width = (int)(dtgvEmployee.Width * 0.15);
        }
        private void ShowSearchEmployee(string search)
        {
            dtgvEmployee.DataSource = null;
            bUS_Employee.ShowSearchEmployee(dtgvEmployee,search);
            dtgvEmployee.Columns["EmployeeID"].Width = (int)(dtgvEmployee.Width * 0.12);
            dtgvEmployee.Columns[1].Width = (int)(dtgvEmployee.Width * 0.12);
            dtgvEmployee.Columns[2].Width = (int)(dtgvEmployee.Width * 0.15);
        }
        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            ShowEmployee();
            lbEmployees.Text = ShowLength().ToString();
        }
        //When Click Add Employees Button
        private void btAdd_Click(object sender, EventArgs e)
        {
            NewEmployees newEmployees = new NewEmployees(dtgvEmployee);
            newEmployees.Show();
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dtgvEmployee.SelectedRows[0];
            EditEmployee editEmployee = new EditEmployee(dtgvEmployee,row);
            editEmployee.Show();
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            int employeeID = Convert.ToInt32(dtgvEmployee.SelectedRows[0].Cells["EmployeeID"].Value.ToString());
            string name = dtgvEmployee.SelectedRows[0].Cells["Name"].Value.ToString();
            string caption = "Do you want to delete " + name + ", id = " + employeeID.ToString();

            DialogResult result = MessageBox.Show(caption, "Delete patient", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (bUS_Account.DeleteAccount(employeeID)) // delete 
                {
                    bUS_Employee.DeleteEmployee(employeeID);
                    bUS_Employee.ShowEmployee(dtgvEmployee); // update datagirdview if delete successufully.
                }
            }
        }

        private void cbbSortby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSortby.SelectedIndex == 0)
            {
                ShowEmployee();
            }
            else
            {
                ShowNewestEmployee();
            }
        }

        private void cbbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbFilter.SelectedIndex == 0)
            {
                ShowSalaryOver();
            }
            else
            {
                ShowSalaryUnder();
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            ShowSearchEmployee(txbSearch.Text.ToString());
        }

        private void btRefreshEmployee_Click(object sender, EventArgs e)
        {
            ShowEmployee();
        }

        private void btPay_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dtgvEmployee.SelectedRows[0];
            PayEmployee payEmployee = new PayEmployee(dtgvEmployee, row);
            payEmployee.Show();
        }
    }
}   
    

