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
    public partial class FormSpecialist_Diagnosis : Form
    {

        //private Form form;
        BUS_Patient bus_Patient;
        BUS_SpecialistExaminationRequest bus_SErequest;
        BUS_SpecialistExaminationResult bus_SEresult;
        BUS_SpecialistExamination bus_SE;
        BUS_ExaminationForm bus_exf;
        int idSP;

        public FormSpecialist_Diagnosis(int id)
        {
            InitializeComponent();
            bus_Patient = new BUS_Patient();
            bus_SErequest = new BUS_SpecialistExaminationRequest();
            bus_SEresult = new BUS_SpecialistExaminationResult();
            bus_SE = new BUS_SpecialistExamination();
            bus_exf = new BUS_ExaminationForm();
            this.idSP = id;
        }

        private void FormSpecialist_Diagnosis_Load(object sender, EventArgs e)
        {
            bus_Patient.ShowPatients_SP(comboboxPatient);
            comboboxPatient.DisplayMember = "Name";
            if(comboboxPatient.Text=="")
            {

            }
            else
            {
                int idPatient = bus_Patient.GetPatientIDByName(comboboxPatient.Text);

                bus_SErequest.ShowSErequest(comboboxSEname, idPatient);
                comboboxSEname.DisplayMember = "Name";
                bus_SErequest.ShowSErequest(gridrequestlist, idPatient);
            }
            
            // comboboxPatient.Text
        }

        private void comboboxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxPatient.ValueMember = "Name";
            int idPatient = bus_Patient.GetPatientIDByName(comboboxPatient.SelectedValue.ToString());

            //comboboxPatient.ValueMember = "Phone";
            //txtPhone.Text = comboboxPatient.SelectedValue.ToString();
      
            bus_SErequest.ShowSErequest(gridrequestlist, idPatient);
            bus_SErequest.ShowSErequest(comboboxSEname, idPatient);
            if (gridrequestlist.Rows.Count < 1)
            {
                bus_exf.SetState(idPatient, "inGP");
                bus_Patient.ShowPatients_SP(comboboxPatient);
                comboboxPatient.DisplayMember = "Name";
                int idPatient2 = bus_Patient.GetPatientIDByName(comboboxPatient.SelectedValue.ToString());
                bus_SErequest.ShowSErequest(gridrequestlist, idPatient2);
                bus_SErequest.ShowSErequest(comboboxSEname, idPatient2);

            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            

            if (txtConclusion.Text=="" || txtResult.Text=="")
            {
                MessageBox.Show("Fill up empty space!","Notification",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {

               

                int idPatient = bus_Patient.GetPatientIDByName(comboboxPatient.Text);
                int idSE = bus_SE.GetID(comboboxSEname.Text);
                

           
                if (bus_SEresult.Add(txtResult.Text,txtConclusion.Text,idSE,idPatient,idSP))
                {
                    txtConclusion.Text = "";
                    txtResult.Text = "";
                    MessageBox.Show("Examinate succesfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    bus_SErequest.ShowSErequest(gridrequestlist, idPatient);
                    bus_SErequest.ShowSErequest(comboboxSEname, idPatient);
                }
                if (gridrequestlist.Rows.Count < 1)
                {
                    bus_exf.SetState(idPatient, "inGP");
                    bus_Patient.ShowPatients_SP(comboboxPatient);
                    comboboxPatient.DisplayMember = "Name";
                    int idPatient2 = bus_Patient.GetPatientIDByName(comboboxPatient.SelectedValue.ToString());
                    bus_SErequest.ShowSErequest(gridrequestlist, idPatient2);
                    bus_SErequest.ShowSErequest(comboboxSEname, idPatient2);
                }

            }
        }
    }
}
