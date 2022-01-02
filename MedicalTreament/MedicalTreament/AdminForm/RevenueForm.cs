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
    public partial class RevenueForm : Form
    {
        BUS_Invoice bUS_Invoice;
        public RevenueForm()
        {
            InitializeComponent();
            bUS_Invoice = new BUS_Invoice();
        }
        private void ShowIncomeByYear(int year)
        {
            dtgvIncome.DataSource = null;
            bUS_Invoice.ShowIncomeByYear(dtgvIncome, year);
            dtgvIncome.Columns[0].Width = (int)(dtgvIncome.Width * 0.1);
        }
        private void ShowEmployeePaymentByYear(int year)
        {
            dtgvEmployeePayment.DataSource = null;
            bUS_Invoice.ShowEmployeePaymentByYear(dtgvEmployeePayment, year);
            dtgvEmployeePayment.Columns[0].Width = (int)(dtgvEmployeePayment.Width * 0.1);
        }
        private void ShowDrugPaymentByYear(int year)
        {
            dtgvDrugPayment.DataSource = null;
            bUS_Invoice.ShowDrugPaymentByYear(dtgvDrugPayment, year);
            dtgvDrugPayment.Columns[0].Width = (int)(dtgvDrugPayment.Width * 0.1);
        }
        private int CountIncomePercent()
        {
            decimal outcome = ShowTotalEmployeePaymentByYear(Convert.ToInt32(cbbYear.Text))
                + ShowTotalDrugPaymentByYear(Convert.ToInt32(cbbYear.Text));
            decimal revenue = ShowTotalIncomeByYear(Convert.ToInt32(cbbYear.Text));
            decimal income = revenue - outcome;
            int money = 0;
            if (revenue != 0)
            {
               money = Convert.ToInt32(income / revenue) * 100;
            }
            if(money <= 0)
            {
                money = 0;
            }
            return money;
        }
        private int CountEmployeePercent()
        {
            decimal employee = ShowTotalEmployeePaymentByYear(Convert.ToInt32(cbbYear.Text));
            decimal revenue = ShowTotalIncomeByYear(Convert.ToInt32(cbbYear.Text));
            int money = 0;
            if (revenue != 0)
            {
                money = Convert.ToInt32(employee / revenue) * 100;
            }
            if (money <= 0)
            {
                money = 0;
            }
            return money;
        }
        private int CountDrugPercent()
        {
            decimal drug = ShowTotalDrugPaymentByYear(Convert.ToInt32(cbbYear.Text));
            decimal revenue = ShowTotalIncomeByYear(Convert.ToInt32(cbbYear.Text));
            int money = 0;
            if (revenue != 0)
            {
                money = Convert.ToInt32(drug / revenue) * 100;
            }
            if (money <= 0)
            {
                money = 0;
            }
            return money;
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
        private void ShowPie(int year, int income,int employee,int drug)
        {
            chartInVsOut.Series["InVsOut"].Points.AddXY("Income", income);
            chartInVsOut.Series["InVsOut"].Points.AddXY("Employee", employee);
            chartInVsOut.Series["InVsOut"].Points.AddXY("Drug", drug);
        }
        private void RevenueForm_Load(object sender, EventArgs e)
        {
            cbbYear.Text = DateTime.Now.Year.ToString();
            ShowIncomeByYear(Convert.ToInt32(cbbYear.Text));
            ShowEmployeePaymentByYear(Convert.ToInt32(cbbYear.Text));
            ShowDrugPaymentByYear(Convert.ToInt32(cbbYear.Text));
            foreach (var series in chartRevenue.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in chartInVsOut.Series)
            {
                series.Points.Clear();
            }
            ShowChart(Convert.ToInt32(cbbYear.Text));
            ShowPie(Convert.ToInt32(cbbYear.Text), CountIncomePercent(), CountEmployeePercent(), CountDrugPercent());
        }

        private void cbbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbYear.Text = cbbYear.SelectedIndex.ToString();
            ShowIncomeByYear(Convert.ToInt32(cbbYear.Text));
            ShowEmployeePaymentByYear(Convert.ToInt32(cbbYear.Text));
            ShowDrugPaymentByYear(Convert.ToInt32(cbbYear.Text));
            foreach (var series in chartRevenue.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in chartInVsOut.Series)
            {
                series.Points.Clear();
            }
            ShowChart(Convert.ToInt32(cbbYear.Text));
            ShowPie(Convert.ToInt32(cbbYear.Text), CountIncomePercent(), CountEmployeePercent(), CountDrugPercent());
        }
    }
}
