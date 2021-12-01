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
        public FormSpecialist_Price()
        {
            InitializeComponent();
        }

        private void FormSpecialist_Price_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add(new object[]
    {
                "Eyes", "500k"
    });
        }
    }
}
