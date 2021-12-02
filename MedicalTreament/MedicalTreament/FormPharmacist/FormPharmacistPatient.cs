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
    public partial class FormPharmacistPatient : Form
    {
        Guna2Button btn;
        public FormPharmacistPatient(Guna2Button btn)
        {
            InitializeComponent();
            this.btn = btn;
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
    }
}
