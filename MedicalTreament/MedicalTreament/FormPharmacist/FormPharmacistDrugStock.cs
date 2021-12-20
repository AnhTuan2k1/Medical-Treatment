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
    public partial class FormPharmacistDrugStock : Form
    {
        Guna2Button btn;
        BUS_Drug bus_drug;
        public FormPharmacistDrugStock(Guna2Button btn)
        {
            InitializeComponent();
            this.btn = btn;
            bus_drug = new BUS_Drug();
        }

        private void FormPharmacistDrugStock_Load(object sender, EventArgs e)
        {
            ShowDrugs();
        }

        private void FormPharmacistDrugStore_FormClosed(object sender, FormClosedEventArgs e)
        {
            btn.Image = Properties.Resources.outline_store_mall_directory_black_24dp;
            btn.FillColor = Color.White;
            btn.ForeColor = Color.Black;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormPharmacistDrugStock_Add formAddDrug = new FormPharmacistDrugStock_Add(dgv);
            formAddDrug.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv.SelectedRows[0];
            FormPharmacistDrugStock_Add formAddDrug = new FormPharmacistDrugStock_Add(dgv, row);
            formAddDrug.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int drugID = Convert.ToInt32(dgv.SelectedRows[0].Cells["DrugID"].Value.ToString());
            string name = dgv.SelectedRows[0].Cells["Name"].Value.ToString();
            string caption = "Do you want to delete " + name + ", id = " + drugID.ToString();

            DialogResult result = MessageBox.Show(caption, "Delete patient", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (bus_drug.Delete(drugID)) // delete drug
                {
                    bus_drug.ShowDrugs(dgv); // update datagirdview if delete successufully.
                }
            }
        }

        private void ShowDrugs()
        {
            bus_drug.ShowDrugs(dgv);
            dgv.Columns["DrugID"].Width = (int)(dgv.Width * 0.1);
            dgv.Columns["Name"].Width = (int)(dgv.Width * 0.12);
            dgv.Columns["Producer"].Width = (int)(dgv.Width * 0.15);

            dgv.Columns["Quantity"].Visible = false;

        }
    }
}
