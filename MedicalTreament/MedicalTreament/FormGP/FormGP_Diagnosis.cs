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
        BUS_SpecialistExaminationRequest bUS_SErequest;
        BUS_ExaminationForm bus_ExForm;
        BUS_DiagnoseResult bus_DiagnoseResult;

        string SEname;
        int idGP;
        public FormGP_Diagnosis(int id)
        {
            InitializeComponent();
            bUS_SpecialistExamination = new BUS_SpecialistExamination();
            bUS_SErequest = new BUS_SpecialistExaminationRequest();
            bus_Patient = new BUS_Patient();
            bus_ExForm = new BUS_ExaminationForm();
            bus_DiagnoseResult = new BUS_DiagnoseResult();
            this.idGP = id;
        }

        private void comboBoxSEname_SelectedIndexChanged(object sender, EventArgs e)
        {
            SEname = comboBoxSEname.SelectedValue.ToString();
        }

        private void FormGP_Diagnosis_Load(object sender, EventArgs e)
        {
            


            bus_Patient.ShowPatients_GP(ComboBoxPatientName);
            bUS_SpecialistExamination.ShowSpecialistExamination(comboBoxSEname);

            comboBoxSEname.DisplayMember = "Name";
            ComboBoxPatientName.DisplayMember = "Name";
            //

       
            //
            label_date.Text = "Date: "+DateTime.Now.ToShortDateString();

            int idPatient = bus_Patient.GetPatientID(ComboBoxPatientName.Text, txtPhone.Text);
            bUS_SErequest.ShowSErequest(gridview_requestlist, idPatient);

            string reason = bus_ExForm.GetReason(idPatient);
            txtReason.Text = reason;
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            
            int idPatient = bus_Patient.GetPatientID(ComboBoxPatientName.Text, txtPhone.Text);
            //string reason = bus_ExForm.GetReason(idPatient);
            //txtDirection.Text

            int idEx = bus_ExForm.GetId(idPatient);
            //MessageBox.Show(idEx.ToString());
            if ((txtDiagnoseResult.Text == "") || (txtDirection.Text == ""))
            {
                MessageBox.Show("Fill up empty space!");
            }
            else
            {
                if(bus_DiagnoseResult.Add(txtDiagnoseResult.Text,txtDirection.Text,idEx,idPatient,idGP))
                {
                    txtDiagnoseResult.Text = "";
                    txtDirection.Text = "";
                    FormGP_Prescription formGP_Prescription = new FormGP_Prescription(idGP, idPatient);
                    formGP_Prescription.Show();
                }   
            }

        

        }

        private void ComboBoxPatientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxPatientName.ValueMember = "Phone";
            txtPhone.Text = ComboBoxPatientName.SelectedValue.ToString();

            
            ComboBoxPatientName.ValueMember = "PatientID";
            //MessageBox.Show(ComboBoxPatientName.SelectedValue.ToString());

            txtReason.Text = bus_ExForm.GetReason(Convert.ToInt32(ComboBoxPatientName.SelectedValue.ToString()));
            ComboBoxPatientName.ValueMember = "Name";
            int idPatient = bus_Patient.GetPatientIDByName(ComboBoxPatientName.SelectedValue.ToString());
            bUS_SErequest.ShowSErequest(gridview_requestlist, idPatient);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string a = comboBoxSEname.Text;

            int idPatient = bus_Patient.GetPatientID(ComboBoxPatientName.Text, txtPhone.Text);
            int idSE = bUS_SpecialistExamination.GetID(a);
            



            
            Boolean found = false;
            foreach (DataGridViewRow row in gridview_requestlist.Rows)
            {
                
                if (row.Cells[0].Value == a)
                {
                        MessageBox.Show("Already Added", "Notification");
                        found = true;
                        break;
                }
                    //else
                    //{
                    //    gridview_requestlist.Rows.Add(a);
                       
                    //}
                }
            if (!found)
            {
                if(bUS_SErequest.Add(idSE, idPatient, idGP))
                {
                    //MessageBox.Show(gridview_requestlist.DataSource.ToString());
                    bUS_SErequest.ShowSErequest(gridview_requestlist, idPatient);
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int idPatient = bus_Patient.GetPatientID(ComboBoxPatientName.Text, txtPhone.Text);
            int idSE = bUS_SpecialistExamination.GetID(comboBoxSEname.Text);

            if (bUS_SErequest.Delete(idPatient,idSE))
            {
                bUS_SErequest.ShowSErequest(gridview_requestlist, idPatient);
            }
        }


    }
}
