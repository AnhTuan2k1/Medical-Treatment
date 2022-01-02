using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalTreament
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        //When click Dashboard button!!
        private void btDashboard_Click(object sender, EventArgs e)
        {
            btDashboard.FillColor = Color.DodgerBlue;
            btDashboard.ForeColor = Color.White;
            btEmployees.FillColor = Color.White;
            btEmployees.ForeColor = Color.Black;
            btCustomers.FillColor = Color.White;
            btCustomers.ForeColor = Color.Black;
            btStorage.FillColor = Color.White;
            btStorage.ForeColor = Color.Black;
            btRevenue.FillColor = Color.White;
            btRevenue.ForeColor = Color.Black;
            //Show Dashbroad Form
            AdminForm.DashboardForm dashboardForm = new AdminForm.DashboardForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(dashboardForm);
            dashboardForm.Show();
        }
        //When click Employees button!!
        private void btEmployees_Click(object sender, EventArgs e)
        {
            btEmployees.FillColor = Color.DodgerBlue;
            btEmployees.ForeColor = Color.White;
            btDashboard.FillColor = Color.White;
            btDashboard.ForeColor = Color.Black;
            btCustomers.FillColor = Color.White;
            btCustomers.ForeColor = Color.Black;
            btStorage.FillColor = Color.White;
            btStorage.ForeColor = Color.Black;
            btRevenue.FillColor = Color.White;
            btRevenue.ForeColor = Color.Black;
            //Show Employees Form
            AdminForm.EmployeesForm employeesForm = new AdminForm.EmployeesForm()
            {
                Dock = DockStyle.Fill, TopLevel = false, TopMost = true
            };
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(employeesForm);
            employeesForm.Show();
        }
        //When click Customers button!!
        private void btCustomers_Click(object sender, EventArgs e)
        {
            btCustomers.FillColor = Color.DodgerBlue;
            btCustomers.ForeColor = Color.White;
            btDashboard.FillColor = Color.White;
            btDashboard.ForeColor = Color.Black;
            btEmployees.FillColor = Color.White;
            btEmployees.ForeColor = Color.Black;
            btStorage.FillColor = Color.White;
            btStorage.ForeColor = Color.Black;
            btRevenue.FillColor = Color.White;
            btRevenue.ForeColor = Color.Black;
            //Show Customers Form
            AdminForm.CustomersForm customersForm = new AdminForm.CustomersForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(customersForm);
            customersForm.Show();
        }
        //When click Storage button!!
        private void btStorage_Click(object sender, EventArgs e)
        {
            btStorage.FillColor = Color.DodgerBlue;
            btStorage.ForeColor = Color.White;
            btDashboard.FillColor = Color.White;
            btDashboard.ForeColor = Color.Black;
            btEmployees.FillColor = Color.White;
            btEmployees.ForeColor = Color.Black;
            btCustomers.FillColor = Color.White;
            btCustomers.ForeColor = Color.Black;
            btRevenue.FillColor = Color.White;
            btRevenue.ForeColor = Color.Black;
            //Show Storage Form
            AdminForm.StorageForm storageForm = new AdminForm.StorageForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(storageForm);
            storageForm.Show();
        }
        //When click Revenue button!!
        private void btRevenue_Click(object sender, EventArgs e)
        {
            btRevenue.FillColor = Color.DodgerBlue;
            btRevenue.ForeColor = Color.White;
            btDashboard.FillColor = Color.White;
            btDashboard.ForeColor = Color.Black;
            btEmployees.FillColor = Color.White;
            btEmployees.ForeColor = Color.Black;
            btCustomers.FillColor = Color.White;
            btCustomers.ForeColor = Color.Black;
            btStorage.FillColor = Color.White;
            btStorage.ForeColor = Color.Black;
            //Show Renevue Form
            AdminForm.RevenueForm revenueForm = new AdminForm.RevenueForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(revenueForm);
            revenueForm.Show();
        }
        //When click Logout button!!
        private void btLogout_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("You want to log out ?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (d == DialogResult.OK )
            {
                this.Hide();
                LoginForm lgf = new LoginForm();
                lgf.ShowDialog();            
            }
            else{}
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            //Show Dashbroad Form
            AdminForm.DashboardForm dashboardForm = new AdminForm.DashboardForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(dashboardForm);
            dashboardForm.Show();
        }
    }
}
