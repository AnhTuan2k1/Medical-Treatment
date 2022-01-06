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

namespace MedicalTreament
{
    public partial class FormPharmacist_Bill : Form
    {
        Bitmap bmp;
        DataGridView dgvDrugSold;
        BUS_SpecialistExaminationResult bus_result;
        BUS_ExaminationForm bus_form;
        BUS_Prescription bus_prescription;
        BUS_DiagnoseResult bus_diagnoseResult;
        BUS_Invoice bus_invoice;
        BUS_DrugInvoiceDetail bus_drugInvoice;
        BUS_ExaminationInvoiceDetail bus_examinationInvoice;
        int patientID;
        int pharmacistID;
        string name;
        string phone;

        public FormPharmacist_Bill(DataGridView dgvDrugSold, string name, string phone, int patientID, int pharmacistID)
        {
            InitializeComponent();
            bus_result = new BUS_SpecialistExaminationResult();
            bus_form = new BUS_ExaminationForm();
            bus_diagnoseResult = new BUS_DiagnoseResult();
            bus_prescription = new BUS_Prescription();
            bus_drugInvoice = new BUS_DrugInvoiceDetail();
            bus_invoice = new BUS_Invoice();
            bus_examinationInvoice = new BUS_ExaminationInvoiceDetail();
            this.patientID = patientID;
            this.dgvDrugSold = dgvDrugSold;
            this.pharmacistID = pharmacistID;
            this.name = name;
            this.phone = phone;
            SetData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            bus_invoice.Add(decimal.Parse(lbSubTotal.Text), patientID, pharmacistID);
            int invoiceID = bus_invoice.GetID(patientID);
            bus_form.SetPaid(patientID);
            SaveDrugDetail(invoiceID);
            SaveExamDetail(invoiceID);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SaveExamDetail(int invoiceID)
        {
            int quantity;
            int drugID;
            for (int i = 0; i < dgvDrugSold.Rows.Count - 1; i++)
            {
                quantity = int.Parse(dgvDrugSold.Rows[i].Cells[2].Value.ToString());
                drugID = int.Parse(dgvDrugSold.Rows[i].Cells[4].Value.ToString());
                bus_drugInvoice.Add(quantity, invoiceID, drugID);
            }
        }

        private void SaveDrugDetail(int invoiceID)
        {
            int quantity;
            int examID;
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                quantity = 1;
                examID = int.Parse(dgv.Rows[i].Cells["SpecialExaminationID"].Value.ToString());
                bus_examinationInvoice.Add(quantity, invoiceID, examID);
            }
        }

        private void btnPayPrint_Click(object sender, EventArgs e)
        {
            btnPay_Click(sender, e);
            this.DialogResult = DialogResult.OK;
            Graphics g = guna2Panel1.CreateGraphics();
            bmp = new Bitmap(guna2Panel1.Size.Width, guna2Panel1.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, guna2Panel1.Size);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                this.Close();
            else this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 150, 0);
        }

        private void FormPharmacist_Bill_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        void SetData()
        {
            lbDate.Text = "Bill Date: " + DateTime.Now.ToString("dd-MM-yyyy");
            lbPatientName.Text = name;
            lbPhonePatient.Text = phone;
            lbPatientID.Text = patientID.ToString();
            lbDiagnoseResult.Text = bus_diagnoseResult.GetResult(patientID);
            txtDirection.Text = bus_prescription.GetDirection(patientID);     
            
            int price = bus_form.GetFee(patientID);
            dgvBill.Rows.Add(dgvBill.Rows.Count, "Examination Fee", price, "1", price);
            setDrugs();
            setExamination();
            lbSubTotal.Text = total().ToString();

        }

        void setDrugs()
        {
            string name;
            string unitprice;
            string quantity;
            int total;
            int stt = dgvBill.Rows.Count;

            for (int i = 0; i < dgvDrugSold.Rows.Count - 1; i++, stt++)
            {
                name = dgvDrugSold.Rows[i].Cells[0].Value.ToString();
                unitprice = dgvDrugSold.Rows[i].Cells[5].Value.ToString();
                quantity = dgvDrugSold.Rows[i].Cells[2].Value.ToString();
                total = int.Parse(unitprice) * int.Parse(quantity);

                dgvBill.Rows.Add(stt, name, unitprice, quantity, total);
            }
        }

        void setExamination()
        {
            string name;
            string unitprice;
            string quantity;
            int total;
            int stt = dgvBill.Rows.Count;

            bus_result.Show(dgv, patientID);

            for (int i = 0; i < dgv.Rows.Count; i++, stt++)
            {
                name = dgv.Rows[i].Cells["Name"].Value.ToString();
                unitprice = dgv.Rows[i].Cells["Price"].Value.ToString();
                quantity = "1";
                total = int.Parse(unitprice) * int.Parse(quantity);

                dgvBill.Rows.Add(stt, name, unitprice, quantity, total);
            }
        }

        int total()
        {
            int s = 0;

            for (int i = 0; i < dgvBill.Rows.Count - 1; i++)
            {
                s += int.Parse(dgvBill.Rows[i].Cells[4].Value.ToString());
            }

            return s;
        }

    }
}
