using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class BUS_SpecialistExaminationResult
    {
        DAO_SpecialistExaminationResult daoSEresult;

        public BUS_SpecialistExaminationResult()
        {
            daoSEresult = DAO_SpecialistExaminationResult.getInstance();
        }

        public bool Add(string result, string conclusion, int idSE, int idPatient, int idSP)
        {
            try
            {
                daoSEresult.Add(result, conclusion, idSE, idPatient, idSP);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public void Show(DataGridView dgv, int patientID)
        {
            try
            {
                dgv.DataSource = daoSEresult.Get(patientID);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
