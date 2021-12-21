using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using BusinessLayer;

namespace MedicalTreament
{
    public partial class FormSecretaryPatientList : Form
    {
        BUS_Patient bus_patient;
        Guna2Button btn;


        public FormSecretaryPatientList(Guna2Button btn)
        {
            InitializeComponent();
            this.btn = btn;
            bus_patient = new BUS_Patient();
        }

        private void FormSecretaryPatientList_Shown(object sender, EventArgs e)
        {
            ShowPatients();
        }

        private void FormSecretaryPatientList_FormClosed(object sender, FormClosedEventArgs e)
        {
            btn.Image = Properties.Resources.outline_groups_black_24dp;
            btn.FillColor = Color.White;
            btn.ForeColor = Color.Black;
        }

        private void ShowPatients()
        {
            dgvPatients.DataSource = null;
            bus_patient.ShowPatients(dgvPatients);
            dgvPatients.Columns["PatientID"].Width = (int)(dgvPatients.Width * 0.1);
            dgvPatients.Columns[1].Width = (int)(dgvPatients.Width * 0.12);
            dgvPatients.Columns[2].Width = (int)(dgvPatients.Width * 0.15);

            dgvPatients.Columns["Address"].Visible = false;
            dgvPatients.Columns["Nation"].Visible = false;
            dgvPatients.Columns["WorkPlace"].Visible = false;
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            FormSecretaryPatientList_Add formAddPatient = new FormSecretaryPatientList_Add(dgvPatients);
            formAddPatient.ShowDialog();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvPatients.SelectedRows[0];
            FormSecretaryPatientList_Add formAddPatient = new FormSecretaryPatientList_Add(dgvPatients, row);
            formAddPatient.ShowDialog();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int patientID = Convert.ToInt32(dgvPatients.SelectedRows[0].Cells["PatientID"].Value.ToString());
            string name = dgvPatients.SelectedRows[0].Cells["Name"].Value.ToString();
            string caption = "Do you want to delete " + name + ", id = " + patientID.ToString();
            
            DialogResult result = MessageBox.Show(caption, "Delete patient", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (bus_patient.DeletePatient(patientID)) // delete patient
                {
                    bus_patient.ShowPatients(dgvPatients); // update datagirdview if delete successufully.
                }
            }   
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bus_patient.ShowPatients(dgvPatients ,txtSearch.Text);
        }

        private void editPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Edit_Click(sender, e);
        }

        private void deletePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Delete_Click(sender, e);
        }

        private void receptionPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                bus_patient.ShowPatients(dgvPatients, txtSearch.Text);
            }
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            bus_patient.ShowPatients(dgvPatients);
        }
    }
}
