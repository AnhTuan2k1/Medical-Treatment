using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalTreament.AdminForm
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            dtgvHistory.Rows.Add(3);
            dtgvHistory.Rows[0].Cells[0].Value = "1";
            dtgvHistory.Rows[0].Cells[1].Value = "01/01/1111";
            dtgvHistory.Rows[0].Cells[2].Value = "11:11";
            dtgvHistory.Rows[0].Cells[3].Value = "Em Tân";
            dtgvHistory.Rows[0].Cells[4].Value = "Em Thái";
            dtgvHistory.Rows[0].Cells[5].Value = "20.000.000";
            dtgvHistory.Rows[1].Cells[0].Value = "2";
            dtgvHistory.Rows[1].Cells[1].Value = "01/01/1111";
            dtgvHistory.Rows[1].Cells[2].Value = "11:11";
            dtgvHistory.Rows[1].Cells[3].Value = "Em Tân";
            dtgvHistory.Rows[1].Cells[4].Value = "Em Thái";
            dtgvHistory.Rows[1].Cells[5].Value = "20.000.000";
            dtgvHistory.Rows[2].Cells[0].Value = "3";
            dtgvHistory.Rows[2].Cells[1].Value = "01/01/1111";
            dtgvHistory.Rows[2].Cells[2].Value = "11:11";
            dtgvHistory.Rows[2].Cells[3].Value = "Em Tân";
            dtgvHistory.Rows[2].Cells[4].Value = "Em Thái";
            dtgvHistory.Rows[2].Cells[5].Value = "20.000.000";
        }
    }
}
