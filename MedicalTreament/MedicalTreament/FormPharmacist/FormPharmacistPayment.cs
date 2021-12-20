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
    public partial class FormPharmacistPayment : Form
    {
        Guna2Button btn;
        BUS_Patient bus_patient;
        public FormPharmacistPayment(Guna2Button btn)
        {
            InitializeComponent();
            this.btn = btn;
            bus_patient = new BUS_Patient();
        }

        private void FormPharmacistPayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            // reset btn
            btn.Image = Properties.Resources.outline_paid_black_24dp;
            btn.FillColor = Color.White;
            btn.ForeColor = Color.Black;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            new FormPharmacist_Bill().ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {

        }

        private void FormPharmacistPayment_Load(object sender, EventArgs e)
        {
            bus_patient.ShowUnPayPatients(ComboBoxParientName);
        }
    }
}
