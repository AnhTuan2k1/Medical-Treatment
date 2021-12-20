using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace BusinessLayer
{
    public class BUS_Employee
    {
        DAO_Employee daoEmployee;

        public BUS_Employee()
        {
            daoEmployee = DAO_Employee.getInstance();
        }

        public void ShowGP(ComboBox combo)
        {
            combo.DataSource = daoEmployee.GetGP();
        }

    }
}
