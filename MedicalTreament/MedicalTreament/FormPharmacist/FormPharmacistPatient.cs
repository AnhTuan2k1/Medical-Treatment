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
using Guna.UI2.WinForms;

namespace MedicalTreament
{
    public partial class FormPharmacistPatient : Form
    {
        Guna2Button btn;
        BUS_ExaminationForm bus_exam;
        FormPharmacist container;
        public FormPharmacistPatient(Guna2Button btn, FormPharmacist formPharmacist)
        {
            InitializeComponent();
            this.btn = btn;
            bus_exam = new BUS_ExaminationForm();
            container = formPharmacist;
        }

        private void FormPharmacistOverview_FormClosed(object sender, FormClosedEventArgs e)
        {
            btn.Image = Properties.Resources.baseline_dashboard_black_24dp;
            btn.FillColor = Color.White;
            btn.ForeColor = Color.Black;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows[0].Cells["State"].Value.ToString().ToLower() != "inpharmacist")
                {
                    DialogResult result = MessageBox.Show
                         ("Patient has not finished examination. Do you want to move this patient to payment? ",
                         "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                        container.OpenPayment(dgv.SelectedRows[0].Cells["PatientID"].Value.ToString());
                }
                else container.OpenPayment(dgv.SelectedRows[0].Cells["PatientID"].Value.ToString());

            }
            catch (Exception)
            {

            }
            
        }

        private void FormPharmacistPatient_Load(object sender, EventArgs e)
        {
            bus_exam.ShowUnPayPatients(dgv);
            dgv.Columns["HealthInsuarance"].Width = (int)(dgv.Width * 0.22);
            dgv.Columns["PatientID"].Width = (int)(dgv.Width * 0.08);
            dgv.Columns["Name"].Width = (int)(dgv.Width * 0.15);

            dgv.Columns["DateOfBirth"].Visible = false;
            dgv.Columns["ExaminationFormID"].Visible = false;
            labelNumberPatient.Text = dgv.RowCount.ToString();
        }

        private void payToolStripMenuItem_Click(object sender, EventArgs e)
        {
            container.OpenPayment(dgv.SelectedRows[0].Cells["PatientID"].Value.ToString());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bus_exam.ShowUnPayPatients(dgv, txtSearch.Text);
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            bus_exam.ShowUnPayPatients(dgv);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                bus_exam.ShowUnPayPatients(dgv, txtSearch.Text);
            }
        }
    }
}
