using Janitor_V1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Janitor_V1
{
    public partial class PricesForm : Form
    {
        private Prices Prices { get; set; }
        public PricesForm(string workingDirectory)
        {
            InitializeComponent();
            this.Prices = new Prices(workingDirectory);
            this.Prices.Refresh();
            var workPricesData = Prices.GetWorkPrices();
            var materialPricesData = Prices.GetMaterialPrices();

            //INITIALIZE WORK PRICES TABLE
            DataTable wdt = new DataTable();
            wdt.Columns.Add(new DataColumn("Id", typeof(int)));
            wdt.Columns.Add(new DataColumn("Name", typeof(string)));
            wdt.Columns.Add(new DataColumn("Value", typeof(double)));
            wdt.Columns.Add(new DataColumn("UpdatedAt", typeof(DateTime)));

            //dt.Columns["colStatus"].Expression = String.Format("IIF(colBestBefore < #{0}#, 'Ok','Not ok')", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            foreach (var item in workPricesData)
            {
                wdt.Rows.Add(item.Id, item.Name, item.Value, item.UpdatedAt);
            }

            this.workDataGridView.DataSource = wdt;
            this.workDataGridView.Columns["Id"].Visible = false;
            this.workDataGridView.Columns["UpdatedAt"].ReadOnly = true;
            //this.dataGridView1.DataSource = prices.Get();

            //INITIALIZE MATERIAL PRICES TABLE
            DataTable mdt = new DataTable();
            mdt.Columns.Add(new DataColumn("Id", typeof(int)));
            mdt.Columns.Add(new DataColumn("Name", typeof(string)));
            mdt.Columns.Add(new DataColumn("Value", typeof(double)));
            mdt.Columns.Add(new DataColumn("UpdatedAt", typeof(DateTime)));

            foreach (var item in materialPricesData)
            {
                mdt.Rows.Add(item.Id, item.Name, item.Value, item.UpdatedAt);
            }

            this.materialDataGridView.DataSource = mdt;
            this.materialDataGridView.Columns["Id"].Visible = false;
            this.materialDataGridView.Columns["UpdatedAt"].ReadOnly = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var data = Prices.GetAllPrices();
            foreach (DataGridViewRow row in workDataGridView.Rows)
            {
                SaveTableRow(row, data, "Darbo");
            }
            foreach (DataGridViewRow row in materialDataGridView.Rows)
            {
                SaveTableRow(row, data, "Žaliavų");
            }
            this.Close();
        }

        /// <summary>
        /// Compares if row was changed and saves changes
        /// </summary>
        /// <param name="row">data to be updated</param>
        /// <param name="allData">data to compare row changes with</param>
        /// <returns>true if saved, false if row was not changed</returns>
        private bool SaveTableRow(DataGridViewRow row, List<Price> allData, string priceGroup)
        {
            if (row.Cells["Id"].Value == null)
            {
                return false;
            }

            int id = -1;
            int.TryParse(row.Cells["Id"].Value.ToString(), out id);
            var price = allData.FirstOrDefault(x => x.Id == id);

            if (price == null)
            {
                Prices.Add(new Price(row.Cells["Name"].Value.ToString(),
                                     (double)row.Cells["Value"].Value,
                                     priceGroup));
                return true;
            }
            else if (!EqualPrices(price, row))
            {
                Prices.Update(id, new Price(row.Cells["Name"].Value.ToString(),
                                            (double)row.Cells["Value"].Value,
                                            priceGroup));
                return true;
            }

            return false;
        }

        private bool EqualPrices(Price price, DataGridViewRow row)
        {
            if(price.Name == row.Cells["Name"].Value.ToString() &&
               price.Value == (double)row.Cells["Value"].Value)
            {
                return true;
            }
            return false;
        }
    }
}
