using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class BUS_Prescription
    {
        DAO_Prescription dao_Prescription;

        public BUS_Prescription()
        {
            dao_Prescription = DAO_Prescription.getInstance();
        }

        public bool AddPrescription(string txtInstruction, int idPatient, int idGP)
        {

            try
            {
                dao_Prescription.AddPrescription(txtInstruction, idPatient, idGP);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public int GetPrescriptionID(int idGP, int idPatient)
        {
            int id = dao_Prescription.GetPrescriptionID(idGP, idPatient);
            return id;
        }

        public int GetPrescriptionID(int idPatient)
        {
            try
            {
                int id = dao_Prescription.GetPrescriptionID(idPatient);
                return id;
            }
            catch (Exception)
            {
                return -1;
            }
           
        }
    }
}
