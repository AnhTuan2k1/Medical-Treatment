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
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            dtgvAllCustomers.Rows.Add(3);
            dtgvAllCustomers.Rows[0].Cells[0].Value = "1";
            dtgvAllCustomers.Rows[0].Cells[1].Value = "Em Tân";
            dtgvAllCustomers.Rows[0].Cells[2].Value = "123456789";
            dtgvAllCustomers.Rows[0].Cells[3].Value = "123456789";
            dtgvAllCustomers.Rows[0].Cells[4].Value = "3";
            dtgvAllCustomers.Rows[0].Cells[5].Value = "20.000.000";
            dtgvAllCustomers.Rows[1].Cells[0].Value = "2";
            dtgvAllCustomers.Rows[1].Cells[1].Value = "Em Tân";
            dtgvAllCustomers.Rows[1].Cells[2].Value = "123456789";
            dtgvAllCustomers.Rows[1].Cells[3].Value = "123456789";
            dtgvAllCustomers.Rows[1].Cells[4].Value = "3";
            dtgvAllCustomers.Rows[1].Cells[5].Value = "20.000.000"; 
            dtgvAllCustomers.Rows[2].Cells[0].Value = "3";
            dtgvAllCustomers.Rows[2].Cells[1].Value = "Em Tân";
            dtgvAllCustomers.Rows[2].Cells[2].Value = "123456789";
            dtgvAllCustomers.Rows[2].Cells[3].Value = "123456789";
            dtgvAllCustomers.Rows[2].Cells[4].Value = "3";
            dtgvAllCustomers.Rows[2].Cells[5].Value = "20.000.000";

            dtgvCustomersByTime.Rows.Add(3);
            dtgvCustomersByTime.Rows[0].Cells[0].Value = "1";
            dtgvCustomersByTime.Rows[0].Cells[1].Value = "Em Tân";
            dtgvCustomersByTime.Rows[0].Cells[2].Value = "01/01/1010";
            dtgvCustomersByTime.Rows[0].Cells[3].Value = "01/01/1010";
            dtgvCustomersByTime.Rows[0].Cells[4].Value = "3.000.000";
            dtgvCustomersByTime.Rows[1].Cells[0].Value = "2";
            dtgvCustomersByTime.Rows[1].Cells[1].Value = "Em Tân";
            dtgvCustomersByTime.Rows[1].Cells[2].Value = "01/01/1010";
            dtgvCustomersByTime.Rows[1].Cells[3].Value = "01/01/1010";
            dtgvCustomersByTime.Rows[1].Cells[4].Value = "3.000.000";
            dtgvCustomersByTime.Rows[2].Cells[0].Value = "3";
            dtgvCustomersByTime.Rows[2].Cells[1].Value = "Em Tân";
            dtgvCustomersByTime.Rows[2].Cells[2].Value = "01/01/1010";
            dtgvCustomersByTime.Rows[2].Cells[3].Value = "01/01/1010";
            dtgvCustomersByTime.Rows[2].Cells[4].Value = "3.000.000";
        }
    }
}
