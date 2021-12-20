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
using Guna.UI2.WinForms;

namespace MedicalTreament
{
    public partial class FormSecretaryReception : Form
    {
        Guna2Button btn;
        BUS_Patient bus_patient;
        public FormSecretaryReception(Guna2Button button)
        {
            InitializeComponent();
            btn = button;
            bus_patient = new BUS_Patient();
        }

        private void FormSecretaryReception_FormClosed(object sender, FormClosedEventArgs e)
        {
            btn.Image = Properties.Resources.outline_receipt_black_24dp;
            btn.FillColor = Color.White;
            btn.ForeColor = Color.Black;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void FormSecretaryReception_Load(object sender, EventArgs e)
        {
            txtExaminationDate.Text = DateTime.Now.ToString("MMM/dd/yyyy");

            bus_patient.ShowPatients(ComboBoxPatientName);
            bus_patient.ShowPatients(ComboBoxPatientID);

            ComboBoxPatientName.DisplayMember = "Name";
            ComboBoxPatientID.DisplayMember = "PatientID";
            ClearPatientInformation();
        }

        void ClearPatientInformation()
        {
            ComboBoxPatientID.Text = "";
            ComboBoxPatientName.Text = "";
            txtDateOfBirth.Text = "";
            txtPhone.Text = "";
            txtHealthInsuarance.Text = "";
            RadioBtnFemale.Checked = false;
            RadioBtnMale.Checked = false;
        }

        private void ComboBoxPatientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxPatientName.ValueMember = "PatientID";
            ComboBoxPatientID.Text = ComboBoxPatientName.SelectedValue.ToString();

            ComboBoxPatientName.ValueMember = "HealthInsuarance";
            txtHealthInsuarance.Text = ComboBoxPatientName.SelectedValue.ToString();

            ComboBoxPatientName.ValueMember = "DateOfBirth";
            txtDateOfBirth.Text = ((DateTime)ComboBoxPatientName.SelectedValue).ToString("MMM dd, yyyy");

            ComboBoxPatientName.ValueMember = "Phone";
            txtPhone.Text = ComboBoxPatientName.SelectedValue.ToString();

            ComboBoxPatientName.ValueMember = "Gender";
            if (ComboBoxPatientName.SelectedValue.ToString().ToLower() == "male")
            {
                RadioBtnMale.Checked = true;
                RadioBtnFemale.Checked = false;
            }
            else
            {
                RadioBtnMale.Checked = false;
                RadioBtnFemale.Checked = true;
            }
        }

        private void ComboBoxPatientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxPatientID.ValueMember = "Name";
            ComboBoxPatientName.Text = ComboBoxPatientID.SelectedValue.ToString();

            ComboBoxPatientID.ValueMember = "HealthInsuarance";
            txtHealthInsuarance.Text = ComboBoxPatientID.SelectedValue.ToString();

            ComboBoxPatientID.ValueMember = "DateOfBirth";
            txtDateOfBirth.Text = ((DateTime)ComboBoxPatientID.SelectedValue).ToString("MMM dd, yyyy");

            ComboBoxPatientID.ValueMember = "Phone";
            txtPhone.Text = ComboBoxPatientID.SelectedValue.ToString();

            ComboBoxPatientID.ValueMember = "Gender";
            if (ComboBoxPatientID.SelectedValue.ToString().ToLower() == "male")
            {
                RadioBtnMale.Checked = true;
                RadioBtnFemale.Checked = false;
            }
            else
            {
                RadioBtnMale.Checked = false;
                RadioBtnFemale.Checked = true;
            }
        }
    }
}
