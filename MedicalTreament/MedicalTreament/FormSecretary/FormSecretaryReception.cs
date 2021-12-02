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
    public partial class FormSecretaryReception : Form
    {
        Guna2Button btn;
        public FormSecretaryReception(Guna2Button button)
        {
            InitializeComponent();
            btn = button;
        }

        private void FormSecretaryReception_FormClosed(object sender, FormClosedEventArgs e)
        {
            btn.Image = Properties.Resources.outline_receipt_black_24dp;
            btn.FillColor = Color.White;
            btn.ForeColor = Color.Black;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
