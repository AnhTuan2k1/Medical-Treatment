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
        public FormPharmacistPatient(Guna2Button btn)
        {
            InitializeComponent();
            this.btn = btn;
            bus_exam = new BUS_ExaminationForm();
        }

        private void FormPharmacistOverview_FormClosed(object sender, FormClosedEventArgs e)
        {
            btn.Image = Properties.Resources.baseline_dashboard_black_24dp;
            btn.FillColor = Color.White;
            btn.ForeColor = Color.Black;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }

        private void FormPharmacistPatient_Load(object sender, EventArgs e)
        {
            bus_exam.ShowUnPayPatients(dgv);
            dgv.Columns["HealthInsuarance"].Width = (int)(dgv.Width * 0.22);
        }
    }
}
