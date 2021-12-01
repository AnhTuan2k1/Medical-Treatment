using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalTreament.AdminForm
{
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void txbSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            dtgvEmployee.Rows.Add(3);
            dtgvEmployee.Rows[0].Cells[0].Value = "1";
            dtgvEmployee.Rows[0].Cells[1].Value = "Em Tân";
            dtgvEmployee.Rows[0].Cells[2].Value = "General Doctor";
            dtgvEmployee.Rows[0].Cells[3].Value = "123456789";
            dtgvEmployee.Rows[0].Cells[4].Value = "manhtan12327@gmai.com";
            dtgvEmployee.Rows[0].Cells[5].Value = "20.000.000";
            dtgvEmployee.Rows[1].Cells[0].Value = "2";
            dtgvEmployee.Rows[1].Cells[1].Value = "Em Thái";
            dtgvEmployee.Rows[1].Cells[2].Value = "Pharmarcist";
            dtgvEmployee.Rows[1].Cells[3].Value = "123456789";
            dtgvEmployee.Rows[1].Cells[4].Value = "manhtan12327@gmai.com";
            dtgvEmployee.Rows[1].Cells[5].Value = "20.000.000";
            dtgvEmployee.Rows[2].Cells[0].Value = "3";
            dtgvEmployee.Rows[2].Cells[1].Value = "Em Tuấn";
            dtgvEmployee.Rows[2].Cells[2].Value = "Specialist";
            dtgvEmployee.Rows[2].Cells[3].Value = "123456789";
            dtgvEmployee.Rows[2].Cells[4].Value = "manhtan12327@gmai.com";
            dtgvEmployee.Rows[2].Cells[5].Value = "20.000.000";
        }
        //When Click Add Employees Button
        private void btAdd_Click(object sender, EventArgs e)
        {
            NewEmployees newEmployees = new NewEmployees();
            newEmployees.Show();
        }
    }
}
