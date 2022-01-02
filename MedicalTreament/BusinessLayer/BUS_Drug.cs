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

        public bool Add(string Name, decimal price, string producer, int quantity, string type, string unit, DateTime date)
        {
            try
            {
                daoDrug.Add(Name, price, producer, quantity, type, unit, date);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
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
            }
        }
        public int GetDrugID(string name)
        {
            int id = daoDrug.GetDrugID(name);
            return id;
        }
        public void ShowImport(DataGridView dgv)
        {
            dgv.DataSource = daoDrug.GetImport();
        }
        public void ShowExport(DataGridView dgv)
        {
            dgv.DataSource = daoDrug.GetExport();
        }
        public void ShowNewestDrug(DataGridView dgv)
        {
            dgv.DataSource = daoDrug.GetNewestDrug();
        }
        public void ShowOralTablet(DataGridView dgv)
        {
            dgv.DataSource = daoDrug.GetOralTablet();
        }
        public void ShowEffervescent(DataGridView dgv)
        {
            dgv.DataSource = daoDrug.GetEffervescent();
        }
        public void ShowSeachDrug(DataGridView dgv, string search)
        {
            dgv.DataSource = daoDrug.GetSearchDrug(search);
        }
        public int ShowLength()
        {
            return daoDrug.GetLength();
        }
    }
}
