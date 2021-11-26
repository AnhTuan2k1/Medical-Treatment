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
    public partial class FormPharmacistPayment : Form
    {
        Guna2Button btn;
        public FormPharmacistPayment(Guna2Button btn)
        {
            InitializeComponent();
            this.btn = btn;
        }

        private void FormPharmacistPayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            // reset btn
            btn.Image = Properties.Resources.outline_paid_black_24dp;
            btn.FillColor = Color.White;
            btn.ForeColor = Color.Black;
        }
    }
}
