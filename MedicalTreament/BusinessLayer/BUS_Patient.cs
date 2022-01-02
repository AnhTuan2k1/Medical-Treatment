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

        public void ShowPatients(DataGridView dgv, string namePatient)
        {
            dgv.DataSource = daoPatient.GetPatients(namePatient);
        }

        public int GetPatientID(string name, string phone)
        {
            int id = daoPatient.GetPatientID(name, phone);
            return id;
        }

        public void ShowPatients(ComboBox combo)
        {
            combo.DataSource = daoPatient.GetPatients();
        }
        public void ShowPatients_GP(DataGridView dgv)
        {
            dgv.DataSource = daoPatient.GetPatients_GP();
        }
        public void ShowPatients_GP(ComboBox cbb)
        {
            cbb.DataSource = daoPatient.GetPatients_GP();
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
            }
        }

        public bool CheckPatient(string name, int id, string phone)
        {
            try
            {
                return daoPatient.CheckPatient(name, id, phone);
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        public void ShowNewstPatients(DataGridView dgv)
        {
            dgv.DataSource = daoPatient.GetNewestPatients();
        }
        public void ShowMalePatients(DataGridView dgv, string gender)
        {
            dgv.DataSource = daoPatient.GetMalePatients(gender);
        }
        public void ShowFemalePatients(DataGridView dgv, string gender)
        {
            dgv.DataSource = daoPatient.GetFemalePatients(gender);
        }
        public void SearchPatients(DataGridView dgv, string search)
        {
            dgv.DataSource = daoPatient.SearchPatients(search);
        }
        public int GetLength()
        {
            return daoPatient.GetLength();
        }
        public void ShowPatientInvoice(DataGridView dgv)
        {
            dgv.DataSource = daoPatient.GetPatientInvoice();
        }
    }
}
