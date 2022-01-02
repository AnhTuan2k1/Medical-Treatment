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
    public partial class FormPharmacistPayment : Form
    {
        Guna2Button btn;
        BUS_Patient bus_patient;
        BUS_ExaminationForm bus_examform;
        int parmacistID;
        string patientID;
        public FormPharmacistPayment(Guna2Button btn, int parmacistID, string patientID = "")
        {
            InitializeComponent();
            this.btn = btn;
            bus_patient = new BUS_Patient();
            bus_examform = new BUS_ExaminationForm();
            this.parmacistID = parmacistID;
            this.patientID = patientID;
        }

        private void FormPharmacistPayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            // reset btn
            btn.Image = Properties.Resources.outline_paid_black_24dp;
            btn.FillColor = Color.White;
            btn.ForeColor = Color.Black;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
               
            }
            new FormPharmacist_Bill().ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {

        }

        private void FormPharmacistPayment_Load(object sender, EventArgs e)
        {
            bus_examform.ShowUnPayPatients(ComboBoxPatientName);
            ComboBoxPatientName.DisplayMember = "Name";
            bus_examform.ShowUnPayPatients(ComboBoxPatientID);
            ComboBoxPatientID.DisplayMember = "PatientID";

            ClearPatientInformation();
            if(patientID != "") LoadPatientInfor(patientID);
        }

        private void LoadPatientInfor(string patientID)
        {
            for (int i = 0; i < ComboBoxPatientID.Items.Count; i++)
            {
                string x = ComboBoxPatientID.Items[i].ToString();
                x = x.Split(',')[0].Split('=')[1].Trim();
                if (x == patientID)
                {
                    if (i == 0) 
                    {
                        if (ComboBoxPatientID.Items.Count > 1)
                            ComboBoxPatientID.SelectedIndex = 1;
                        else ComboBoxPatientName_SelectedIndexChanged(new object(), new EventArgs());
                    }
                    ComboBoxPatientID.SelectedIndex = i;

                }
            }
        }

        private void ClearPatientInformation()
        {
            ComboBoxPatientID.Text = "";
            ComboBoxPatientName.Text = "";
            txtDateOfBirth.Text = "";
            txtPhone.Text = "";
        }

        private void ComboBoxPatientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxPatientName.ValueMember = "PatientID";
            ComboBoxPatientID.Text = ComboBoxPatientName.SelectedValue.ToString();

            ComboBoxPatientName.ValueMember = "DateOfBirth";
            txtDateOfBirth.Text = ((DateTime)ComboBoxPatientName.SelectedValue).ToString("MMM dd, yyyy");

            ComboBoxPatientName.ValueMember = "Phone";
            txtPhone.Text = ComboBoxPatientName.SelectedValue.ToString();
        }

        private void ComboBoxPatientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxPatientID.ValueMember = "Name";
            ComboBoxPatientName.Text = ComboBoxPatientID.SelectedValue.ToString();

            ComboBoxPatientName.ValueMember = "DateOfBirth";
            txtDateOfBirth.Text = ((DateTime)ComboBoxPatientName.SelectedValue).ToString("MMM dd, yyyy");

            ComboBoxPatientName.ValueMember = "Phone";
            txtPhone.Text = ComboBoxPatientName.SelectedValue.ToString();
        }

        private bool CheckInput()
        {
            if (ComboBoxPatientID.Text.Length == 0)
            {
                MessageBox.Show("Enter patient ID, please!");
                ComboBoxPatientID.Focus();
                return false;
            }

            if (ComboBoxPatientName.Text.Length == 0)
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
    }
}
