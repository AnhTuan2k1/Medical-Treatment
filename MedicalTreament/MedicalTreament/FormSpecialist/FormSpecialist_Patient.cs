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
    public partial class FormSpecialist_Patient : Form
    {


        public FormSpecialist_Patient()
        {
            InitializeComponent();
        }

        private void FormSpecialist_Patient_Load(object sender, EventArgs e)
        {
            //gridview_sp_patient.Rows.Add(new object[]
            //{
            //    "001", "madagaska"
            //});
            //gridview_sp_patient.Rows.Add(new object[]
            //{
            //    "002", "madara"
            //});
            //gridview_sp_patient.Rows.Add(new object[]
            //{
            //    "003", "shasuce"
            //});
            //gridview_sp_patient.Rows.Add(new object[]
            //{
            //    "004", "kkxi"
            //});


        }

        private void btn_sp_pass_Click(object sender, EventArgs e)
        {
            if (gridview_sp_patient.Rows.Count > 0)
            {
                label_sp_patient_name.Text = gridview_sp_patient.Rows[0].Cells[1].Value.ToString();
                gridview_sp_patient.Rows.RemoveAt(0);

            }
        }
    }
}
