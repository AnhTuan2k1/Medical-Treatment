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
    public partial class FormGP_Patient : Form
    {
        BUS_Patient bus_Patient;
        int idGP;
        public FormGP_Patient(int id)
        {
            InitializeComponent();
            bus_Patient = new BUS_Patient();
            this.idGP = id;
        }

        private void FormGP_Patient_Load(object sender, EventArgs e)
        {
            bus_Patient.ShowPatients_GP(gridview_patient);
            gridview_patient.Columns["Phone"].Visible = false;
            gridview_patient.Columns["Address"].Visible = false;
            gridview_patient.Columns["HealthInsuarance"].Visible = false;
            gridview_patient.Columns["Gender"].Visible = false;
            gridview_patient.Columns["DateOfBirth"].Visible = false;
            gridview_patient.Columns["Nation"].Visible = false;
            gridview_patient.Columns["WorkPlace"].Visible = false;
            gridview_patient.Columns[0].Width = 100;
        
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {

        }

        private void gppatienttextbox_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                bus_Patient.SearchPatients_GP(gridview_patient, gppatienttextbox_search.Text);
            }
        }
    }
}
