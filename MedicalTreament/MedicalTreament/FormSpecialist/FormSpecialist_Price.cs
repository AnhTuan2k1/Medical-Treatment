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
    public partial class FormSpecialist_Price : Form
    {
        BUS_SpecialistExamination bus_SpecialistExamination;
        int idSP;
        public FormSpecialist_Price(int id)
        {
            InitializeComponent();
            bus_SpecialistExamination = new BUS_SpecialistExamination();
            this.idSP = id;
        }

        private void FormSpecialist_Price_Load(object sender, EventArgs e)
        {
            ShowSE();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FormSpecialist_Price_Add formSpecialist_Price_Add = new FormSpecialist_Price_Add(gridSpecialistExamination);
            formSpecialist_Price_Add.Show();
            ShowSE();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if( gridSpecialistExamination.Rows.Count <1)
            {
                MessageBox.Show("Nothing to delete!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                int id = Convert.ToInt32(gridSpecialistExamination.SelectedRows[0].Cells["SpecialExaminationID"].Value.ToString());
                string name = gridSpecialistExamination.SelectedRows[0].Cells["Name"].Value.ToString();
                string caption = "Do you want to delete " + name + " Examination?";

                DialogResult result = MessageBox.Show(caption, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (bus_SpecialistExamination.Remove(id))
                    {
                        bus_SpecialistExamination.ShowSpecialistExamination(gridSpecialistExamination);
                    }
                }
            }         
        }

        private void ShowSE()
        {
            gridSpecialistExamination.DataSource = null;
            bus_SpecialistExamination.ShowSpecialistExamination(gridSpecialistExamination);
            gridSpecialistExamination.Columns["SpecialExaminationID"].Visible = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (gridSpecialistExamination.Rows.Count < 1)
            {
                MessageBox.Show("Nothing to edit!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                FormSpecialist_Price_Edit formSpecialist_Price_Edit = new FormSpecialist_Price_Edit(gridSpecialistExamination, Convert.ToInt32(gridSpecialistExamination.SelectedRows[0].Cells["SpecialExaminationID"].Value.ToString()));
                formSpecialist_Price_Edit.txtName.Text = gridSpecialistExamination.SelectedRows[0].Cells["Name"].Value.ToString();
                formSpecialist_Price_Edit.txtPrice.Text = gridSpecialistExamination.SelectedRows[0].Cells["Price"].Value.ToString();
                formSpecialist_Price_Edit.Show();
                ShowSE();
            }
        }
    }
}
