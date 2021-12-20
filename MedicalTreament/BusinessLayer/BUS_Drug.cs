using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace BusinessLayer
{
    public class BUS_Drug
    {
        DAO_Drug daoDrug;

        public BUS_Drug()
        {
            daoDrug = DAO_Drug.getInstance();
        }

        public void Add(string Name, decimal price, string producer, int quantity, string type, string unit, DateTime date)
        {
            daoDrug.Add(Name, price, producer, quantity, type, unit, date);
        }

        public void ShowDrugs(DataGridView dgv)
        {
            dgv.DataSource = daoDrug.GetDrug();
        }

        public bool EditDrug(int id, string name, string producer, DateTime ExprirationDate, 
            string unit, decimal price, int quantity, string type)
        {
            try
            {
                daoDrug.Edit(id, name, producer, ExprirationDate,
                    unit, price, quantity, type);

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }          

        }

        public bool Delete(int drugID)
        {
            try
            {
                daoDrug.Delete(drugID);

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
