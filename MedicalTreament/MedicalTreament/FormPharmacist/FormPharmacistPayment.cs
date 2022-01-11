using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Guna.UI2.WinForms;

namespace MedicalTreament
{
    public partial class FormPharmacistPayment : Form
    {
        Guna2Button btn;
        BUS_Patient bus_patient;
        BUS_ExaminationForm bus_examform;
        BUS_GPdrugDetail bus_GPdrugdetail;
        BUS_Prescription bus_Prescription;
        BUS_ExaminationForm bus_ExForm;
        int parmacistID;
        string patientID;
        private BUS_Drug bus_drug;
        FormPharmacist parent;

        public int quantity { get; set; }
        public int drugID { get; set; }

        public FormPharmacistPayment(FormPharmacist parent, Guna2Button btn, int parmacistID, string patientID = "")
        {
            InitializeComponent();
            this.btn = btn;
            bus_patient = new BUS_Patient();
            bus_examform = new BUS_ExaminationForm();
            bus_GPdrugdetail = new BUS_GPdrugDetail();
            bus_Prescription = new BUS_Prescription();
            bus_ExForm = new BUS_ExaminationForm();
            bus_drug = new BUS_Drug();
            this.parmacistID = parmacistID;
            this.patientID = patientID;
            this.parent = parent;
        }

