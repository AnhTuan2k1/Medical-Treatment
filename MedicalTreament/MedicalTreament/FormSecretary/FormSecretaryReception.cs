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
using Guna.UI.WinForms;
using Guna.UI2.WinForms;

namespace MedicalTreament
{
    public partial class FormSecretaryReception : Form
    {
        Guna2Button btn;
        BUS_Patient bus_patient;
        BUS_Employee bus_employee;
        BUS_ExaminationForm bus_ExForm;
        int secretaryID;
        string patientID;
        public FormSecretaryReception(Guna2Button button, int idScretary, string patientID = "")
        {
            InitializeComponent();
            btn = button;
            secretaryID = idScretary;
            bus_patient = new BUS_Patient();
            bus_employee = new BUS_Employee();
            bus_ExForm = new BUS_ExaminationForm();
            lbNo.Text = (bus_ExForm.CountExFormToday() + 1).ToString();
            this.patientID = patientID;
        }

        private void FormSecretaryReception_FormClosed(object sender, FormClosedEventArgs e)
        {
            btn.Image = Properties.Resources.outline_receipt_black_24dp;
            btn.FillColor = Color.White;
            btn.ForeColor = Color.Black;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if(CheckInput())
            {
                int ordinal = Convert.ToInt32(lbNo.Text);
                int patientid = Convert.ToInt32(ComboBoxPatientID.Text);
                decimal price = Convert.ToDecimal(txtPrice.Text);

                if(bus_ExForm.IsExaminatinate(patientid))
                {
                    MessageBox.Show("Patient is examinated today!");
                    return;
                }

                if(bus_ExForm.Add(ordinal, patientid, secretaryID, price, txtReason.Text))
                {
                    MessageBox.Show("reception patient successfully");
                    txtReason.Text = "";
                    ClearPatientInformation();
                }
            }
        }

        private void FormSecretaryReception_Load(object sender, EventArgs e)
        {
            txtExaminationDate.Text = DateTime.Now.ToString("MMM/dd/yyyy");

            bus_patient.ShowPatients(ComboBoxPatientName);
            bus_patient.ShowPatients(ComboBoxPatientID);
            bus_employee.ShowGP(comboGPname);
            bus_employee.ShowGP(comboGPid);

            ComboBoxPatientName.DisplayMember = "Name";
            ComboBoxPatientID.DisplayMember = "PatientID";
            comboGPname.DisplayMember = "Name";
            comboGPid.DisplayMember = "EmployeeID";

            ClearPatientInformation();
            if (patientID != "") LoadPatientInfor(patientID);
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

        private void LoadPatientInfor(string patientID)
        {
            for (int i = 0; i < ComboBoxPatientID.Items.Count; i++)
            {
                string x = ComboBoxPatientID.Items[i].ToString();
                x = x.Split(',')[0].Split('=')[1].Trim();
                if (x == patientID)
                {
                    if (i == 0) { ComboBoxPatientID.SelectedIndex = 1; }
                    ComboBoxPatientID.SelectedIndex = i;
                    
                }
            } 
        }

        void ClearPatientInformation()
        {
            ComboBoxPatientID.Text = "";
            ComboBoxPatientName.Text = "";
            comboGPid.Text = "";
            comboGPname.Text = "";
            txtDateOfBirth.Text = "";
            txtPhone.Text = "";
            txtHealthInsuarance.Text = "";
            RadioBtnFemale.Checked = false;
            RadioBtnMale.Checked = false;
        }

        bool CheckInput()
        {
            if(ComboBoxPatientID.Text.Length == 0)
            {
                MessageBox.Show("Enter patient ID, please!");
                ComboBoxPatientID.Focus();
                return false;
            }

            if(ComboBoxPatientName.Text.Length == 0)
            {
                MessageBox.Show("Enter patient name, please!");
                ComboBoxPatientName.Focus();
                return false;
            }

            if (txtPhone.Text.Length == 0)
            {
                MessageBox.Show("Enter phone number, please!");
                txtPhone.Focus();
                return false;
            }

            if (!bus_patient.CheckPatient(ComboBoxPatientName.Text, Convert.ToInt32(ComboBoxPatientID.Text), txtPhone.Text))
            {               
                ComboBoxPatientName.Focus();
                MessageBox.Show("Can't find patient");
                return false;
            }

            return true;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ComboBoxPatientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void comboGPid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
