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
    public partial class FormPharmacistDrugStock : Form
    {
        Guna2Button btn;
        public FormPharmacistDrugStock(Guna2Button btn)
        {
            InitializeComponent();
            this.btn = btn;
        }

        private void FormPharmacistDrugStore_FormClosed(object sender, FormClosedEventArgs e)
        {
            btn.Image = Properties.Resources.outline_store_mall_directory_black_24dp;
            btn.FillColor = Color.White;
            btn.ForeColor = Color.Black;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormPharmacistDrugStock_Add formAddDrug = new FormPharmacistDrugStock_Add();
            formAddDrug.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
