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
    public partial class FormGP_Prescription : Form
    {
        int idGP;
        int idPatient;
        BUS_Prescription bus_Prescription;
        BUS_Drug bus_Drug;
        String currentDay = DateTime.Now.ToShortDateString();

        public FormGP_Prescription(int idGP, int idPatient)
        {
            InitializeComponent();
            bus_Drug = new BUS_Drug();
            this.idGP = idGP;
            this.idPatient = idPatient;
            bus_Prescription = new BUS_Prescription();
        }


        private void FormGP_Prescription_Load(object sender, EventArgs e)
        {

            bus_Drug.ShowDrugs(gridview_pill);
            gridview_pill.Columns["DrugID"].Visible = false;
            gridview_pill.Columns["Type"].Visible = false;
            gridview_pill.Columns["Price"].Visible = false;
            gridview_pill.Columns["Quantity"].Visible = false;
            gridview_pill.Columns["Producer"].Visible = false;
            gridview_pill.Columns["ExprirationDate"].Visible = false;
            //gridview_pill.Columns[0].Width = 100;
            //gridview_pill.Columns["ImportDate"].Visible = false;
            //
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
           
            if (gridview_prescription.Rows.Count == 0)
            {
                MessageBox.Show("Choose pill to edit!");
            }
            else
            {
                FormGP_Prescription_EditPill form_edit = new FormGP_Prescription_EditPill(gridview_prescription);
                form_edit.label_name.Text = this.gridview_prescription.CurrentRow.Cells[0].Value.ToString();
                form_edit.textbox_amount.Text = this.gridview_prescription.CurrentRow.Cells[1].Value.ToString();
                form_edit.Show();
            } 
        }

        private void btn_CreatePrescription_Click(object sender, EventArgs e)
        {
            if(bus_Prescription.AddPrescription(txtInstruction.Text, idPatient, idGP ))
            {
                MessageBox.Show("Add Prescription successfully!");
            }
        }
    }
}
