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
    public partial class FormPharmacistAddDrug : Form
    {
        FormPharmacistPayment parent;
        int drugID;
        BUS_Drug bus_drug;

        public FormPharmacistAddDrug(FormPharmacistPayment parent, int index, int drugID)
        {
            InitializeComponent();
            bus_drug = new BUS_Drug();
            this.parent = parent;
            this.drugID = drugID;
            bus_drug.ShowSellableDrugs(comboName);
            comboName.DisplayMember = "Name";
            //comboName.SelectedIndex = index;
            Loaddrug(drugID.ToString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(comboQuantity.Text.Length == 0)
            {
                MessageBox.Show("Please enter Quantity");
                comboQuantity.Focus();
                return;
            }

            int soluong = bus_drug.GetQuantity(drugID);
            int quantity = Convert.ToInt32(comboQuantity.Text);
            if (quantity > soluong)
                MessageBox.Show("not enough drug. Max is " + soluong.ToString());
            else
            {
                parent.quantity = quantity;
                parent.drugID = drugID;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void comboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboName.ValueMember = "DrugID";
            drugID = Convert.ToInt32(comboName.SelectedValue.ToString());      
        }

        private void Loaddrug(string drugID)
        {
            for (int i = 0; i < comboName.Items.Count; i++)
            {
                string x = comboName.Items[i].ToString();
                x = x.Split(',')[0].Split('=')[1].Trim();
                if (x == drugID)
                {
                    if (i == 0)
                    {
                        if (comboName.Items.Count > 1)
                            comboName.SelectedIndex = 1;
                        else comboName_SelectedIndexChanged(new object(), new EventArgs());
                    }
                    comboName.SelectedIndex = i;
                }
            }
        }
    }
}
