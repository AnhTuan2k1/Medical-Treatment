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
    public partial class FormSpecialist_Price_Add : Form
    {
        BUS_SpecialistExamination bUS_SpecialistExamination;
        DataGridView dgv;
        public FormSpecialist_Price_Add(DataGridView data)
        {
            InitializeComponent();
            this.dgv = data;
            bUS_SpecialistExamination = new BUS_SpecialistExamination();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                this.Close();
            }
            else
            {
                if(bUS_SpecialistExamination.Add(txtName.Text, txtPrice.Text))
                {
                    MessageBox.Show("Add Special Examination successfully");
                    txtName.Text = "";
                    txtPrice.Text = "";
                    bUS_SpecialistExamination.ShowSpecialistExamination(dgv);
                }
            }
        }



        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



 
    }
}
