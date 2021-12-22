using BusinessLayer;
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

    public partial class FormGP_Diagnosis : Form
    {
        private Form activeForm;
        private Guna.UI2.WinForms.Guna2Button currtentButton;
        BUS_Patient bus_Patient;
        BUS_SpecialistExamination bUS_SpecialistExamination;
        BUS_ExaminationForm bus_ExForm;
        string SEname;
        int idGP;
        public FormGP_Diagnosis(int id)
        {
            InitializeComponent();
            bUS_SpecialistExamination = new BUS_SpecialistExamination();
            bus_Patient = new BUS_Patient();
            bus_ExForm = new BUS_ExaminationForm();
            this.idGP = id;
        }

        private void comboBoxSEname_SelectedIndexChanged(object sender, EventArgs e)
        {
            SEname = comboBoxSEname.SelectedValue.ToString();
        }

        private void FormGP_Diagnosis_Load(object sender, EventArgs e)
        {
            bus_Patient.ShowPatients(ComboBoxPatientName);
            bUS_SpecialistExamination.ShowSpecialistExamination(comboBoxSEname);
            comboBoxSEname.DisplayMember = "Name";
            ComboBoxPatientName.DisplayMember = "Name";
            //
            int id = bus_Patient.GetPatientID(ComboBoxPatientName.Text, txtPhone.Text);
            //string reason = bus_ExForm.GetReason(id);
            //txtReason.Text = reason;
            //
            label_date.Text = "Date: "+DateTime.Now.ToShortDateString();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            int idPatient = bus_Patient.GetPatientID(ComboBoxPatientName.Text, txtPhone.Text);
            //string reason = bus_ExForm.GetReason(idPatient);
            //txtDirection.Text
            FormGP_Prescription formGP_Prescription = new FormGP_Prescription(idGP,idPatient);
            formGP_Prescription.Show();

        }

        private void ComboBoxPatientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxPatientName.ValueMember = "Phone";
            txtPhone.Text = ComboBoxPatientName.SelectedValue.ToString();
        }
    }
}
