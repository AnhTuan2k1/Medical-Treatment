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
    }
}
