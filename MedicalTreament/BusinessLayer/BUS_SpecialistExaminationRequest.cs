using System;
using DataLayer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class BUS_SpecialistExaminationRequest
    {
        DAO_SpecialistExaminationRequest dao_SpecialistExaminationRequest;

        public BUS_SpecialistExaminationRequest()
        {
            dao_SpecialistExaminationRequest = DAO_SpecialistExaminationRequest.getInstance();
        }

        public bool Add(int idSE, int idPatient, int idGP)
        {
            try
            {
                dao_SpecialistExaminationRequest.Add(idSE, idPatient, idGP);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void ShowSErequest(DataGridView dgv, int idPatient)
        {
            dgv.DataSource = dao_SpecialistExaminationRequest.ShowSErequest(idPatient);
        }
    }
}
