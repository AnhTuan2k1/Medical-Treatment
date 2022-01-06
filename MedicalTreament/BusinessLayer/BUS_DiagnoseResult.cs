using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BUS_DiagnoseResult
    {
        DAO_DiagnoseResult daoDiagnoseResult;

        public BUS_DiagnoseResult()
        {
            daoDiagnoseResult = DAO_DiagnoseResult.getInstance();
        }

        public bool Add(string txtDiagnoseResult, string txtDirection, int idEx, int idPatient, int idGP)
        {
            try
            {
                daoDiagnoseResult.Add(txtDiagnoseResult, txtDirection,idEx,idPatient,idGP);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string GetResult(int patientID)
        {
            try
            {
                return daoDiagnoseResult.GetResult(patientID);

            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
