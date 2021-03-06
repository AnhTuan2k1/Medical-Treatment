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
        BUS_GPdrugDetail bus_GPdrugDetail;
        BUS_Drug bus_Drug;
        BUS_ExaminationForm bus_exf;
        String currentDay = DateTime.Now.ToShortDateString();
        FormGP_Diagnosis ParentForm;
        public FormGP_Prescription( FormGP_Diagnosis ParentForm,int idGP, int idPatient)
        {
            InitializeComponent();
            bus_Drug = new BUS_Drug();
            this.idGP = idGP;
            this.idPatient = idPatient;
            bus_Prescription = new BUS_Prescription();
            bus_Drug = new BUS_Drug();
            bus_GPdrugDetail = new BUS_GPdrugDetail();
            bus_exf = new BUS_ExaminationForm();
            this.ParentForm = ParentForm;
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
            gridview_pill.AllowUserToOrderColumns = true;
            //gridview_pill.Columns[0].Width = 100;
            //gridview_pill.Columns["ImportDate"].Visible = false;
            //
            label_date.Text = " Prescription date: " + currentDay;
        }

 


        private void btn_add_Click(object sender, EventArgs e)
        {
            if (gridview_pill.SelectedRows.Count < 0)
            {
                return;
            }
            else
            {
                FormGP_Prescription_AddPill form_add = new FormGP_Prescription_AddPill(gridview_prescription);
                form_add.txt_name.Text = this.gridview_pill.CurrentRow.Cells[1].Value.ToString();
                form_add.Show();

            }
            //string name = this.gridview_pill.CurrentRow.Cells[1].Value.ToString(); ;
            //string amount = form_add.textbox_amount.Text;

            //if (name != "" && amount != "")
            //{
            //    this.gridview_prescription.Rows.Add(new object[] { name, amount});
            //}
            

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (gridview_prescription.Rows.Count == 0)
            {
                MessageBox.Show("No pill to delete!");
            }
            else
            {
                string name = gridview_prescription.SelectedRows[0].Cells[0].Value.ToString();
                string caption = "Do you want to delete " + name + " ?";

                DialogResult result = MessageBox.Show(caption, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in this.gridview_prescription.SelectedRows)
                    {
                        gridview_prescription.Rows.RemoveAt(item.Index);
                    }
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
           
            if (gridview_prescription.Rows.Count == 0)
            {
                MessageBox.Show("No pill to edit!");
            }
            else
            {
                FormGP_Prescription_EditPill form_edit = new FormGP_Prescription_EditPill(gridview_prescription);
                form_edit.label_name.Text = this.gridview_prescription.CurrentRow.Cells[0].Value.ToString();
                form_edit.comboAmount.Text = this.gridview_prescription.CurrentRow.Cells[1].Value.ToString();
                form_edit.Show();
            } 
        }

        private void btn_CreatePrescription_Click(object sender, EventArgs e)
        {
            if(gridview_prescription.Rows.Count ==0)
            {
                MessageBox.Show("Add some pill..");
            }
            else
            {
                if (bus_Prescription.AddPrescription(txtInstruction.Text, idPatient, idGP))
                {

                    bus_exf.SetState(idPatient, "inpharmacist");
                    foreach (DataGridViewRow row in gridview_prescription.Rows)
                    {
                        string drugName = row.Cells[0].Value.ToString();
                        int drugQuantity = Int32.Parse(row.Cells[1].Value.ToString());
                        int prescriptionID = bus_Prescription.GetPrescriptionID(idGP, idPatient);
                        if (bus_GPdrugDetail.Adddrugdetail(drugName, drugQuantity, prescriptionID, idPatient, idGP))
                        {
                            
                        }
                    }

                    DialogResult result = MessageBox.Show("Add Prescription successfully!", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        txtInstruction.Text = "";
                        gridview_prescription.Rows.Clear();
                        ParentForm.DialogResult = DialogResult.OK;
                       

                        ParentForm.gridview_requestlist.DataSource = null;
                        ParentForm.gridview_resultlist.DataSource = null;
                    
                        ParentForm.txtPhone.Text = "";
                        ParentForm.txtReason.Text = "";
                        ParentForm.txtDiagnoseResult.Text = "";
                        ParentForm.txtDirection.Text = "";

                        ParentForm.ComboBoxPatientName.Text = "";
                        ParentForm.bus_Patient.ShowPatients_GP(ParentForm.ComboBoxPatientName);
                        this.Close();

                        //ParentForm.bUS_SErequest.ShowSEresult(ParentForm.gridview_resultlist, idPatient);

                    }

                }
            }
        }



        private void gppatienttextbox_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                bus_Drug.ShowSeachDrug(gridview_pill, gppatienttextbox_search.Text);
            }
        }
    }
}
