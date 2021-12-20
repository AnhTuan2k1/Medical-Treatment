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

    public partial class FormGP_Diagnosis : Form
    {
        BUS_SpecialistExamination bUS_SpecialistExamination;
        string SEname;
        public FormGP_Diagnosis()
        {
            InitializeComponent();
            bUS_SpecialistExamination = new BUS_SpecialistExamination();
        }

        private void comboBoxSEname_SelectedIndexChanged(object sender, EventArgs e)
        {
            SEname = comboBoxSEname.SelectedValue.ToString();
        }

        private void FormGP_Diagnosis_Load(object sender, EventArgs e)
        {
            bUS_SpecialistExamination.ShowSpecialistExamination(comboBoxSEname);
            comboBoxSEname.DisplayMember = "Name";
            //
            label_date.Text = "Date: "+DateTime.Now.ToShortDateString();
        }
    }
}
