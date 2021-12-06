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
            daoPatient = new DAO_Patient();
        }

        public void GetPatients(DataGridView dgv)
        {
            dgv.DataSource = daoPatient.GetPatients();
        }
    }
}
