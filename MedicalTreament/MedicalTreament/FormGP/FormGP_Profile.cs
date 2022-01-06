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
    public partial class FormGP_Profile : Form
    {
        int idGP;
        BUS_Employee bus_emp;
        BUS_Account bus_acc;
        public FormGP_Profile(int gpID)
        {
            InitializeComponent();
            this.idGP = gpID;
            bus_emp = new BUS_Employee();
            bus_acc = new BUS_Account();
        }

        private void FormGP_Profile_Load(object sender, EventArgs e)
        {
            lbname.Text = bus_emp.GetEmployeeName(idGP);
            switch (bus_emp.GetEmployeePosition(idGP))
            {
                case "gp":
                    lbpos.Text = "General Practitioner";
                    break;
                case "specialist":
                    lbpos.Text = "Specialist";
                    break;
                case "pharmacist":
                    lbpos.Text = "Pharmacist";
                    break;
                case "secretary":
                    lbpos.Text = "Secretary";
                    break;
                default:
                    lbpos.Text = bus_emp.GetEmployeePosition(idGP);
                    break;

            }
            
            lbsala.Text = bus_emp.GetEmployeeSalary(idGP).ToString() + " VND";
            lbmail.Text = bus_emp.GetEmployeeEmail(idGP);
            lbuser.Text = bus_acc.GetAccUsername(idGP);
            lbpass.Text = bus_acc.GetAccPassword(idGP);
        }
    }
}
