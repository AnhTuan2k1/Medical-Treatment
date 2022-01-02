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
        public void ShowEmployee(DataGridView dgv)
        {
            dgv.DataSource = daoEmployee.GetEmployee();
        }
        public void ShowNewestEmployee(DataGridView dgv)
        {
            dgv.DataSource = daoEmployee.GetNewestEmployee();
        }
        public void ShowSalaryOver(DataGridView dgv)
        {
            dgv.DataSource = daoEmployee.GetSalaryOver();
        }
        public void ShowSalryUnder(DataGridView dgv)
        {
            dgv.DataSource = daoEmployee.GetSalaryUnder();
        }
        public void ShowSearchEmployee(DataGridView dgv, string search)
        {
            dgv.DataSource = daoEmployee.GetSearchEmployee(search);
        }
        public int ShowLength()
        {
            return daoEmployee.GetLength();
        }
        public bool AddEmployee(string name, string position, string email, decimal salary)
        {

            try
            {
                daoEmployee.AddEmloyee(name, position, email, salary);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        public int GetEmployeeID(string name, string email)
        {
            int id = daoEmployee.GetEmployeeID(name, email);
            return id;
        }

        public bool EditEmployee(int employeeid, string name, string position, string email, decimal salary)
        {

            try
            {
                daoEmployee.EditEmployee(employeeid, name, position, email, salary);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool DeleteEmployee(int employeeid)
        {

            try
            {
                daoEmployee.DeleteEmployee(employeeid);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
