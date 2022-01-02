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

namespace MedicalTreament
{
    public partial class FormPharmacistDrugStock_Add : Form
    {
        BUS_Drug bus_drug;
        DataGridView dgv;
        DataGridViewRow row;

        public FormPharmacistDrugStock_Add(DataGridView datagv, DataGridViewRow row = null)
        {
            InitializeComponent();
            bus_drug = new BUS_Drug();
            dgv = datagv;
            this.row = row;

            if (row == null) btnEdit.Enabled = false;
            else
            {
                btnAdd.Enabled = false;
                this.Text = "FormPharmacistDrugStock_Edit";
                SetInput();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(CheckInput())
            {
                bus_drug.Add(txtName.Text, Convert.ToDecimal(txtPrice.Text), txtProducer.Text, 
                    Convert.ToInt32(txtQuantity.Text), txtType.Text, txtUnit.Text, DateTimePicker.Value);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                if (bus_drug.EditDrug(Convert.ToInt32(txtID.Text), txtName.Text, txtProducer.Text, 
                    DateTimePicker.Value, txtUnit.Text, Convert.ToDecimal(txtPrice.Text), Convert.ToInt32(txtQuantity.Text), txtType.Text))
                {
                    MessageBox.Show("Edit drug successfully");
                    bus_drug.ShowDrugs(dgv);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetInput()
        {
            txtID.Text = row.Cells["DrugID"].Value.ToString();
            txtName.Text = row.Cells["Name"].Value.ToString();
            txtPrice.Text = row.Cells["Price"].Value.ToString();
            txtProducer.Text = row.Cells["Producer"].Value.ToString();
            txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
            txtType.Text = row.Cells["Type"].Value.ToString();
            txtUnit.Text = row.Cells["Unit"].Value.ToString();
            DateTimePicker.Value = (DateTime)row.Cells["ExprirationDate"].Value;
        }

        bool CheckInput()
        {

            if (txtName.Text.Length == 0)
            {
                MessageBox.Show("Please enter Name");
                txtName.Focus();
                return false;
            }
            else if (txtPrice.Text.Length == 0)
            {
                MessageBox.Show("Please enter Price");
                txtPrice.Focus();
                return false;
            }
            else if (txtQuantity.Text.Length == 0)
            {
                MessageBox.Show("Please enter Quantity");
                txtQuantity.Focus();
                return false;
            }
            else if (txtUnit.Text.Length == 0)
            {
                MessageBox.Show("Please enter Unit");
                txtUnit.Focus();
                return false;
            }
            //else if(DateTime.Compare(DateTimePicker.Value, DateTime.Now) < 0)
            //{
            //    MessageBox.Show("Please enter Expiration Date");
            //    return false;
            //}

            return true;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
