using Janitor_V1.Models;
using Janitor_V1.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Janitor_V1.Forms
{
    public partial class DeviceForm : Form
    {
        private Device Device;
        private List<Node> List { set; get; }
        private Prices Prices { get; set; }
        private Calculations Calculations { get; set; }
        private Action UpdateDeviceFields { set; get; }
        public DeviceForm(string workingDirectory, Device device, List<Node> list, Calculations calculations, Action updateDeviceFields)
        {
            this.Device = device;
            this.List = list;
            this.Prices = new Prices(workingDirectory);
            this.Calculations = calculations;
            this.UpdateDeviceFields = updateDeviceFields;

            InitializeComponent();
            InitializeData();
        }

        public void InitializeData()
        {
            //design tab
            if(Device.DesigningCostWithoutVAT == 0)
            {
                this.Device.DesigningCostWithoutVAT = this.Prices.GetById(1).Value;
            }
            this.designingCostTextBox.Text = this.Device.DesigningCostWithoutVAT.ToString();

            this.plannedDesignDurationTextBox.Text = this.Device.PlannedDesigningDuration.ToString();

            this.Device.DesigningTotalPrice = this.Device.DesigningCostWithoutVAT * this.Device.PlannedDesigningDuration;
            this.calculatedDesigningCostTextBox.Text = this.Device.DesigningTotalPrice.ToString();


            //welding tab
            if (Device.WeldingCostWithoutVAT == 0)
            {
                this.Device.WeldingCostWithoutVAT = this.Prices.GetById(2).Value;
            }
            this.weldingCostTextBox.Text = this.Device.WeldingCostWithoutVAT.ToString();

            this.Device.PlannedWeldingDuration = this.Calculations.CountTotalWeldingDuration(this.List);
            this.plannedWeldingDurationTextBox.Text = this.Device.PlannedWeldingDuration.ToString();

            this.Device.WeldingTotalPrice = this.Device.WeldingCostWithoutVAT * this.Device.PlannedWeldingDuration;
            this.calculatedWeldingCostTextBox.Text = this.Device.WeldingTotalPrice.ToString();

            //assembly and packing tab
            if (Device.WorkManagementCost == 0)
            {
                this.Device.WorkManagementCost = this.Prices.GetById(4).Value;
            }
            this.workManagementCostTextBox.Text = this.Device.WorkManagementCost.ToString();

            this.totalWorkManagementDurationTextBox.Text = this.Device.TotalWorkManagementDuration.ToString();

            this.workManagementTotalCostTextBox.Text = this.Device.WorkManagementTotalCost.ToString();
            //-------------------------
            if (Device.SupplyCost == 0)
            {
                this.Device.SupplyCost = this.Prices.GetById(6).Value;
            }
            this.supplyCostTextBox.Text = this.Device.SupplyCost.ToString();

            this.totalSupplyDurationTextBox.Text = this.Device.TotalSupplyDuration.ToString();

            this.supplyTotalCostTextBox.Text = this.Device.SupplyTotalCost.ToString();
            //-------------------------
            if (Device.AssemblyCost == 0)
            {
                this.Device.AssemblyCost = this.Prices.GetById(3).Value;
            }
            this.assemblyCostTextBox.Text = this.Device.SupplyCost.ToString();

            this.individualComponentsAssemblyTextBox.Text = this.Device.IndividualComponentsAssembly.ToString();

            this.assemblyToParentDurationTextBox.Text = this.Device.AssemblyToParentDuration.ToString();

            this.childNodeAssemblyDurationTextBox.Text = this.Device.ChildNodeAssemblyDuration.ToString();

            this.totalAssemblyDurationTextBox.Text = this.Device.TotalAssemblyDuration.ToString();

            this.assemblyTotalCostTextBox.Text = this.Device.AssemblyTotalCost.ToString();
            //-------------------------
            if (Device.PackingCost == 0)
            {
                this.Device.PackingCost = this.Prices.GetById(8).Value;
            }
            this.packingCostTextBox.Text = this.Device.PackingCost.ToString();

            this.totalPackagingDurationTextBox.Text = this.Device.TotalPackagingDuration.ToString();

            this.packagingMaterialCostTextBox.Text = this.Device.PackagingMaterialCost.ToString();

            this.packagingTotalCostTextBox.Text = this.Device.PackagingTotalCost.ToString();


            //footer
            this.Device.TotalPrice = this.Device.AmountOfDevices *
                                        (this.Device.WeldingTotalPrice +
                                         this.Device.AssemblyTotalCost +
                                         this.Device.PackagingTotalCost) +
                                     this.Device.DesigningTotalPrice +
                                     this.Device.WorkManagementTotalCost +
                                     this.Device.SupplyTotalCost;

            this.amountOfDevicesTextBox.Text = this.Device.AmountOfDevices.ToString();
            this.totalDeviceCostTextBox.Text = this.Device.TotalPrice.ToString();

        }

        private void SaveDevice()
        {
            double tempDouble = 0;
            int tempInt = 0;

            //design tab
            if (double.TryParse(this.plannedDesignDurationTextBox.Text, out tempDouble))
            {
                this.Device.PlannedDesigningDuration = tempDouble;
            }

            if (double.TryParse(this.designingCostTextBox.Text, out tempDouble))
            {
                this.Device.DesigningCostWithoutVAT = tempDouble;
            }

            this.Device.DesigningTotalPrice = this.Device.DesigningCostWithoutVAT * this.Device.PlannedDesigningDuration;
            this.calculatedDesigningCostTextBox.Text = this.Device.DesigningTotalPrice.ToString();

            //welding tab
            if (double.TryParse(this.weldingCostTextBox.Text, out tempDouble))
            {
                this.Device.WeldingCostWithoutVAT = tempDouble;
            }
            
            this.Device.WeldingTotalPrice = this.Device.WeldingCostWithoutVAT * this.Device.PlannedWeldingDuration;
            this.calculatedWeldingCostTextBox.Text = this.Device.WeldingTotalPrice.ToString();

            //assembly
            if (double.TryParse(this.workManagementCostTextBox.Text, out tempDouble))
            {
                this.Device.WorkManagementCost = tempDouble;
            }
            
            if (double.TryParse(this.totalWorkManagementDurationTextBox.Text, out tempDouble))
            {
                this.Device.TotalWorkManagementDuration = tempDouble;
            }

            this.Device.WorkManagementTotalCost = this.Device.WorkManagementCost * this.Device.TotalWorkManagementDuration;
            this.workManagementTotalCostTextBox.Text = this.Device.WorkManagementTotalCost.ToString();
            //-------------------------
            if (double.TryParse(this.supplyCostTextBox.Text, out tempDouble))
            {
                this.Device.SupplyCost = tempDouble;
            }
            
            if (double.TryParse(this.totalSupplyDurationTextBox.Text, out tempDouble))
            {
                this.Device.TotalSupplyDuration = tempDouble;
            }

            this.Device.SupplyTotalCost = this.Device.SupplyCost * this.Device.TotalSupplyDuration;
            this.supplyTotalCostTextBox.Text = this.Device.SupplyTotalCost.ToString();
            //-------------------------
            if (double.TryParse(this.individualComponentsAssemblyTextBox.Text, out tempDouble))
            {
                this.Device.IndividualComponentsAssembly = tempDouble;
            }
            
            if (double.TryParse(this.assemblyToParentDurationTextBox.Text, out tempDouble))
            {
                this.Device.AssemblyToParentDuration = tempDouble;
            }

            this.Device.TotalAssemblyDuration = this.Device.ChildNodeAssemblyDuration + this.Device.IndividualComponentsAssembly + this.Device.AssemblyToParentDuration;
            this.totalAssemblyDurationTextBox.Text = this.Device.TotalAssemblyDuration.ToString();

            if (double.TryParse(this.assemblyCostTextBox.Text, out tempDouble))
            {
                this.Device.AssemblyCost = tempDouble;
            }

            this.Device.AssemblyTotalCost = this.Device.AssemblyCost * this.Device.TotalAssemblyDuration;
            this.assemblyTotalCostTextBox.Text = this.Device.AssemblyTotalCost.ToString();
            //-------------------------
            if (double.TryParse(this.totalPackagingDurationTextBox.Text, out tempDouble))
            {
                this.Device.TotalPackagingDuration = tempDouble;
            }
            
            if (double.TryParse(this.packingCostTextBox.Text, out tempDouble))
            {
                this.Device.PackingCost = tempDouble;
            }
            
            if (double.TryParse(this.packagingMaterialCostTextBox.Text, out tempDouble))
            {
                this.Device.PackagingMaterialCost = tempDouble;
            }

            this.Device.PackagingTotalCost = (this.Device.PackingCost * this.Device.TotalPackagingDuration) + this.Device.PackagingMaterialCost;
            this.packagingTotalCostTextBox.Text = this.Device.PackagingTotalCost.ToString();

            //footer
            if (int.TryParse(this.amountOfDevicesTextBox.Text, out tempInt))
            {
                this.Device.AmountOfDevices = tempInt;
            }

            this.Device.TotalPrice = this.Device.AmountOfDevices *
                                        (this.Device.WeldingTotalPrice +
                                         this.Device.AssemblyTotalCost +
                                         this.Device.PackagingTotalCost) +
                                     this.Device.DesigningTotalPrice +
                                     this.Device.WorkManagementTotalCost +
                                     this.Device.SupplyTotalCost;

            this.totalDeviceCostTextBox.Text = this.Device.TotalPrice.ToString();


            UpdateDeviceFields();
        }

        private void numbersOnlyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            double count = 0;
            if ((e.KeyChar == '.'))
            {
                e.KeyChar = ',';
            }

            if (!((char.IsDigit(e.KeyChar) && double.TryParse((sender as TextBox).Text + e.KeyChar, out count) && count >= 0) ||
                (e.KeyChar == '\b') ||
                (e.KeyChar == ',')))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void integersOnlyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int count = 0;
            if (!((char.IsDigit(e.KeyChar) && int.TryParse((sender as TextBox).Text + e.KeyChar, out count) && count >= 0) ||
                (e.KeyChar == '\b')))
            {
                e.Handled = true;
            }
        }

        private void textBox_TextChanged(object sender, System.EventArgs e)
        {
            SaveDevice();
        }

        private void DeviceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDevice();
        }
    }
}
