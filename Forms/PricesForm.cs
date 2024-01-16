using BrightIdeasSoftware;
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

        private List<ProcessingPrice> ProcessingPrices = new List<ProcessingPrice>();
        private List<ProcessingPrice> FilteredProcessingPrices = new List<ProcessingPrice>();
        private DataTable pdt = new DataTable();
        public PricesForm(string workingDirectory)
        {
            //Įkainių supildymas į DataGridView
            InitializeComponent();
            this.Prices = new Prices(workingDirectory);
            InitializeData();
        }

        private void InitializeData()
        {
            this.Prices.Refresh();
            var workPricesData = Prices.GetWorkPrices();
            var materialPricesData = Prices.GetMaterialPrices();

            this.ProcessingPrices = Prices.GetProcessingPrices();

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

            //INITIALIZE PROCESSING PRICES TABLE
            this.pdt = new DataTable();
            this.pdt.Columns.Add(new DataColumn("Id", typeof(int)));
            this.pdt.Columns.Add(new DataColumn("Processing", typeof(string)));
            this.pdt.Columns.Add(new DataColumn("Material", typeof(string)));
            this.pdt.Columns.Add(new DataColumn("Type", typeof(string)));
            this.pdt.Columns.Add(new DataColumn("Supplier", typeof(string)));
            this.pdt.Columns.Add(new DataColumn("Property", typeof(double)));
            this.pdt.Columns.Add(new DataColumn("Value", typeof(double)));
            this.pdt.Columns.Add(new DataColumn("UpdatedAt", typeof(DateTime)));

            foreach (var item in this.ProcessingPrices)
            {
                this.pdt.Rows.Add(item.Id, item.Processing, item.Material, item.Type, item.Supplier, item.Property, item.Value, item.UpdatedAt);
            }

            this.processingDataGridView.DataSource = this.pdt;
            this.processingDataGridView.Columns["Id"].Visible = false;
            this.processingDataGridView.Columns["UpdatedAt"].ReadOnly = true;

            //Processing dropdowns
            var processings = Prices.GetDistinctProcessingColumnValues("Processing");
            var materials = Prices.GetDistinctProcessingColumnValues("Material");
            var types = Prices.GetDistinctProcessingColumnValues("Type");
            var suppliers = Prices.GetDistinctProcessingColumnValues("Supplier");

            processingComboBox.Items.Clear();
            materialComboBox.Items.Clear();
            typeComboBox.Items.Clear();
            supplierComboBox.Items.Clear();

            processingComboBox.Items.Add("");
            materialComboBox.Items.Add("");
            typeComboBox.Items.Add("");
            supplierComboBox.Items.Add("");
            foreach (var processing in processings)
            {
                processingComboBox.Items.Add(processing);
            }
            foreach (var material in materials)
            {
                materialComboBox.Items.Add(material);
            }
            foreach (var type in types)
            {
                typeComboBox.Items.Add(type);
            }
            foreach (var supplier in suppliers)
            {
                supplierComboBox.Items.Add(supplier);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var workPrices = Prices.GetWorkPrices();
            var materialPrices = Prices.GetMaterialPrices();
            foreach (DataGridViewRow row in workDataGridView.Rows)
            {
                SaveTableRow(row, workPrices, "WorkPrices");
            }
            foreach (DataGridViewRow row in materialDataGridView.Rows)
            {
                SaveTableRow(row, materialPrices, "MaterialPrices");
            }
            var processingData = Prices.GetProcessingPrices();
            foreach (DataGridViewRow row in processingDataGridView.Rows)
            {
                SaveProcessingTableRow(row, processingData);
            }
            InitializeData();
            //this.Close();
        }

        /// <summary>
        /// Compares if row was changed and saves changes
        /// </summary>
        /// <param name="row">data to be updated</param>
        /// <param name="allData">data to compare row changes with</param>
        /// <returns>true if saved, false if row was not changed</returns>
        private bool SaveTableRow(DataGridViewRow row, List<Price> allData, string tableName)
        {
            //jei yra naujų duomenų, išsaugoma į duomenų bazę
            if (row.Cells["Id"].Value == null)
            {
                return false;
            }

            int id = -1;
            int.TryParse(row.Cells["Id"].Value.ToString(), out id);
            var price = allData.FirstOrDefault(x => x.Id == id);

            if (price == null)
            {
                Prices.AddPrice(new Price(row.Cells["Name"].Value.ToString(),
                                     (double)row.Cells["Value"].Value), tableName);
                return true;
            }
            else if (!EqualPrices(price, row))
            {
                Prices.UpdatePrice(id, new Price(row.Cells["Name"].Value.ToString(),
                                            (double)row.Cells["Value"].Value), tableName);
                return true;
            }

            return false;
        }
        private bool SaveProcessingTableRow(DataGridViewRow row, List<ProcessingPrice> allData)
        {
            //jei yra naujų duomenų processing lenteleje, išsaugoma į duomenų bazę
            if (row.Cells["Id"].Value == null)
            {
                return false;
            }

            int id = -1;
            int.TryParse(row.Cells["Id"].Value.ToString(), out id);
            var price = allData.FirstOrDefault(x => x.Id == id);

            if (price == null)
            {   //Processing, Material, Type, Supplier, Property, Data
                Prices.AddProcessing(new ProcessingPrice(row.Cells["Processing"].Value.ToString(),
                                                         row.Cells["Material"].Value.ToString(),
                                                         row.Cells["Type"].Value.ToString(),
                                                         row.Cells["Supplier"].Value.ToString(),
                                                         (double)row.Cells["Property"].Value,
                                                         (double)row.Cells["Value"].Value));
                return true;
            }
            else if (!EqualProcessingPrices(price, row))
            {
                Prices.UpdateProcessing(id, new ProcessingPrice(row.Cells["Processing"].Value.ToString(),
                                                         row.Cells["Material"].Value.ToString(),
                                                         row.Cells["Type"].Value.ToString(),
                                                         row.Cells["Supplier"].Value.ToString(),
                                                         (double)row.Cells["Property"].Value,
                                                         (double)row.Cells["Value"].Value));
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
        private bool EqualProcessingPrices(ProcessingPrice price, DataGridViewRow row)
        {
            if(price.Processing == row.Cells["Processing"].Value.ToString() &&
               price.Material == row.Cells["Material"].Value.ToString() &&
               price.Type == row.Cells["Type"].Value.ToString() &&
               price.Supplier == row.Cells["Supplier"].Value.ToString() &&
               price.Property == (double)row.Cells["Property"].Value &&
               price.Value == (double)row.Cells["Value"].Value)
            {
                return true;
            }
            return false;
        }

        private void comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.FilteredProcessingPrices = 
                this.ProcessingPrices.Where(x => (processingComboBox.SelectedItem == null ||
                                                  processingComboBox.SelectedItem.ToString() == "" ||
                                                  processingComboBox.SelectedItem.ToString() == x.Processing) && (
                                                  materialComboBox.SelectedItem == null ||
                                                  materialComboBox.SelectedItem.ToString() == "" ||
                                                  materialComboBox.SelectedItem.ToString() == x.Material) && (
                                                  typeComboBox.SelectedItem == null ||
                                                  typeComboBox.SelectedItem.ToString() == "" ||
                                                  typeComboBox.SelectedItem.ToString() == x.Type) && (
                                                  supplierComboBox.SelectedItem == null ||
                                                  supplierComboBox.SelectedItem.ToString() == "" ||
                                                  supplierComboBox.SelectedItem.ToString() == x.Supplier)).ToList();
            this.pdt.Rows.Clear();
            foreach (var item in this.FilteredProcessingPrices)
            {
                this.pdt.Rows.Add(item.Id, item.Processing, item.Material, item.Type, item.Supplier, item.Property, item.Value, item.UpdatedAt);
            }
            this.processingDataGridView.DataSource = this.pdt;
            //this.processingDataGridView.Columns["Id"].Visible = false;
            //this.processingDataGridView.Columns["UpdatedAt"].ReadOnly = true;
        }
    }
}
