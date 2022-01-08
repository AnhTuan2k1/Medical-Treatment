using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalTreament
{
    public partial class FormGP_Prescription_EditPill : Form
    {
        Guna.UI2.WinForms.Guna2DataGridView dgv;
        public FormGP_Prescription_EditPill(Guna.UI2.WinForms.Guna2DataGridView data)
        {
            InitializeComponent();
            this.dgv = data;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            CheckDecimal(comboAmount.Text);
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CheckDecimal(string a)
        {
            decimal b;
            if (Decimal.TryParse(a, out b))
            {
                this.dgv.CurrentRow.Cells[1].Value = comboAmount.Text;

                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong number!");
            }
        }
    }
}
