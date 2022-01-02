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

namespace MedicalTreament.AdminForm
{
    public partial class DashboardForm : Form
    {
        BUS_Invoice bUS_Invoice;
        BUS_Employee bUS_Employee;
        BUS_Patient bUS_Patient;
        BUS_Drug bUS_Drug;
        public DashboardForm()
        {
            InitializeComponent();
            bUS_Invoice = new BUS_Invoice();
            bUS_Employee = new BUS_Employee();
            bUS_Patient = new BUS_Patient();
            bUS_Drug = new BUS_Drug();
        }
        private void ShowVisitorHistory()
        {
            dtgvHistory.DataSource = null;
            bUS_Invoice.ShowVisitorHistory(dtgvHistory);
        }
        private decimal ShowTotalDrugPaymentByYear(int year)
        {
            return bUS_Invoice.ShowTotalDrugPaymentByYear(year);
        }
        private decimal ShowTotalIncomeByYear(int year)
        {
            return bUS_Invoice.ShowTotalIncomeByYear(year);
        }
        private decimal ShowTotalEmployeePaymentByYear(int year)
        {
            return bUS_Invoice.ShowTotalEmployeePaymentByYear(year);
        }
        private int ShowEmployeeLength()
        {
            return bUS_Employee.ShowLength();
        }
        private int ShowPatientLength()
        {
            return bUS_Patient.GetLength();
        }
        private int ShowDrugLength()
        {
            return bUS_Drug.ShowLength();
        }
        private decimal ShowTotalPrice()
        {
            return bUS_Invoice.ShowTotalPrice();
        }
        private decimal ShowJan(int year)
        {
            return bUS_Invoice.ShowJan(year);
        }
        private decimal ShowFeb(int year)
        {
            return bUS_Invoice.ShowFeb(year);
        }
        private decimal ShowMar(int year)
        {
            return bUS_Invoice.ShowMar(year);
        }
        private decimal ShowApr(int year)
        {
            return bUS_Invoice.ShowApr(year);
        }
        private decimal ShowMay(int year)
        {
            return bUS_Invoice.ShowMay(year);
        }
        private decimal ShowJun(int year)
        {
            return bUS_Invoice.ShowJun(year);
        }
        private decimal ShowJul(int year)
        {
            return bUS_Invoice.ShowJul(year);
        }
        private decimal ShowAug(int year)
        {
            return bUS_Invoice.ShowAug(year);
        }
        private decimal ShowSep(int year)
        {
            return bUS_Invoice.ShowSep(year);
        }
        private decimal ShowOct(int year)
        {
            return bUS_Invoice.ShowOct(year);
        }
        private decimal ShowNov(int year)
        {
            return bUS_Invoice.ShowNov(year);
        }
        private decimal ShowDec(int year)
        {
            return bUS_Invoice.ShowDec(year);
        }
        private int CountIncomePercent()
        {
            decimal outcome = ShowTotalEmployeePaymentByYear(Convert.ToInt32(lbYear.Text))
               + ShowTotalDrugPaymentByYear(Convert.ToInt32(lbYear.Text));
            decimal revenue = ShowTotalIncomeByYear(Convert.ToInt32(lbYear.Text));
            decimal income = revenue - outcome;
            int money = 0;
            if (revenue != 0)
            {
                money = Convert.ToInt32(income / revenue) * 100;
            }
            if (money <= 0)
            {
                money = 0;
            }
            return money;
        }
        private int CountOutcomePercent()
        {
            decimal outcome = ShowTotalEmployeePaymentByYear(Convert.ToInt32(lbYear.Text))
                + ShowTotalDrugPaymentByYear(Convert.ToInt32(lbYear.Text));
            decimal revenue = ShowTotalIncomeByYear(Convert.ToInt32(lbYear.Text));
            int money = 0;
            if (revenue != 0)
            {
                money = Convert.ToInt32(outcome / revenue) * 100;
            }
            if (money <= 0)
            {
                money = 0;
            }
            return money;
        }
        private void ShowChart(int year)
        {
            chartRevenue.Series["Revenue"].Points.AddXY("January", Convert.ToInt64(ShowJan(year)));
            chartRevenue.Series["Revenue"].Points.AddXY("February", Convert.ToInt64(ShowFeb(year)));
            chartRevenue.Series["Revenue"].Points.AddXY("March", Convert.ToInt64(ShowMar(year)));
            chartRevenue.Series["Revenue"].Points.AddXY("April", Convert.ToInt64(ShowApr(year)));
            chartRevenue.Series["Revenue"].Points.AddXY("May", Convert.ToInt64(ShowMay(year)));
            chartRevenue.Series["Revenue"].Points.AddXY("June", Convert.ToInt64(ShowJun(year)));
            chartRevenue.Series["Revenue"].Points.AddXY("July", Convert.ToInt64(ShowJul(year)));
            chartRevenue.Series["Revenue"].Points.AddXY("August", Convert.ToInt64(ShowAug(year)));
            chartRevenue.Series["Revenue"].Points.AddXY("September", Convert.ToInt64(ShowSep(year)));
            chartRevenue.Series["Revenue"].Points.AddXY("October", Convert.ToInt64(ShowOct(year)));
            chartRevenue.Series["Revenue"].Points.AddXY("November", Convert.ToInt64(ShowNov(year)));
            chartRevenue.Series["Revenue"].Points.AddXY("December", Convert.ToInt64(ShowDec(year)));
        }
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            ShowVisitorHistory();
            lbEmployees.Text = ShowEmployeeLength().ToString();
            lbCustomers.Text = ShowPatientLength().ToString();
            lbStorage.Text = ShowDrugLength().ToString();
            lbRevenue.Text = (Convert.ToInt64(ShowTotalPrice())).ToString();
            lbYear.Text = DateTime.Now.Year.ToString();
            ShowChart(Convert.ToInt32(lbYear.Text));
            lbInOut.Text = CountIncomePercent().ToString() + "%";
            cpsbBigCircle.Value = CountIncomePercent();
            cpsbSmallCircle.Value = CountOutcomePercent();
        }
        private void rbtIncome_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtIncome.Checked)
            {
                lbInOut.Text = CountIncomePercent().ToString() + "%";
            }
        }

        private void rbtOutcome_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtOutcome.Checked)
            {
                lbInOut.Text = CountOutcomePercent().ToString() + "%";
            }
        }
    }
}
