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
    public partial class FormGP_Prescription : Form
    {


        String currentDay = DateTime.Now.ToShortDateString();

        public FormGP_Prescription()
        {
            InitializeComponent();
        }


        private void FormGP_Prescription_Load(object sender, EventArgs e)
        {
            gridview_pill.Rows.Add(new object[]
            {
                "01", "Alaba"
            }
            );
            gridview_pill.Rows.Add(new object[]
           {
                "02", "Paracetamol"
           }
           );
            gridview_pill.Rows.Add(new object[]
           {
                "03", "Ayahuasca"
           }
           );
            gridview_pill.Rows.Add(new object[]
           {
                "04", "Methamphetamine"
           }
           );

            label_date.Text = " Prescription date: " + currentDay;
        }

 


        private void btn_add_Click(object sender, EventArgs e)
        {
            FormGP_Prescription_AddPill form_add = new FormGP_Prescription_AddPill(gridview_prescription);
            form_add.label_name.Text = this.gridview_pill.CurrentRow.Cells[1].Value.ToString();
            form_add.Show();


            string name = this.gridview_pill.CurrentRow.Cells[1].Value.ToString(); ;
            //string amount = form_add.textbox_amount.Text;

            //if (name != "" && amount != "")
            //{
            //    this.gridview_prescription.Rows.Add(new object[] { name, amount});
            //}
            

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.gridview_prescription.SelectedRows)
            {
                gridview_prescription.Rows.RemoveAt(item.Index);
            }
        }
    }
}