        private void FormPharmacistPayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            // reset btn
            btn.Image = Properties.Resources.outline_paid_black_24dp;
            btn.FillColor = Color.White;
            btn.ForeColor = Color.Black;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (!CheckDrugSold()) return;
            if (CheckInput())
            {
                int patientID = Convert.ToInt32(ComboBoxPatientID.Text);
                string name = ComboBoxPatientName.Text;
                string phone = txtPhone.Text;
                if(new FormPharmacist_Bill(dgvDrugSold, name, phone, patientID, parmacistID).ShowDialog()
                    == DialogResult.OK)
                {
                    parent.OpenPayment();
                    MessageBox.Show("Patient has paid successfully!");
                }
            }
            
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDrugSold.SelectedRows)
            {
                dgvDrugSold.Rows.RemoveAt(row.Index);
            }
        }

        private void FormPharmacistPayment_Load(object sender, EventArgs e)
        {
            bus_examform.ShowUnPayPatients(ComboBoxPatientName);
            ComboBoxPatientName.DisplayMember = "Name";
            bus_examform.ShowUnPayPatients(ComboBoxPatientID);
            ComboBoxPatientID.DisplayMember = "PatientID";
            ShowDrugs();


            ClearPatientInformation();
            if(patientID != "") LoadPatientInfor(patientID);
        }

        private void LoadPatientInfor(string patientID)
        {
            for (int i = 0; i < ComboBoxPatientID.Items.Count; i++)
            {
                string x = ComboBoxPatientID.Items[i].ToString();
                x = x.Split(',')[0].Split('=')[1].Trim();
                if (x == patientID)
                {
                    if (i == 0) 
                    {
                        if (ComboBoxPatientID.Items.Count > 1)
                            ComboBoxPatientID.SelectedIndex = 1;
                        else ComboBoxPatientName_SelectedIndexChanged(new object(), new EventArgs());
                    }
                    ComboBoxPatientID.SelectedIndex = i;
                }
            }
        }

        private void ClearPatientInformation()
        {
            ComboBoxPatientID.Text = "";
            ComboBoxPatientName.Text = "";
            txtDateOfBirth.Text = "";
            txtPhone.Text = "";
            dgvDoctorDrugs.DataSource = null;
        }

        private void ComboBoxPatientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxPatientName.ValueMember = "Name";
            ComboBoxPatientName.Text = ComboBoxPatientName.SelectedValue.ToString();

            ComboBoxPatientName.ValueMember = "PatientID";
            ComboBoxPatientID.Text = ComboBoxPatientName.SelectedValue.ToString();

            ComboBoxPatientName.ValueMember = "DateOfBirth";
            txtDateOfBirth.Text = ((DateTime)ComboBoxPatientName.SelectedValue).ToString("MMM dd, yyyy");

            ComboBoxPatientName.ValueMember = "Phone";
            txtPhone.Text = ComboBoxPatientName.SelectedValue.ToString();

            ComboBoxPatientName.ValueMember = "PatientID";
            int prescription = bus_Prescription.GetPrescriptionID(int.Parse(ComboBoxPatientName.SelectedValue.ToString()));
            if (prescription != -1) bus_GPdrugdetail.ShowDrugs(dgvDoctorDrugs, prescription);
            else dgvDoctorDrugs.DataSource = null;
        }

        private void ComboBoxPatientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxPatientID.ValueMember = "Name";
            ComboBoxPatientName.Text = ComboBoxPatientID.SelectedValue.ToString();

            ComboBoxPatientID.ValueMember = "DateOfBirth";
            txtDateOfBirth.Text = ((DateTime)ComboBoxPatientID.SelectedValue).ToString("MMM dd, yyyy");

            ComboBoxPatientID.ValueMember = "Phone";
            txtPhone.Text = ComboBoxPatientID.SelectedValue.ToString();

            ComboBoxPatientID.ValueMember = "PatientID";
            int prescription = bus_Prescription.GetPrescriptionID(int.Parse(ComboBoxPatientID.SelectedValue.ToString()));
            if (prescription != -1) bus_GPdrugdetail.ShowDrugs(dgvDoctorDrugs, prescription);
            else dgvDoctorDrugs.DataSource = null;
        }

        private bool CheckInput()
        {
            if (ComboBoxPatientID.Text.Length == 0)
            {
                MessageBox.Show("Enter patient ID, please!");
                ComboBoxPatientID.Focus();
                return false;
            }

            if (ComboBoxPatientName.Text.Length == 0)
            {
                MessageBox.Show("Enter patient name, please!");
                ComboBoxPatientName.Focus();
                return false;
            }

            if (txtPhone.Text.Length == 0)
            {
                MessageBox.Show("Enter phone number, please!");
                txtPhone.Focus();
                return false;
            }

            if (!bus_patient.CheckPatient(ComboBoxPatientName.Text, Convert.ToInt32(ComboBoxPatientID.Text), txtPhone.Text))
            {
                ComboBoxPatientName.Focus();
                MessageBox.Show("Can't find patient");
                return false;
            }

            return true;
        }

        private void ShowDrugs(string search = "")
        {
            bus_drug.ShowSellableDrugs(dgvStock, search);

            dgvStock.Columns["Unit"].Visible = false;
            dgvStock.Columns["Price"].Visible = false;
            dgvStock.Columns["ExprirationDate"].Visible = false;
            dgvStock.Columns["DrugID"].Visible = false;
        }

        private void dgvDoctorDrugs_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDoctorDrugs.SelectedRows.Count > 0)
                ShowDrugs(dgvDoctorDrugs.SelectedRows[0].Cells["NameDrug"].Value.ToString());
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            ShowDrugs(txtSearch.Text);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShowDrugs(txtSearch.Text);
        }

        private void dgvStock_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvStock.SelectedRows.Count == 0) return;
            string name = dgvStock.SelectedRows[0].Cells["Name"].Value.ToString();
            string unit;

            string exprirationDate;
            string price;
            drugID = Convert.ToInt32(dgvStock.SelectedRows[0].Cells["DrugID"].Value.ToString());
            quantity = 0;

            if (new FormPharmacistAddDrug(this, dgvStock.SelectedRows[0].Index, drugID).ShowDialog() == DialogResult.OK)
            {
               
                for (int i = 0; i < dgvStock.Rows.Count; i++)
                {
                    if(dgvStock.Rows[i].Cells["DrugID"].Value.ToString() == drugID.ToString())
                    {
                        name = dgvStock.Rows[i].Cells["Name"].Value.ToString();
                        unit = dgvStock.Rows[i].Cells["Unit"].Value.ToString();
                        exprirationDate = dgvStock.Rows[i].Cells["ExprirationDate"].Value.ToString();
                        price = dgvStock.Rows[i].Cells["Price"].Value.ToString();

                        dgvDrugSold.Rows.Add(name, unit, quantity, exprirationDate, drugID.ToString(), price);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count == 0) return;
            string name = dgvStock.SelectedRows[0].Cells["Name"].Value.ToString();
            string unit;

            string exprirationDate;
            string price;
            drugID = Convert.ToInt32(dgvStock.SelectedRows[0].Cells["DrugID"].Value.ToString());
            quantity = 0;

            if (new FormPharmacistAddDrug(this, dgvStock.SelectedRows[0].Index, drugID).ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < dgvStock.Rows.Count; i++)
                {
                    if (dgvStock.Rows[i].Cells["DrugID"].Value.ToString() == drugID.ToString())
                    {
                        name = dgvStock.Rows[i].Cells["Name"].Value.ToString();
                        unit = dgvStock.Rows[i].Cells["Unit"].Value.ToString();
                        exprirationDate = dgvStock.Rows[i].Cells["ExprirationDate"].Value.ToString();
                        price = dgvStock.Rows[i].Cells["Price"].Value.ToString();

                        dgvDrugSold.Rows.Add(name, unit, quantity, exprirationDate, drugID.ToString(), price);
                    }
                }
            }
        }

        private bool CheckDrugSold()
        {
            string id = "";
            int quantity = 0;
            ShowDrugs();
            for (int i = 0; i < dgvDrugSold.Rows.Count - 2; i++)
            {
                id = dgvDrugSold.Rows[i].Cells[4].Value.ToString();
                quantity = int.Parse(dgvDrugSold.Rows[i].Cells[2].Value.ToString());

                for (int j = i + 1; j < dgvDrugSold.Rows.Count - 1; j++)
                {
                    if (dgvDrugSold.Rows[j].Cells[4].Value.ToString() == id)
                        quantity += int.Parse(dgvDrugSold.Rows[j].Cells[2].Value.ToString());
                }

                for (int k = 0; k < dgvStock.Rows.Count; k++)
                {
                    if(dgvStock.Rows[i].Cells["DrugID"].Value.ToString() == id)
                    {
                        int num = int.Parse(dgvStock.Rows[k].Cells["Quantity"].Value.ToString());
                        if (quantity > num)
                        {
                            string name = dgvStock.Rows[k].Cells["Name"].Value.ToString();
                            MessageBox.Show(name + " isn't enought. Max is" + num);
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        private void ComboBoxPatientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
