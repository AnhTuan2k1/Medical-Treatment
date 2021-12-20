using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class BUS_SpecialistExamination
    {
        DAO_SpecialistExamination daoSpecialistExamination;

        public BUS_SpecialistExamination()
        {
            daoSpecialistExamination = DAO_SpecialistExamination.getInstance();
        }

        public bool Add(string name, string price)
        {
            try
            {
                daoSpecialistExamination.Add(name, price);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }
        public bool Remove(int id)
        {
            try
            {
                daoSpecialistExamination.Remove(id);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public void ShowSpecialistExamination(DataGridView dgv)
        {
            dgv.DataSource = daoSpecialistExamination.GetListSpecialistExamination();
        }

        public bool Edit(int id,string name, string price)
        {
            {
                try
                {
                    daoSpecialistExamination.Edit(id,name, price);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
            }
        }
    }
}
