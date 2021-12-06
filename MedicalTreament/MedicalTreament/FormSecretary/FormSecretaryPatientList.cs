﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using BusinessLayer;

namespace MedicalTreament
{
    public partial class FormSecretaryPatientList : Form
    {
        BUS_Patient bus_patient;
        Guna2Button btn;


        public FormSecretaryPatientList(Guna2Button btn)
        {
            InitializeComponent();
            this.btn = btn;
            bus_patient = new BUS_Patient();
        }

        private void ShowPatients()
        {
            guna2DataGridViewPatients.DataSource = null;
            bus_patient.GetPatients(guna2DataGridViewPatients);
        }

        private void FormSecretaryPatientList_FormClosed(object sender, FormClosedEventArgs e)
        {
            btn.Image = Properties.Resources.outline_groups_black_24dp;
            btn.FillColor = Color.White;
            btn.ForeColor = Color.Black;
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            FormSecretaryPatientList_Add formAddPatient = new FormSecretaryPatientList_Add();
            formAddPatient.ShowDialog();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void FormSecretaryPatientList_Load(object sender, EventArgs e)
        {
            ShowPatients();
        }
    }
}
