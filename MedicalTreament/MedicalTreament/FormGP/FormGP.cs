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
    public partial class FormGP : Form
    {
        private Form activeForm;
        BUS_Employee bus_emp;
        private Guna.UI2.WinForms.Guna2Button currtentButton;
        int gpID;
        Form parent;
        public FormGP(int id, Form parent)
        {
            InitializeComponent();
            btn_closeform.Visible = false;
            this.gpID = id;
            this.parent = parent;
            bus_emp = new BUS_Employee();
        }


        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currtentButton != btnSender)
                {
                    DisableButton();
                    currtentButton = (Guna.UI2.WinForms.Guna2Button)btnSender;
                    currtentButton.BackColor = Color.SteelBlue;
                    currtentButton.ForeColor = Color.Black;
                    currtentButton.Font = new System.Drawing.Font("Segoe UI", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn_closeform.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousbtn in panel1.Controls)
            {
                if (previousbtn.GetType()== typeof(Guna.UI2.WinForms.Guna2Button))
                {
                    previousbtn.BackColor = Color.DarkTurquoise;
                    previousbtn.ForeColor = Color.White;
                    previousbtn.Font =  new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }


        public void OpenChildForm(Form childForm, object btnSender)
        {
        
        if (activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }


        private void FormGP_Load(object sender, EventArgs e)
        {
            gunaLabel1.Text ="Dr. " + bus_emp.GetEmployeeName(gpID);
        }

        private void gpbtn_patient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormGP_Patient(gpID), sender);
            gpbtn_patient.FillColor = Color.DarkTurquoise;
            gpbtn_patient.ForeColor = Color.White;
            gpbtn_diagnosis.FillColor = Color.White;
            gpbtn_diagnosis.ForeColor = Color.Black;
            gpbtn_Logout.FillColor = Color.White;
            gpbtn_Logout.ForeColor = Color.Black;
        }

        private void btn_closeform_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            currtentButton = null;
            btn_closeform.Visible = false;
        }

        private void gpbtn_diagnosis_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormGP_Diagnosis(gpID), sender);
            gpbtn_patient.FillColor = Color.White;
            gpbtn_patient.ForeColor = Color.Black;
            gpbtn_diagnosis.FillColor = Color.DarkTurquoise;
            gpbtn_diagnosis.ForeColor = Color.White;
            gpbtn_Logout.FillColor = Color.White;
            gpbtn_Logout.ForeColor = Color.Black;
        }

        private void gpbtn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }

        private void gpbtn_account_Click(object sender, EventArgs e)
        {
            FormGP_Profile profileForm = new FormGP_Profile(gpID);
            profileForm.Show();
        }
    }
}
