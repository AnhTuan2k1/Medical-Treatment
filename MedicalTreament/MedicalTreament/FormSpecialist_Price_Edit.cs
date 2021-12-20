using BusinessLayer;
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
    public partial class FormSpecialist_Price_Edit : Form
    {
        int SpecialistExaminationid;
        BUS_SpecialistExamination bUS_SpecialistExamination;
        DataGridView dgv;
        public FormSpecialist_Price_Edit(DataGridView data, int id)
        {
            InitializeComponent();
            this.SpecialistExaminationid = id;
            this.dgv = data;
            bUS_SpecialistExamination = new BUS_SpecialistExamination();
        }


        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Empty!");
            }
            else
            {
                CheckDecimal(txtPrice.Text);
            }
        }

        public void CheckDecimal(string a)
        {
            decimal b;
            if (Decimal.TryParse(a, out b))
            {
                if (bUS_SpecialistExamination.Edit(SpecialistExaminationid,txtName.Text, txtPrice.Text))
                {
                    MessageBox.Show("Edit Special Examination successfully");
                    txtName.Text = "";
                    txtPrice.Text = "";
                    bUS_SpecialistExamination.ShowSpecialistExamination(dgv);
                }
            }
            else
            {
                MessageBox.Show("Wrong number!");
                txtPrice.Text = "";
            }
        }

    }
}
