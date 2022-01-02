using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace MedicalTreament.AdminForm
{
    public partial class StorageForm : Form
    {
        BUS_Drug bUS_Drug = new BUS_Drug();
        public StorageForm()
        {
            InitializeComponent();
            bUS_Drug = new BUS_Drug();
        }
        private void ShowDrugs()
        {
            dtgvAll.DataSource = null;
            bUS_Drug.ShowDrugs(dtgvAll);
            dtgvAll.Columns["DrugID"].Width = (int)(dtgvAll.Width * 0.1);
        }
        private void ShowNewestDrugs()
        {
            dtgvAll.DataSource = null;
            bUS_Drug.ShowNewestDrug(dtgvAll);
            dtgvAll.Columns["DrugID"].Width = (int)(dtgvAll.Width * 0.1);
        }
        private void ShowOralTablet()
        {
            dtgvAll.DataSource = null;
            bUS_Drug.ShowOralTablet(dtgvAll);
            dtgvAll.Columns["DrugID"].Width = (int)(dtgvAll.Width * 0.1);
        }
        private void ShowEffervescent()
        {
            dtgvAll.DataSource = null;
            bUS_Drug.ShowEffervescent(dtgvAll);
            dtgvAll.Columns["DrugID"].Width = (int)(dtgvAll.Width * 0.1);
        }
        private int ShowLength()
        {
            return bUS_Drug.ShowLength();
        }
        private void ShowImport()
        {
            dtgvImport.DataSource = null;
            bUS_Drug.ShowImport(dtgvImport);         
        }
        private void ShowExport()
        {
            dtgvExport.DataSource = null;
            bUS_Drug.ShowExport(dtgvExport);
        }
        private void ShowSearchDrug(string search)
        {
            dtgvAll.DataSource = null;
            bUS_Drug.ShowSeachDrug(dtgvAll,search);
            dtgvAll.Columns["DrugID"].Width = (int)(dtgvAll.Width * 0.1);
        }
        private void StorageForm_Load(object sender, EventArgs e)
        {
            ShowDrugs();
            ShowImport();
            ShowExport();
            lbStorage.Text = ShowLength().ToString();
        }

        private void cbbSortby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbSortby.SelectedIndex == 0)
            {
                ShowDrugs();
            }
            else
            {
                ShowNewestDrugs();
            }
        }

        private void cbbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbFilter.SelectedIndex == 0)
            {
                ShowOralTablet();
            }
            else
            {
                ShowEffervescent();
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            ShowSearchDrug(txbSearch.Text.ToString());
        }

        private void btRefreshAll_Click(object sender, EventArgs e)
        {
            ShowDrugs();
        }

        private void btRefreshImport_Click(object sender, EventArgs e)
        {
            ShowImport();
        }

        private void btRefreshExport_Click(object sender, EventArgs e)
        {
            ShowExport();
        }
    }
}
