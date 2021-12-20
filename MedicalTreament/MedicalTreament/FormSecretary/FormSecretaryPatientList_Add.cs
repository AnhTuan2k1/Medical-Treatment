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

namespace MedicalTreament
{
    public partial class FormSecretaryPatientList_Add : Form
    {
        BUS_Patient bus_Patient;
        DataGridView dgv;
        DataGridViewRow row;

        public FormSecretaryPatientList_Add(DataGridView datagv, DataGridViewRow row = null)
        {
            InitializeComponent();
            bus_Patient = new BUS_Patient();
            dgv = datagv;
            this.row = row;

            if (row == null) btnEdit.Enabled = false;
            else
            {
                btnAdd.Enabled = false;
                SetInput();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;

            string address = txtAddress.Text.ToString();
            string name = txtPatientName.Text.ToString();
            string healthInsuarance = txtHealthInsuarance.Text.ToString();
            string phone = txtPhone.Text.ToString();
            string nation = txtNation.Text.ToString();
            string workplace = txtWorkPlace.Text.ToString();
            DateTime birth = DateTimePickerBirth.Value;

            string male = "male";
            if (RadioBtnFemale.Checked)
                male = "Female";

           if(bus_Patient.AddPatient(name, phone, birth, male, address, healthInsuarance, nation, workplace))
            {
                MessageBox.Show("Add patient successfully");
                bus_Patient.ShowPatients(dgv);
                ClearInput();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(CheckInput())
            {
                string male = "Female";
                if (RadioBtnMale.Checked)
                    male = "male";

               if( bus_Patient.EditPatient(Convert.ToInt32(txtId.Text), txtPatientName.Text, txtPhone.Text, DateTimePickerBirth.Value,
                    male, txtAddress.Text, txtHealthInsuarance.Text, txtNation.Text, txtWorkPlace.Text))
                {
                    MessageBox.Show("Edit patient successfully");
                    bus_Patient.ShowPatients(dgv);
                }
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool CheckInput()
        {
            if(txtPatientName.Text.Length == 0)
            {
                MessageBox.Show("Please enter Name");
                return false;
            }
            else if (txtPhone.Text.Length == 0)
            {
                MessageBox.Show("Please enter Phone");
                return false;
            }

            return true;
        }

        void ClearInput()
        {
            txtAddress.Text = "";
            txtPatientName.Text = "";
            txtHealthInsuarance.Text = "";
            txtPhone.Text = "";
            txtNation.Text = "";
            txtWorkPlace.Text = "";
            RadioBtnFemale.Checked = false;
            RadioBtnMale.Checked = false;
        }

        void SetInput()
        {
            txtId.Text = row.Cells["PatientID"].Value.ToString();
            txtAddress.Text = row.Cells["Address"].Value.ToString();
            txtPatientName.Text = row.Cells["Name"].Value.ToString();
            txtHealthInsuarance.Text = row.Cells["HealthInsuarance"].Value.ToString();
            txtPhone.Text = row.Cells["Phone"].Value.ToString();
            txtNation.Text = row.Cells["Nation"].Value.ToString();
            txtWorkPlace.Text = row.Cells["WorkPlace"].Value.ToString();
            DateTimePickerBirth.Value = (DateTime)row.Cells["DateOfBirth"].Value;

            if (row.Cells["PatientID"].Value.ToString().ToLower() == "male")
                RadioBtnMale.Checked = true;
            else
                RadioBtnFemale.Checked = true;
        }
    }
}
