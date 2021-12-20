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




public partial class FormGP_Prescription_AddPill : Form
    {


        Guna.UI2.WinForms.Guna2DataGridView FGPP;
        public FormGP_Prescription_AddPill(Guna.UI2.WinForms.Guna2DataGridView data)
        {
            InitializeComponent();
            this.FGPP = data;
        }


    private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (textbox_amount.Text == "")
            {

            }
            else
            {

                this.FGPP.Rows.Add(new object[] { label_name.Text, textbox_amount.Text });
                this.Close();
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void label_ttname_Click(object sender, EventArgs e)
        {

        }

        private void label_ttamount_Click(object sender, EventArgs e)
        {

        }

        private void FormGP_Prescription_AddPill_Load(object sender, EventArgs e)
        {

        }

        private void textbox_amount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
