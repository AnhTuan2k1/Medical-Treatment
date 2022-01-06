using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace BusinessLayer
{
    public class BUS_ExaminationForm
    {
        DAO_ExaminationForm daoExaminationForm;

        public BUS_ExaminationForm()
        {
            daoExaminationForm = DAO_ExaminationForm.getInstance();
        }

        public int CountExFormToday()
        {
            try
            {               
                return daoExaminationForm.CountExFormToday();
            }
            catch (Exception)
            {
                return 0;
            } 
        }

        public bool IsExaminatinate(int patientID)
        {
            try
            {
                if (daoExaminationForm.IsExaminatinate(patientID))
                    return true;
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public void ShowUnPayPatients(DataGridView dgv)
        {
            dgv.DataSource = daoExaminationForm.GetUnPayPatients();
        }

        public void ShowUnPayPatients(DataGridView dgv, string namePatient)
        {
            dgv.DataSource = daoExaminationForm.GetUnPayPatients(namePatient);
        }

        public void ShowUnPayPatients(ComboBox combo)
        {
            combo.DataSource = daoExaminationForm.GetUnPayPatients();
        }

        public void GetPatientsAt(DataGridView dgv, string place = "inGP")
        {
            dgv.DataSource = daoExaminationForm.GetPatientsAt(place);
        }

        public void GetPatientsAt(ComboBox combo, string place = "inGP")
        {
            combo.DataSource = daoExaminationForm.GetPatientsAt(place);
        }

        public bool Add(int ordinal, int patientid, int secretaryID, decimal price, string reason = "")
        {
            try
            {
                daoExaminationForm.Add(ordinal, patientid, secretaryID, price, reason);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public bool SetPaid(int patientID)
        {
            try
            {
                daoExaminationForm.SetPaid(patientID);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public string GetReason(int PatientID)
        {
            string reason = daoExaminationForm.GetReason(PatientID);
            return reason;
        }

        public int GetFee(int patientID)
        {
            try
            {
                
                return daoExaminationForm.GetFee(patientID);
            }
            catch (Exception)
            {
                return 10000;
            }
        }

        public int GetId(int idPatient)
        {
            int id = daoExaminationForm.GetId(idPatient);
            return id;
        }

        public void SetState(int idPatient, string text)
        {
            daoExaminationForm.SetState(idPatient, text);
        }
    }
}
