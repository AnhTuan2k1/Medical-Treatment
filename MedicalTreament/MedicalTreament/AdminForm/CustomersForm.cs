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
    public partial class CustomersForm : Form
    {
        BUS_Patient bUS_Patient;
        public CustomersForm()
        {
            InitializeComponent();
            bUS_Patient = new BUS_Patient();
        }

        private void ShowPatients()
        {
            dgvPatients.DataSource = null;
            bUS_Patient.ShowPatients(dgvPatients);
            dgvPatients.Columns["PatientID"].Width = (int)(dgvPatients.Width * 0.1);
            dgvPatients.Columns[1].Width = (int)(dgvPatients.Width * 0.12);
            dgvPatients.Columns[2].Width = (int)(dgvPatients.Width * 0.15);

            dgvPatients.Columns["Address"].Visible = false;
            dgvPatients.Columns["Nation"].Visible = false;
            dgvPatients.Columns["WorkPlace"].Visible = false;
        }
        private void ShowNewestPatients()
        {
            dgvPatients.DataSource = null;
            bUS_Patient.ShowNewstPatients(dgvPatients);
            dgvPatients.Columns["PatientID"].Width = (int)(dgvPatients.Width * 0.1);
            dgvPatients.Columns[1].Width = (int)(dgvPatients.Width * 0.12);
            dgvPatients.Columns[2].Width = (int)(dgvPatients.Width * 0.15);

            dgvPatients.Columns["Address"].Visible = false;
            dgvPatients.Columns["Nation"].Visible = false;
            dgvPatients.Columns["WorkPlace"].Visible = false;
        }
        private void ShowMalePatients(string gender)
        {
            dgvPatients.DataSource = null;
            bUS_Patient.ShowMalePatients(dgvPatients,gender);
            dgvPatients.Columns["PatientID"].Width = (int)(dgvPatients.Width * 0.1);
            dgvPatients.Columns[1].Width = (int)(dgvPatients.Width * 0.12);
            dgvPatients.Columns[2].Width = (int)(dgvPatients.Width * 0.15);

            dgvPatients.Columns["Address"].Visible = false;
            dgvPatients.Columns["Nation"].Visible = false;
            dgvPatients.Columns["WorkPlace"].Visible = false;
        }
        private void ShowFemalePatients(string gender)
        {
            dgvPatients.DataSource = null;
            bUS_Patient.ShowFemalePatients(dgvPatients, gender);
            dgvPatients.Columns["PatientID"].Width = (int)(dgvPatients.Width * 0.1);
            dgvPatients.Columns[1].Width = (int)(dgvPatients.Width * 0.12);
            dgvPatients.Columns[2].Width = (int)(dgvPatients.Width * 0.15);

            dgvPatients.Columns["Address"].Visible = false;
            dgvPatients.Columns["Nation"].Visible = false;
            dgvPatients.Columns["WorkPlace"].Visible = false;
        }
        private void ShowSearchPatients(string search)
        {
            dgvPatients.DataSource = null;
            bUS_Patient.SearchPatients(dgvPatients, search);
            dgvPatients.Columns["PatientID"].Width = (int)(dgvPatients.Width * 0.1);
            dgvPatients.Columns[1].Width = (int)(dgvPatients.Width * 0.12);
            dgvPatients.Columns[2].Width = (int)(dgvPatients.Width * 0.15);

            dgvPatients.Columns["Address"].Visible = false;
            dgvPatients.Columns["Nation"].Visible = false;
            dgvPatients.Columns["WorkPlace"].Visible = false;
        }
        private void ShowPatientInvoice()
        {
            dtgvCustomersByTime.DataSource = null;
            bUS_Patient.ShowPatientInvoice(dtgvCustomersByTime);
            dtgvCustomersByTime.Columns["PatientID"].Width = (int)(dtgvCustomersByTime.Width * 0.1);
        }
        private int ShowLength()
        {
            return bUS_Patient.GetLength();
        }
        private void CustomersForm_Load(object sender, EventArgs e)
        {
            ShowPatients();
            ShowPatientInvoice();
            lbCustomers.Text = ShowLength().ToString();
        }
        private void cbbSortby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSortby.SelectedIndex == 0)
            {
                ShowPatients();
            }
            else
            {
                ShowNewestPatients();              
            }
        }

        private void cbbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbFilter.SelectedIndex == 0)
            {
                ShowMalePatients(cbbFilter.Text.ToLower());
            }
            else
            {
                ShowFemalePatients(cbbFilter.Text.ToLower());
            }
        }

        private void btRefreshAllCustomer_Click(object sender, EventArgs e)
        {
            ShowPatients();
        }

        private void btRefreshVisitorHistory_Click(object sender, EventArgs e)
        {
            ShowPatientInvoice();
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            ShowSearchPatients(txbSearch.Text.ToString());
        }
    }
}
