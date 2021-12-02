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

namespace MedicalTreament
{
    public partial class FormSecretary : Form
    {
        public FormSecretary()
        {
            InitializeComponent();
        }

        private void FormSecretary_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);

            FormSecretaryPatientList overview = new FormSecretaryPatientList(btnPatients)
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            PanelContainer.Controls.Add(overview);
            overview.Show();
        }

        private void btn_click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            Form form = null;

            switch (btn.Name)
            {
                case "btnReception":
                    form = new FormSecretaryReception(btn);
                    btn.Image = Properties.Resources.baseline_receipt_white_24dp;
                    break;

                case "btnPatients":
                    form = new FormSecretaryPatientList(btn);
                    btn.Image = Properties.Resources.baseline_groups_white_24dp;
                    break;

                case "btnLogout":

                    break;

                default:
                    break;
            }

            btn_click_change(form, btn);
        }

        private void btn_click_change(Form form, Guna2Button btn)
        {
            if (form == null) return;

            // change state button into state clicked.          
            btn.FillColor = Color.FromArgb(116, 185, 255);
            btn.ForeColor = Color.White;

            //change Form                     
            ((Form)PanelContainer.Controls[0]).Close();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            PanelContainer.Controls.Add(form);
            form.Show();


        }
    }
}
