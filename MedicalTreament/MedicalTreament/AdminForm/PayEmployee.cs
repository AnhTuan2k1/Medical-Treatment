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
    public partial class PayEmployee : Form
    {
        BUS_Employee bUS_Employee;
        DataGridView dgv;
        DataGridViewRow row;
        public PayEmployee(DataGridView datagv, DataGridViewRow row = null)
        {
            InitializeComponent();
            bUS_Employee = new BUS_Employee();
            dgv = datagv;
            this.row = row;
            if (row == null) btPay.Enabled = false;
            else
            {
                SetInput();
            }
        }
        void SetInput()
        {
            txtid.Text = row.Cells["EmployeeID"].Value.ToString();
            txbName.Text = row.Cells["Name"].Value.ToString();
        }
        bool CheckInput()
        {
            if (txbValue.Text.Length == 0)
            {
                MessageBox.Show("Please enter Salary");
                return false;
            }
            return true;
        }
        private void btPay_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                if (bUS_Employee.PayEmployee(decimal.Parse(txbValue.Text),Convert.ToInt32(txtid.Text)))
                {
                    MessageBox.Show("Pay employee successfully");
                }
            }
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
