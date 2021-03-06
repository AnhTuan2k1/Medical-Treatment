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
    public partial class FormSpecialist : Form
    {
        BUS_Employee bus_emp;
        private Form activeForm;
        private Guna.UI2.WinForms.Guna2Button currtentButton;
        int specialistID;
        Form parent;
        public FormSpecialist(int id, Form parent)
        {
            InitializeComponent();
            btn_closeform.Visible = false;
            this.specialistID = id;
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
                if (previousbtn.GetType() == typeof(Guna.UI2.WinForms.Guna2Button))
                {
                    previousbtn.BackColor = Color.DarkTurquoise;
                    previousbtn.ForeColor = Color.White;
                    previousbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender, int id)
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

        private void spbtn_patient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSpecialist_Patient(),sender, specialistID);
            spbtn_diagnosis.FillColor = Color.White;
            spbtn_diagnosis.ForeColor = Color.Black;
            guna2Button1.FillColor = Color.White;
            guna2Button1.ForeColor = Color.Black;
            spbtn_patient.FillColor = Color.White;
            spbtn_patient.ForeColor = Color.Black;
            guna2Button3.FillColor = Color.DarkTurquoise;
            guna2Button3.ForeColor = Color.White;
        }

        private void spbtn_diagnosis_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSpecialist_Diagnosis(specialistID), sender, specialistID);
            spbtn_diagnosis.FillColor = Color.DarkTurquoise;
            spbtn_diagnosis.ForeColor = Color.White;
            guna2Button1.FillColor = Color.White;
            guna2Button1.ForeColor = Color.Black;
            spbtn_patient.FillColor = Color.White;
            spbtn_patient.ForeColor = Color.Black;
            guna2Button3.FillColor = Color.White;
            guna2Button3.ForeColor = Color.Black;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSpecialist_Price(specialistID), sender, specialistID);
            spbtn_diagnosis.FillColor = Color.White;
            spbtn_diagnosis.ForeColor = Color.Black;
            guna2Button1.FillColor = Color.DarkTurquoise;
            guna2Button1.ForeColor = Color.White;
            spbtn_patient.FillColor = Color.White;
            spbtn_patient.ForeColor = Color.Black;
            guna2Button3.FillColor = Color.White;
            guna2Button3.ForeColor = Color.Black;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }

        private void FormSpecialist_Load(object sender, EventArgs e)
        {
            gunaLabel1.Text = "Dr. " + bus_emp.GetEmployeeName(specialistID);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            FormGP_Profile profileForm = new FormGP_Profile(specialistID);
            profileForm.Show();
        }
    }
}
