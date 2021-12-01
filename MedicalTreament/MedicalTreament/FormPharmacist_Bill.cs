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
    public partial class FormPharmacist_Bill : Form
    {
        Bitmap bmp;
        public FormPharmacist_Bill()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }

        private void btnPayPrint_Click(object sender, EventArgs e)
        {
            btnPay_Click(sender, e);
            Graphics g = guna2Panel1.CreateGraphics();
            bmp = new Bitmap(guna2Panel1.Size.Width, guna2Panel1.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, guna2Panel1.Size);
            printPreviewDialog1.ShowDialog();           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 150, 0);
        }

    }
}
