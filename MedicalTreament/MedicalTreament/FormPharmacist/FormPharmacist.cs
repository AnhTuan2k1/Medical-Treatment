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
    public partial class FormPharmacist : Form
    {
        int parmacistID;
        Form parent;

        public FormPharmacist(int employeeID, Form form)
        {
            InitializeComponent();
            parmacistID = employeeID;
            parent = form;
        }

        private void FormPharmacist_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);

            // open form FormPharmacistOverview fist
            FormPharmacistPatient overview = new FormPharmacistPatient(btnPatients, this)
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            PanelContainer.Controls.Add(overview);
            overview.Show();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            Form form = null;

            switch (btn.Name)
            {
                case "btnDrugStore":
                    form = new FormPharmacistDrugStock(btn);
                    btn.Image = Properties.Resources.baseline_store_mall_directory_white_24dp;
                    break;

                case "btnPatients":
                    form = new FormPharmacistPatient(btn , this);
                    btn.Image = Properties.Resources.baseline_dashboard_white_24dp;
                    break;

                case "btnPayment":
                    form = new FormPharmacistPayment(btn, parmacistID);
                    btn.Image = Properties.Resources.baseline_paid_white_24dp;
                    break;
                case "btnLogout":
                    parent.Show();
                    this.Close();
                    break;
 
                default:
                    break;
            }

            btn_click_change(form, btn);

        }

        public void OpenPayment(string patientID)
        {
            Form form = new FormPharmacistPayment(btnPayment, parmacistID, patientID);
            btnPayment.Image = Properties.Resources.baseline_paid_white_24dp;

            btn_click_change(form, btnPayment);
        }

        private void btn_click_change (Form form, Guna2Button btn)
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
