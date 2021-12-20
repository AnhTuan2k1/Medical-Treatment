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
    public partial class FormSpecialist_Price : Form
    {
        BUS_SpecialistExamination bus_SpecialistExamination;
        public FormSpecialist_Price()
        {
            InitializeComponent();
            bus_SpecialistExamination = new BUS_SpecialistExamination();
        }

        private void FormSpecialist_Price_Load(object sender, EventArgs e)
        {
            ShowSE();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FormSpecialist_Price_Add formSpecialist_Price_Add = new FormSpecialist_Price_Add(gridSpecialistExamination);
            formSpecialist_Price_Add.Show();
            ShowSE();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {

        }

        private void ShowSE()
        {
            gridSpecialistExamination.DataSource = null;
            bus_SpecialistExamination.ShowSpecialistExamination(gridSpecialistExamination);
        }
    }
}
