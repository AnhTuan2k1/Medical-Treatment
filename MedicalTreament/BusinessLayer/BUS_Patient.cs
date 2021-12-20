using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace BusinessLayer
{
    public class BUS_Patient
    {
        DAO_Patient daoPatient;

        public BUS_Patient()
        {
            daoPatient = DAO_Patient.getInstance();
        }

        public void ShowPatients(DataGridView dgv)
        {
            dgv.DataSource = daoPatient.GetPatients();
        }

        public void ShowPatients(ComboBox combo)
        {
            combo.DataSource = daoPatient.GetPatients();
        }

        public void ShowUnPayPatients(ComboBox combo)
        {
            combo.DataSource = daoPatient.GetUnPayPatients();
            combo.DisplayMember = "PatientID";
            combo.ValueMember = "PatientName";
        }

        public bool AddPatient(string name, string phone, DateTime birth, string gender = "",
            string address = "", string healthInsurance = "", string nation = "", string workplace = "")
        {

            try
            {
                daoPatient.AddPatient(name, phone, birth, gender, address, healthInsurance, nation, workplace);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }   

        }

        public bool EditPatient(int PatientID, string name, string phone, DateTime birth, string gender,
            string address, string healthInsurance, string nation, string workplace)
        {

            try
            {
                daoPatient.EditPatient(PatientID, name, phone, birth, 
                    gender, address, healthInsurance, nation, workplace);

                return true;
            }
            catch (Exception)
            {

                return false;
                throw;
            }

        }

        public bool DeletePatient(int patientID)
        {

            try
            {
                daoPatient.DeletePatient(patientID);

                return true;
            }
            catch (Exception)
            {

                return false;
                throw;
            }
        }
    }
}
