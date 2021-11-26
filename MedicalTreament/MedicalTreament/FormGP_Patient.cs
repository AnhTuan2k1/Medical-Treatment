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
    public partial class FormGP_Patient : Form
    {
        public FormGP_Patient()
        {
            InitializeComponent();
        }

        private void FormGP_Patient_Load(object sender, EventArgs e)
        {
            gridview_patient.Rows.Add(4);
            gridview_patient.Rows[0].Cells[0].Value = "001";
            gridview_patient.Rows[0].Cells[1].Value = "Lil Bi";
            gridview_patient.Rows[0].Cells[2].Value = "Yes";
            gridview_patient.Rows[0].Cells[3].Value = "Yes";

            gridview_patient.Rows[1].Cells[0].Value = "002";
            gridview_patient.Rows[1].Cells[1].Value = "Wan Vu";
            gridview_patient.Rows[1].Cells[2].Value = "Yes";
            gridview_patient.Rows[1].Cells[3].Value = "Yes";

            gridview_patient.Rows[2].Cells[0].Value = "003";
            gridview_patient.Rows[2].Cells[1].Value = "Chuan Pi";
            gridview_patient.Rows[2].Cells[2].Value = "No";
            gridview_patient.Rows[2].Cells[3].Value = "Yes";

            gridview_patient.Rows[3].Cells[0].Value = "004";
            gridview_patient.Rows[3].Cells[1].Value = "Lil Po";
            gridview_patient.Rows[3].Cells[2].Value = "No";
            gridview_patient.Rows[3].Cells[3].Value = "No";

            gridview_patient.Rows.Add(new object[]
            {
                "005", "Alaba", "No", "Yes"
            });
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {

        }
    }
}
