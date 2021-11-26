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
        public FormGP_Prescription_AddPill()
        {
            InitializeComponent();

        }


    private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (textbox_amount.Text == "" || textbox_route.Text == "")
            {

            }
            else
            {

                this.Close();
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

            this.Close();
        }


    }
}
