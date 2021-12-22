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

        public void ShowUnPayPatients(ComboBox combo)
        {
            combo.DataSource = daoExaminationForm.GetUnPayPatients();
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
        public string GetReason(int PatientID)
        {
            string reason = daoExaminationForm.GetReason(PatientID);
            return reason;
        }
    }
}
