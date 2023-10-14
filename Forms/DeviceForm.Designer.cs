using System.Windows.Forms;

namespace Janitor_V1.Forms
{
    partial class DeviceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.designingTabPage = new System.Windows.Forms.TabPage();
            this.calculatedDesigningCostTextBox = new System.Windows.Forms.TextBox();
            this.designingCostTextBox = new System.Windows.Forms.TextBox();
            this.plannedDesignDurationTextBox = new System.Windows.Forms.TextBox();
            this.calculatedDesigningCostLabel = new System.Windows.Forms.Label();
            this.designingCostLabel = new System.Windows.Forms.Label();
            this.plannedDesignDurationLabel = new System.Windows.Forms.Label();
            this.weldingTabPage = new System.Windows.Forms.TabPage();
            this.calculatedWeldingCostTextBox = new System.Windows.Forms.TextBox();
            this.weldingCostTextBox = new System.Windows.Forms.TextBox();
            this.plannedWeldingDurationTextBox = new System.Windows.Forms.TextBox();
            this.calculatedWeldingCostLabel = new System.Windows.Forms.Label();
            this.weldingCostLabel = new System.Windows.Forms.Label();
            this.plannedWeldingDurationLabel = new System.Windows.Forms.Label();
            this.assemblyAndPackagingTabPage = new System.Windows.Forms.TabPage();
            this.packagingPanelLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.packagingTotalCostLabel = new System.Windows.Forms.Label();
            this.packagingMaterialCostTextBox = new System.Windows.Forms.TextBox();
            this.packagingMaterialCostLabel = new System.Windows.Forms.Label();
            this.packagingTotalCostTextBox = new System.Windows.Forms.TextBox();
            this.packingCostTextBox = new System.Windows.Forms.TextBox();
            this.totalPackagingDurationTextBox = new System.Windows.Forms.TextBox();
            this.packingCostLabel = new System.Windows.Forms.Label();
            this.totalPackagingDurationLabel = new System.Windows.Forms.Label();
            this.assemblyPanelLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.assemblyTotalCostLabel = new System.Windows.Forms.Label();
            this.totalAssemblyDurationTextBox = new System.Windows.Forms.TextBox();
            this.totalAssemblyDurationLabel = new System.Windows.Forms.Label();
            this.individualComponentsAssemblyTextBox = new System.Windows.Forms.TextBox();
            this.individualComponentsAssemblyLabel = new System.Windows.Forms.Label();
            this.assemblyToParentDurationTextBox = new System.Windows.Forms.TextBox();
            this.assemblyToParentDurationLabel = new System.Windows.Forms.Label();
            this.assemblyTotalCostTextBox = new System.Windows.Forms.TextBox();
            this.assemblyCostTextBox = new System.Windows.Forms.TextBox();
            this.childNodeAssemblyDurationTextBox = new System.Windows.Forms.TextBox();
            this.assemblyCostLabel = new System.Windows.Forms.Label();
            this.childNodeAssemblyDurationLabel = new System.Windows.Forms.Label();
            this.supplyPanelLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.supplyTotalCostLabel = new System.Windows.Forms.Label();
            this.supplyTotalCostTextBox = new System.Windows.Forms.TextBox();
            this.supplyCostTextBox = new System.Windows.Forms.TextBox();
            this.totalSupplyDurationTextBox = new System.Windows.Forms.TextBox();
            this.supplyCostLabel = new System.Windows.Forms.Label();
            this.totalSupplyDurationLabel = new System.Windows.Forms.Label();
            this.workManagementPanelLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.workManagementTotalCostLabel = new System.Windows.Forms.Label();
            this.workManagementTotalCostTextBox = new System.Windows.Forms.TextBox();
            this.workManagementCostTextBox = new System.Windows.Forms.TextBox();
            this.totalWorkManagementDurationTextBox = new System.Windows.Forms.TextBox();
            this.workManagementCostLabel = new System.Windows.Forms.Label();
            this.totalWorkManagementDurationLabel = new System.Windows.Forms.Label();
            this.partsTabPage = new System.Windows.Forms.TabPage();
            this.totalPartsAndToolboxCostLabel = new System.Windows.Forms.Label();
            this.totalPartsAndToolboxCostTextBox = new System.Windows.Forms.TextBox();
            this.totalToolboxWeightLabel = new System.Windows.Forms.Label();
            this.totalToolboxWeightTextBox = new System.Windows.Forms.TextBox();
            this.totalToolboxCostLabel = new System.Windows.Forms.Label();
            this.totalToolboxCostTextBox = new System.Windows.Forms.TextBox();
            this.numberOfPartsLabel = new System.Windows.Forms.Label();
            this.numberOfPartsTextBox = new System.Windows.Forms.TextBox();
            this.totalPartsCostLabel = new System.Windows.Forms.Label();
            this.totalPartsCostTextBox = new System.Windows.Forms.TextBox();
            this.otherCostsTabPage = new System.Windows.Forms.TabPage();
            this.otherCostsTextBox = new System.Windows.Forms.TextBox();
            this.otherCostsDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.otherCostsDescriptionLabel = new System.Windows.Forms.Label();
            this.otherCostsLabel = new System.Windows.Forms.Label();
            this.amountOfDevicesTextBox = new System.Windows.Forms.TextBox();
            this.totalDeviceCostLabel = new System.Windows.Forms.Label();
            this.amountOfDevicesLabel = new System.Windows.Forms.Label();
            this.totalDeviceCostTextBox = new System.Windows.Forms.TextBox();
            this.saveToSolidworksButton = new System.Windows.Forms.Button();
            this.totalDeviceHoursTextBox = new System.Windows.Forms.TextBox();
            this.totalDeviceHoursLabel = new System.Windows.Forms.Label();
            this.calculatedDesigningCost1Label = new System.Windows.Forms.Label();
            this.calculatedAssemblyTabCostLabel = new System.Windows.Forms.Label();
            this.calculatedWeldingCost1Label = new System.Windows.Forms.Label();
            this.totalPartsAndToolboxCost1Label = new System.Windows.Forms.Label();
            this.calculatedDesigningCost1TextBox = new System.Windows.Forms.TextBox();
            this.calculatedWeldingCost1TextBox = new System.Windows.Forms.TextBox();
            this.calculatedAssemblyTabCostTextBox = new System.Windows.Forms.TextBox();
            this.otherCosts1TextBox = new System.Windows.Forms.TextBox();
            this.totalPartsAndToolboxCost1TextBox = new System.Windows.Forms.TextBox();
            this.otherCostsForOneDevice1Label = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.designingTabPage.SuspendLayout();
            this.weldingTabPage.SuspendLayout();
            this.assemblyAndPackagingTabPage.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.partsTabPage.SuspendLayout();
            this.otherCostsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.designingTabPage);
            this.tabControl1.Controls.Add(this.weldingTabPage);
            this.tabControl1.Controls.Add(this.assemblyAndPackagingTabPage);
            this.tabControl1.Controls.Add(this.partsTabPage);
            this.tabControl1.Controls.Add(this.otherCostsTabPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(674, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // designingTabPage
            // 
            this.designingTabPage.Controls.Add(this.calculatedDesigningCostTextBox);
            this.designingTabPage.Controls.Add(this.designingCostTextBox);
            this.designingTabPage.Controls.Add(this.plannedDesignDurationTextBox);
            this.designingTabPage.Controls.Add(this.calculatedDesigningCostLabel);
            this.designingTabPage.Controls.Add(this.designingCostLabel);
            this.designingTabPage.Controls.Add(this.plannedDesignDurationLabel);
            this.designingTabPage.Location = new System.Drawing.Point(4, 22);
            this.designingTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.designingTabPage.Name = "designingTabPage";
            this.designingTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.designingTabPage.Size = new System.Drawing.Size(666, 430);
            this.designingTabPage.TabIndex = 0;
            this.designingTabPage.Text = "Designing";
            this.designingTabPage.UseVisualStyleBackColor = true;
            // 
            // calculatedDesigningCostTextBox
            // 
            this.calculatedDesigningCostTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.calculatedDesigningCostTextBox.Enabled = false;
            this.calculatedDesigningCostTextBox.Location = new System.Drawing.Point(247, 117);
            this.calculatedDesigningCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.calculatedDesigningCostTextBox.Name = "calculatedDesigningCostTextBox";
            this.calculatedDesigningCostTextBox.Size = new System.Drawing.Size(68, 20);
            this.calculatedDesigningCostTextBox.TabIndex = 15;
            this.calculatedDesigningCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // designingCostTextBox
            // 
            this.designingCostTextBox.Location = new System.Drawing.Point(247, 81);
            this.designingCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.designingCostTextBox.Name = "designingCostTextBox";
            this.designingCostTextBox.Size = new System.Drawing.Size(68, 20);
            this.designingCostTextBox.TabIndex = 14;
            this.designingCostTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.designingCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // plannedDesignDurationTextBox
            // 
            this.plannedDesignDurationTextBox.Location = new System.Drawing.Point(247, 20);
            this.plannedDesignDurationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.plannedDesignDurationTextBox.Name = "plannedDesignDurationTextBox";
            this.plannedDesignDurationTextBox.Size = new System.Drawing.Size(68, 20);
            this.plannedDesignDurationTextBox.TabIndex = 12;
            this.plannedDesignDurationTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.plannedDesignDurationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // calculatedDesigningCostLabel
            // 
            this.calculatedDesigningCostLabel.AutoSize = true;
            this.calculatedDesigningCostLabel.Location = new System.Drawing.Point(12, 119);
            this.calculatedDesigningCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.calculatedDesigningCostLabel.Name = "calculatedDesigningCostLabel";
            this.calculatedDesigningCostLabel.Size = new System.Drawing.Size(212, 15);
            this.calculatedDesigningCostLabel.TabIndex = 11;
            this.calculatedDesigningCostLabel.Text = "Calculated designing total cost, €/unit:";
            // 
            // designingCostLabel
            // 
            this.designingCostLabel.AutoSize = true;
            this.designingCostLabel.Location = new System.Drawing.Point(12, 83);
            this.designingCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.designingCostLabel.Name = "designingCostLabel";
            this.designingCostLabel.Size = new System.Drawing.Size(196, 15);
            this.designingCostLabel.TabIndex = 10;
            this.designingCostLabel.Text = "Designing cost EUR/h without VAT:";
            // 
            // plannedDesignDurationLabel
            // 
            this.plannedDesignDurationLabel.AutoSize = true;
            this.plannedDesignDurationLabel.Location = new System.Drawing.Point(12, 22);
            this.plannedDesignDurationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.plannedDesignDurationLabel.Name = "plannedDesignDurationLabel";
            this.plannedDesignDurationLabel.Size = new System.Drawing.Size(161, 15);
            this.plannedDesignDurationLabel.TabIndex = 8;
            this.plannedDesignDurationLabel.Text = "Planned designing duration:";
            // 
            // weldingTabPage
            // 
            this.weldingTabPage.Controls.Add(this.calculatedWeldingCostTextBox);
            this.weldingTabPage.Controls.Add(this.weldingCostTextBox);
            this.weldingTabPage.Controls.Add(this.plannedWeldingDurationTextBox);
            this.weldingTabPage.Controls.Add(this.calculatedWeldingCostLabel);
            this.weldingTabPage.Controls.Add(this.weldingCostLabel);
            this.weldingTabPage.Controls.Add(this.plannedWeldingDurationLabel);
            this.weldingTabPage.Location = new System.Drawing.Point(4, 22);
            this.weldingTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.weldingTabPage.Name = "weldingTabPage";
            this.weldingTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.weldingTabPage.Size = new System.Drawing.Size(666, 430);
            this.weldingTabPage.TabIndex = 1;
            this.weldingTabPage.Text = "Welding";
            this.weldingTabPage.UseVisualStyleBackColor = true;
            // 
            // calculatedWeldingCostTextBox
            // 
            this.calculatedWeldingCostTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.calculatedWeldingCostTextBox.Enabled = false;
            this.calculatedWeldingCostTextBox.Location = new System.Drawing.Point(223, 109);
            this.calculatedWeldingCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.calculatedWeldingCostTextBox.Name = "calculatedWeldingCostTextBox";
            this.calculatedWeldingCostTextBox.Size = new System.Drawing.Size(68, 20);
            this.calculatedWeldingCostTextBox.TabIndex = 15;
            this.calculatedWeldingCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // weldingCostTextBox
            // 
            this.weldingCostTextBox.Location = new System.Drawing.Point(223, 75);
            this.weldingCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.weldingCostTextBox.Name = "weldingCostTextBox";
            this.weldingCostTextBox.Size = new System.Drawing.Size(68, 20);
            this.weldingCostTextBox.TabIndex = 14;
            this.weldingCostTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.weldingCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // plannedWeldingDurationTextBox
            // 
            this.plannedWeldingDurationTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.plannedWeldingDurationTextBox.Enabled = false;
            this.plannedWeldingDurationTextBox.Location = new System.Drawing.Point(223, 23);
            this.plannedWeldingDurationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.plannedWeldingDurationTextBox.Name = "plannedWeldingDurationTextBox";
            this.plannedWeldingDurationTextBox.Size = new System.Drawing.Size(68, 20);
            this.plannedWeldingDurationTextBox.TabIndex = 12;
            this.plannedWeldingDurationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // calculatedWeldingCostLabel
            // 
            this.calculatedWeldingCostLabel.AutoSize = true;
            this.calculatedWeldingCostLabel.Location = new System.Drawing.Point(16, 111);
            this.calculatedWeldingCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.calculatedWeldingCostLabel.Name = "calculatedWeldingCostLabel";
            this.calculatedWeldingCostLabel.Size = new System.Drawing.Size(198, 15);
            this.calculatedWeldingCostLabel.TabIndex = 11;
            this.calculatedWeldingCostLabel.Text = "Calculated welding total cost €/unit:";
            // 
            // weldingCostLabel
            // 
            this.weldingCostLabel.AutoSize = true;
            this.weldingCostLabel.Location = new System.Drawing.Point(16, 77);
            this.weldingCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weldingCostLabel.Name = "weldingCostLabel";
            this.weldingCostLabel.Size = new System.Drawing.Size(188, 15);
            this.weldingCostLabel.TabIndex = 10;
            this.weldingCostLabel.Text = "Welding cost, EUR/h without VAT:";
            // 
            // plannedWeldingDurationLabel
            // 
            this.plannedWeldingDurationLabel.AutoSize = true;
            this.plannedWeldingDurationLabel.Location = new System.Drawing.Point(16, 25);
            this.plannedWeldingDurationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.plannedWeldingDurationLabel.Name = "plannedWeldingDurationLabel";
            this.plannedWeldingDurationLabel.Size = new System.Drawing.Size(143, 15);
            this.plannedWeldingDurationLabel.TabIndex = 8;
            this.plannedWeldingDurationLabel.Text = "Planned wlding duration:";
            // 
            // assemblyAndPackagingTabPage
            // 
            this.assemblyAndPackagingTabPage.Controls.Add(this.packagingPanelLabel);
            this.assemblyAndPackagingTabPage.Controls.Add(this.panel4);
            this.assemblyAndPackagingTabPage.Controls.Add(this.assemblyPanelLabel);
            this.assemblyAndPackagingTabPage.Controls.Add(this.panel3);
            this.assemblyAndPackagingTabPage.Controls.Add(this.supplyPanelLabel);
            this.assemblyAndPackagingTabPage.Controls.Add(this.panel2);
            this.assemblyAndPackagingTabPage.Controls.Add(this.workManagementPanelLabel);
            this.assemblyAndPackagingTabPage.Controls.Add(this.panel1);
            this.assemblyAndPackagingTabPage.Location = new System.Drawing.Point(4, 22);
            this.assemblyAndPackagingTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.assemblyAndPackagingTabPage.Name = "assemblyAndPackagingTabPage";
            this.assemblyAndPackagingTabPage.Size = new System.Drawing.Size(666, 430);
            this.assemblyAndPackagingTabPage.TabIndex = 2;
            this.assemblyAndPackagingTabPage.Text = "Assembly and packaging";
            this.assemblyAndPackagingTabPage.UseVisualStyleBackColor = true;
            // 
            // packagingPanelLabel
            // 
            this.packagingPanelLabel.AutoSize = true;
            this.packagingPanelLabel.Location = new System.Drawing.Point(5, 344);
            this.packagingPanelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.packagingPanelLabel.Name = "packagingPanelLabel";
            this.packagingPanelLabel.Size = new System.Drawing.Size(65, 15);
            this.packagingPanelLabel.TabIndex = 11;
            this.packagingPanelLabel.Text = "Packaging";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.packagingTotalCostLabel);
            this.panel4.Controls.Add(this.packagingMaterialCostTextBox);
            this.panel4.Controls.Add(this.packagingMaterialCostLabel);
            this.panel4.Controls.Add(this.packagingTotalCostTextBox);
            this.panel4.Controls.Add(this.packingCostTextBox);
            this.panel4.Controls.Add(this.totalPackagingDurationTextBox);
            this.panel4.Controls.Add(this.packingCostLabel);
            this.panel4.Controls.Add(this.totalPackagingDurationLabel);
            this.panel4.Location = new System.Drawing.Point(5, 359);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(659, 66);
            this.panel4.TabIndex = 10;
            // 
            // packagingTotalCostLabel
            // 
            this.packagingTotalCostLabel.AutoSize = true;
            this.packagingTotalCostLabel.Location = new System.Drawing.Point(374, 34);
            this.packagingTotalCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.packagingTotalCostLabel.Name = "packagingTotalCostLabel";
            this.packagingTotalCostLabel.Size = new System.Drawing.Size(199, 15);
            this.packagingTotalCostLabel.TabIndex = 7;
            this.packagingTotalCostLabel.Text = "Total packaging cost for one unit, €:";
            // 
            // packagingMaterialCostTextBox
            // 
            this.packagingMaterialCostTextBox.Location = new System.Drawing.Point(587, 8);
            this.packagingMaterialCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.packagingMaterialCostTextBox.Name = "packagingMaterialCostTextBox";
            this.packagingMaterialCostTextBox.Size = new System.Drawing.Size(68, 20);
            this.packagingMaterialCostTextBox.TabIndex = 6;
            this.packagingMaterialCostTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.packagingMaterialCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // packagingMaterialCostLabel
            // 
            this.packagingMaterialCostLabel.AutoSize = true;
            this.packagingMaterialCostLabel.Location = new System.Drawing.Point(374, 11);
            this.packagingMaterialCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.packagingMaterialCostLabel.Name = "packagingMaterialCostLabel";
            this.packagingMaterialCostLabel.Size = new System.Drawing.Size(154, 15);
            this.packagingMaterialCostLabel.TabIndex = 5;
            this.packagingMaterialCostLabel.Text = "Packaging material cost, €:";
            // 
            // packagingTotalCostTextBox
            // 
            this.packagingTotalCostTextBox.Enabled = false;
            this.packagingTotalCostTextBox.Location = new System.Drawing.Point(587, 32);
            this.packagingTotalCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.packagingTotalCostTextBox.Name = "packagingTotalCostTextBox";
            this.packagingTotalCostTextBox.Size = new System.Drawing.Size(68, 20);
            this.packagingTotalCostTextBox.TabIndex = 4;
            // 
            // packingCostTextBox
            // 
            this.packingCostTextBox.Location = new System.Drawing.Point(258, 34);
            this.packingCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.packingCostTextBox.Name = "packingCostTextBox";
            this.packingCostTextBox.Size = new System.Drawing.Size(68, 20);
            this.packingCostTextBox.TabIndex = 3;
            this.packingCostTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.packingCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // totalPackagingDurationTextBox
            // 
            this.totalPackagingDurationTextBox.Location = new System.Drawing.Point(258, 8);
            this.totalPackagingDurationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.totalPackagingDurationTextBox.Name = "totalPackagingDurationTextBox";
            this.totalPackagingDurationTextBox.Size = new System.Drawing.Size(68, 20);
            this.totalPackagingDurationTextBox.TabIndex = 2;
            this.totalPackagingDurationTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.totalPackagingDurationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // packingCostLabel
            // 
            this.packingCostLabel.AutoSize = true;
            this.packingCostLabel.Location = new System.Drawing.Point(2, 36);
            this.packingCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.packingCostLabel.Name = "packingCostLabel";
            this.packingCostLabel.Size = new System.Drawing.Size(102, 15);
            this.packingCostLabel.TabIndex = 1;
            this.packingCostLabel.Text = "Packing cost, €/h:";
            // 
            // totalPackagingDurationLabel
            // 
            this.totalPackagingDurationLabel.AutoSize = true;
            this.totalPackagingDurationLabel.Location = new System.Drawing.Point(2, 10);
            this.totalPackagingDurationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalPackagingDurationLabel.Name = "totalPackagingDurationLabel";
            this.totalPackagingDurationLabel.Size = new System.Drawing.Size(144, 15);
            this.totalPackagingDurationLabel.TabIndex = 0;
            this.totalPackagingDurationLabel.Text = "Total packing duration, h:";
            // 
            // assemblyPanelLabel
            // 
            this.assemblyPanelLabel.AutoSize = true;
            this.assemblyPanelLabel.Location = new System.Drawing.Point(5, 197);
            this.assemblyPanelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.assemblyPanelLabel.Name = "assemblyPanelLabel";
            this.assemblyPanelLabel.Size = new System.Drawing.Size(59, 15);
            this.assemblyPanelLabel.TabIndex = 9;
            this.assemblyPanelLabel.Text = "Assembly";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.assemblyTotalCostLabel);
            this.panel3.Controls.Add(this.totalAssemblyDurationTextBox);
            this.panel3.Controls.Add(this.totalAssemblyDurationLabel);
            this.panel3.Controls.Add(this.individualComponentsAssemblyTextBox);
            this.panel3.Controls.Add(this.individualComponentsAssemblyLabel);
            this.panel3.Controls.Add(this.assemblyToParentDurationTextBox);
            this.panel3.Controls.Add(this.assemblyToParentDurationLabel);
            this.panel3.Controls.Add(this.assemblyTotalCostTextBox);
            this.panel3.Controls.Add(this.assemblyCostTextBox);
            this.panel3.Controls.Add(this.childNodeAssemblyDurationTextBox);
            this.panel3.Controls.Add(this.assemblyCostLabel);
            this.panel3.Controls.Add(this.childNodeAssemblyDurationLabel);
            this.panel3.Location = new System.Drawing.Point(5, 212);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 122);
            this.panel3.TabIndex = 8;
            // 
            // assemblyTotalCostLabel
            // 
            this.assemblyTotalCostLabel.AutoSize = true;
            this.assemblyTotalCostLabel.Location = new System.Drawing.Point(374, 91);
            this.assemblyTotalCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.assemblyTotalCostLabel.Name = "assemblyTotalCostLabel";
            this.assemblyTotalCostLabel.Size = new System.Drawing.Size(194, 15);
            this.assemblyTotalCostLabel.TabIndex = 11;
            this.assemblyTotalCostLabel.Text = "Total assembly cost for one unit, €:";
            // 
            // totalAssemblyDurationTextBox
            // 
            this.totalAssemblyDurationTextBox.Enabled = false;
            this.totalAssemblyDurationTextBox.Location = new System.Drawing.Point(587, 63);
            this.totalAssemblyDurationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.totalAssemblyDurationTextBox.Name = "totalAssemblyDurationTextBox";
            this.totalAssemblyDurationTextBox.Size = new System.Drawing.Size(68, 20);
            this.totalAssemblyDurationTextBox.TabIndex = 10;
            // 
            // totalAssemblyDurationLabel
            // 
            this.totalAssemblyDurationLabel.AutoSize = true;
            this.totalAssemblyDurationLabel.Location = new System.Drawing.Point(374, 65);
            this.totalAssemblyDurationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalAssemblyDurationLabel.Name = "totalAssemblyDurationLabel";
            this.totalAssemblyDurationLabel.Size = new System.Drawing.Size(153, 15);
            this.totalAssemblyDurationLabel.TabIndex = 9;
            this.totalAssemblyDurationLabel.Text = "Total assembly duration, h:";
            // 
            // individualComponentsAssemblyTextBox
            // 
            this.individualComponentsAssemblyTextBox.Location = new System.Drawing.Point(258, 11);
            this.individualComponentsAssemblyTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.individualComponentsAssemblyTextBox.Name = "individualComponentsAssemblyTextBox";
            this.individualComponentsAssemblyTextBox.Size = new System.Drawing.Size(68, 20);
            this.individualComponentsAssemblyTextBox.TabIndex = 8;
            this.individualComponentsAssemblyTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.individualComponentsAssemblyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // individualComponentsAssemblyLabel
            // 
            this.individualComponentsAssemblyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.individualComponentsAssemblyLabel.AutoSize = true;
            this.individualComponentsAssemblyLabel.Location = new System.Drawing.Point(2, 13);
            this.individualComponentsAssemblyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.individualComponentsAssemblyLabel.Name = "individualComponentsAssemblyLabel";
            this.individualComponentsAssemblyLabel.Size = new System.Drawing.Size(249, 15);
            this.individualComponentsAssemblyLabel.TabIndex = 7;
            this.individualComponentsAssemblyLabel.Text = "Individual components assembly duration, h:";
            // 
            // assemblyToParentDurationTextBox
            // 
            this.assemblyToParentDurationTextBox.Location = new System.Drawing.Point(258, 37);
            this.assemblyToParentDurationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.assemblyToParentDurationTextBox.Name = "assemblyToParentDurationTextBox";
            this.assemblyToParentDurationTextBox.Size = new System.Drawing.Size(68, 20);
            this.assemblyToParentDurationTextBox.TabIndex = 6;
            this.assemblyToParentDurationTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.assemblyToParentDurationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // assemblyToParentDurationLabel
            // 
            this.assemblyToParentDurationLabel.AutoSize = true;
            this.assemblyToParentDurationLabel.Location = new System.Drawing.Point(2, 39);
            this.assemblyToParentDurationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.assemblyToParentDurationLabel.Name = "assemblyToParentDurationLabel";
            this.assemblyToParentDurationLabel.Size = new System.Drawing.Size(174, 15);
            this.assemblyToParentDurationLabel.TabIndex = 5;
            this.assemblyToParentDurationLabel.Text = "Assembly to parent duration, h:";
            // 
            // assemblyTotalCostTextBox
            // 
            this.assemblyTotalCostTextBox.Enabled = false;
            this.assemblyTotalCostTextBox.Location = new System.Drawing.Point(587, 89);
            this.assemblyTotalCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.assemblyTotalCostTextBox.Name = "assemblyTotalCostTextBox";
            this.assemblyTotalCostTextBox.Size = new System.Drawing.Size(68, 20);
            this.assemblyTotalCostTextBox.TabIndex = 4;
            // 
            // assemblyCostTextBox
            // 
            this.assemblyCostTextBox.Location = new System.Drawing.Point(258, 88);
            this.assemblyCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.assemblyCostTextBox.Name = "assemblyCostTextBox";
            this.assemblyCostTextBox.Size = new System.Drawing.Size(68, 20);
            this.assemblyCostTextBox.TabIndex = 3;
            this.assemblyCostTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.assemblyCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // childNodeAssemblyDurationTextBox
            // 
            this.childNodeAssemblyDurationTextBox.Enabled = false;
            this.childNodeAssemblyDurationTextBox.Location = new System.Drawing.Point(258, 63);
            this.childNodeAssemblyDurationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.childNodeAssemblyDurationTextBox.Name = "childNodeAssemblyDurationTextBox";
            this.childNodeAssemblyDurationTextBox.Size = new System.Drawing.Size(68, 20);
            this.childNodeAssemblyDurationTextBox.TabIndex = 2;
            // 
            // assemblyCostLabel
            // 
            this.assemblyCostLabel.AutoSize = true;
            this.assemblyCostLabel.Location = new System.Drawing.Point(2, 90);
            this.assemblyCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.assemblyCostLabel.Name = "assemblyCostLabel";
            this.assemblyCostLabel.Size = new System.Drawing.Size(110, 15);
            this.assemblyCostLabel.TabIndex = 1;
            this.assemblyCostLabel.Text = "Assembly cost, €/h:";
            // 
            // childNodeAssemblyDurationLabel
            // 
            this.childNodeAssemblyDurationLabel.AutoSize = true;
            this.childNodeAssemblyDurationLabel.Location = new System.Drawing.Point(2, 65);
            this.childNodeAssemblyDurationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.childNodeAssemblyDurationLabel.Name = "childNodeAssemblyDurationLabel";
            this.childNodeAssemblyDurationLabel.Size = new System.Drawing.Size(185, 15);
            this.childNodeAssemblyDurationLabel.TabIndex = 0;
            this.childNodeAssemblyDurationLabel.Text = "Child node assembly duration, h:";
            // 
            // supplyPanelLabel
            // 
            this.supplyPanelLabel.AutoSize = true;
            this.supplyPanelLabel.Location = new System.Drawing.Point(5, 105);
            this.supplyPanelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.supplyPanelLabel.Name = "supplyPanelLabel";
            this.supplyPanelLabel.Size = new System.Drawing.Size(44, 15);
            this.supplyPanelLabel.TabIndex = 7;
            this.supplyPanelLabel.Text = "Supply";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.supplyTotalCostLabel);
            this.panel2.Controls.Add(this.supplyTotalCostTextBox);
            this.panel2.Controls.Add(this.supplyCostTextBox);
            this.panel2.Controls.Add(this.totalSupplyDurationTextBox);
            this.panel2.Controls.Add(this.supplyCostLabel);
            this.panel2.Controls.Add(this.totalSupplyDurationLabel);
            this.panel2.Location = new System.Drawing.Point(5, 120);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 66);
            this.panel2.TabIndex = 6;
            // 
            // supplyTotalCostLabel
            // 
            this.supplyTotalCostLabel.AutoSize = true;
            this.supplyTotalCostLabel.Location = new System.Drawing.Point(468, 37);
            this.supplyTotalCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.supplyTotalCostLabel.Name = "supplyTotalCostLabel";
            this.supplyTotalCostLabel.Size = new System.Drawing.Size(114, 15);
            this.supplyTotalCostLabel.TabIndex = 6;
            this.supplyTotalCostLabel.Text = "Total for one unit, €:";
            // 
            // supplyTotalCostTextBox
            // 
            this.supplyTotalCostTextBox.Enabled = false;
            this.supplyTotalCostTextBox.Location = new System.Drawing.Point(587, 34);
            this.supplyTotalCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.supplyTotalCostTextBox.Name = "supplyTotalCostTextBox";
            this.supplyTotalCostTextBox.Size = new System.Drawing.Size(68, 20);
            this.supplyTotalCostTextBox.TabIndex = 4;
            // 
            // supplyCostTextBox
            // 
            this.supplyCostTextBox.Location = new System.Drawing.Point(258, 34);
            this.supplyCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.supplyCostTextBox.Name = "supplyCostTextBox";
            this.supplyCostTextBox.Size = new System.Drawing.Size(68, 20);
            this.supplyCostTextBox.TabIndex = 3;
            this.supplyCostTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.supplyCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // totalSupplyDurationTextBox
            // 
            this.totalSupplyDurationTextBox.Location = new System.Drawing.Point(258, 8);
            this.totalSupplyDurationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.totalSupplyDurationTextBox.Name = "totalSupplyDurationTextBox";
            this.totalSupplyDurationTextBox.Size = new System.Drawing.Size(68, 20);
            this.totalSupplyDurationTextBox.TabIndex = 2;
            this.totalSupplyDurationTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.totalSupplyDurationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // supplyCostLabel
            // 
            this.supplyCostLabel.AutoSize = true;
            this.supplyCostLabel.Location = new System.Drawing.Point(2, 36);
            this.supplyCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.supplyCostLabel.Name = "supplyCostLabel";
            this.supplyCostLabel.Size = new System.Drawing.Size(95, 15);
            this.supplyCostLabel.TabIndex = 1;
            this.supplyCostLabel.Text = "Supply cost, €/h:";
            // 
            // totalSupplyDurationLabel
            // 
            this.totalSupplyDurationLabel.AutoSize = true;
            this.totalSupplyDurationLabel.Location = new System.Drawing.Point(2, 10);
            this.totalSupplyDurationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalSupplyDurationLabel.Name = "totalSupplyDurationLabel";
            this.totalSupplyDurationLabel.Size = new System.Drawing.Size(136, 15);
            this.totalSupplyDurationLabel.TabIndex = 0;
            this.totalSupplyDurationLabel.Text = "Total supply duration, h:";
            // 
            // workManagementPanelLabel
            // 
            this.workManagementPanelLabel.AutoSize = true;
            this.workManagementPanelLabel.Location = new System.Drawing.Point(5, 16);
            this.workManagementPanelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.workManagementPanelLabel.Name = "workManagementPanelLabel";
            this.workManagementPanelLabel.Size = new System.Drawing.Size(112, 15);
            this.workManagementPanelLabel.TabIndex = 5;
            this.workManagementPanelLabel.Text = "Work management";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.workManagementTotalCostLabel);
            this.panel1.Controls.Add(this.workManagementTotalCostTextBox);
            this.panel1.Controls.Add(this.workManagementCostTextBox);
            this.panel1.Controls.Add(this.totalWorkManagementDurationTextBox);
            this.panel1.Controls.Add(this.workManagementCostLabel);
            this.panel1.Controls.Add(this.totalWorkManagementDurationLabel);
            this.panel1.Location = new System.Drawing.Point(5, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 66);
            this.panel1.TabIndex = 4;
            // 
            // workManagementTotalCostLabel
            // 
            this.workManagementTotalCostLabel.AutoSize = true;
            this.workManagementTotalCostLabel.Location = new System.Drawing.Point(468, 37);
            this.workManagementTotalCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.workManagementTotalCostLabel.Name = "workManagementTotalCostLabel";
            this.workManagementTotalCostLabel.Size = new System.Drawing.Size(114, 15);
            this.workManagementTotalCostLabel.TabIndex = 5;
            this.workManagementTotalCostLabel.Text = "Total for one unit, €:";
            // 
            // workManagementTotalCostTextBox
            // 
            this.workManagementTotalCostTextBox.Enabled = false;
            this.workManagementTotalCostTextBox.Location = new System.Drawing.Point(587, 34);
            this.workManagementTotalCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.workManagementTotalCostTextBox.Name = "workManagementTotalCostTextBox";
            this.workManagementTotalCostTextBox.Size = new System.Drawing.Size(68, 20);
            this.workManagementTotalCostTextBox.TabIndex = 4;
            // 
            // workManagementCostTextBox
            // 
            this.workManagementCostTextBox.Location = new System.Drawing.Point(258, 34);
            this.workManagementCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.workManagementCostTextBox.Name = "workManagementCostTextBox";
            this.workManagementCostTextBox.Size = new System.Drawing.Size(68, 20);
            this.workManagementCostTextBox.TabIndex = 3;
            this.workManagementCostTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.workManagementCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // totalWorkManagementDurationTextBox
            // 
            this.totalWorkManagementDurationTextBox.Location = new System.Drawing.Point(258, 8);
            this.totalWorkManagementDurationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.totalWorkManagementDurationTextBox.Name = "totalWorkManagementDurationTextBox";
            this.totalWorkManagementDurationTextBox.Size = new System.Drawing.Size(68, 20);
            this.totalWorkManagementDurationTextBox.TabIndex = 2;
            this.totalWorkManagementDurationTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.totalWorkManagementDurationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // workManagementCostLabel
            // 
            this.workManagementCostLabel.AutoSize = true;
            this.workManagementCostLabel.Location = new System.Drawing.Point(2, 36);
            this.workManagementCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.workManagementCostLabel.Name = "workManagementCostLabel";
            this.workManagementCostLabel.Size = new System.Drawing.Size(163, 15);
            this.workManagementCostLabel.TabIndex = 1;
            this.workManagementCostLabel.Text = "Work management cost, €/h:";
            // 
            // totalWorkManagementDurationLabel
            // 
            this.totalWorkManagementDurationLabel.AutoSize = true;
            this.totalWorkManagementDurationLabel.Location = new System.Drawing.Point(2, 10);
            this.totalWorkManagementDurationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalWorkManagementDurationLabel.Name = "totalWorkManagementDurationLabel";
            this.totalWorkManagementDurationLabel.Size = new System.Drawing.Size(204, 15);
            this.totalWorkManagementDurationLabel.TabIndex = 0;
            this.totalWorkManagementDurationLabel.Text = "Total work management duration, h:";
            // 
            // partsTabPage
            // 
            this.partsTabPage.Controls.Add(this.totalPartsAndToolboxCostLabel);
            this.partsTabPage.Controls.Add(this.totalPartsAndToolboxCostTextBox);
            this.partsTabPage.Controls.Add(this.totalToolboxWeightLabel);
            this.partsTabPage.Controls.Add(this.totalToolboxWeightTextBox);
            this.partsTabPage.Controls.Add(this.totalToolboxCostLabel);
            this.partsTabPage.Controls.Add(this.totalToolboxCostTextBox);
            this.partsTabPage.Controls.Add(this.numberOfPartsLabel);
            this.partsTabPage.Controls.Add(this.numberOfPartsTextBox);
            this.partsTabPage.Controls.Add(this.totalPartsCostLabel);
            this.partsTabPage.Controls.Add(this.totalPartsCostTextBox);
            this.partsTabPage.Location = new System.Drawing.Point(4, 22);
            this.partsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.partsTabPage.Name = "partsTabPage";
            this.partsTabPage.Size = new System.Drawing.Size(666, 430);
            this.partsTabPage.TabIndex = 3;
            this.partsTabPage.Text = "Parts";
            this.partsTabPage.UseVisualStyleBackColor = true;
            // 
            // totalPartsAndToolboxCostLabel
            // 
            this.totalPartsAndToolboxCostLabel.AutoSize = true;
            this.totalPartsAndToolboxCostLabel.Location = new System.Drawing.Point(17, 113);
            this.totalPartsAndToolboxCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalPartsAndToolboxCostLabel.Name = "totalPartsAndToolboxCostLabel";
            this.totalPartsAndToolboxCostLabel.Size = new System.Drawing.Size(172, 15);
            this.totalPartsAndToolboxCostLabel.TabIndex = 15;
            this.totalPartsAndToolboxCostLabel.Text = "Total parts and toolbox cost, €:";
            // 
            // totalPartsAndToolboxCostTextBox
            // 
            this.totalPartsAndToolboxCostTextBox.Enabled = false;
            this.totalPartsAndToolboxCostTextBox.Location = new System.Drawing.Point(197, 110);
            this.totalPartsAndToolboxCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.totalPartsAndToolboxCostTextBox.Name = "totalPartsAndToolboxCostTextBox";
            this.totalPartsAndToolboxCostTextBox.Size = new System.Drawing.Size(68, 20);
            this.totalPartsAndToolboxCostTextBox.TabIndex = 14;
            // 
            // totalToolboxWeightLabel
            // 
            this.totalToolboxWeightLabel.AutoSize = true;
            this.totalToolboxWeightLabel.Location = new System.Drawing.Point(17, 65);
            this.totalToolboxWeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalToolboxWeightLabel.Name = "totalToolboxWeightLabel";
            this.totalToolboxWeightLabel.Size = new System.Drawing.Size(112, 15);
            this.totalToolboxWeightLabel.TabIndex = 13;
            this.totalToolboxWeightLabel.Text = "Toolbox weight, kg:";
            // 
            // totalToolboxWeightTextBox
            // 
            this.totalToolboxWeightTextBox.Enabled = false;
            this.totalToolboxWeightTextBox.Location = new System.Drawing.Point(197, 62);
            this.totalToolboxWeightTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.totalToolboxWeightTextBox.Name = "totalToolboxWeightTextBox";
            this.totalToolboxWeightTextBox.Size = new System.Drawing.Size(68, 20);
            this.totalToolboxWeightTextBox.TabIndex = 12;
            // 
            // totalToolboxCostLabel
            // 
            this.totalToolboxCostLabel.AutoSize = true;
            this.totalToolboxCostLabel.Location = new System.Drawing.Point(17, 89);
            this.totalToolboxCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalToolboxCostLabel.Name = "totalToolboxCostLabel";
            this.totalToolboxCostLabel.Size = new System.Drawing.Size(118, 15);
            this.totalToolboxCostLabel.TabIndex = 11;
            this.totalToolboxCostLabel.Text = "Total toolbox cost, €:";
            // 
            // totalToolboxCostTextBox
            // 
            this.totalToolboxCostTextBox.Enabled = false;
            this.totalToolboxCostTextBox.Location = new System.Drawing.Point(197, 86);
            this.totalToolboxCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.totalToolboxCostTextBox.Name = "totalToolboxCostTextBox";
            this.totalToolboxCostTextBox.Size = new System.Drawing.Size(68, 20);
            this.totalToolboxCostTextBox.TabIndex = 10;
            // 
            // numberOfPartsLabel
            // 
            this.numberOfPartsLabel.AutoSize = true;
            this.numberOfPartsLabel.Location = new System.Drawing.Point(17, 17);
            this.numberOfPartsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfPartsLabel.Name = "numberOfPartsLabel";
            this.numberOfPartsLabel.Size = new System.Drawing.Size(98, 15);
            this.numberOfPartsLabel.TabIndex = 9;
            this.numberOfPartsLabel.Text = "Number of parts:";
            // 
            // numberOfPartsTextBox
            // 
            this.numberOfPartsTextBox.Enabled = false;
            this.numberOfPartsTextBox.Location = new System.Drawing.Point(197, 14);
            this.numberOfPartsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.numberOfPartsTextBox.Name = "numberOfPartsTextBox";
            this.numberOfPartsTextBox.Size = new System.Drawing.Size(68, 20);
            this.numberOfPartsTextBox.TabIndex = 8;
            // 
            // totalPartsCostLabel
            // 
            this.totalPartsCostLabel.AutoSize = true;
            this.totalPartsCostLabel.Location = new System.Drawing.Point(17, 41);
            this.totalPartsCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalPartsCostLabel.Name = "totalPartsCostLabel";
            this.totalPartsCostLabel.Size = new System.Drawing.Size(105, 15);
            this.totalPartsCostLabel.TabIndex = 7;
            this.totalPartsCostLabel.Text = "Total parts cost, €:";
            // 
            // totalPartsCostTextBox
            // 
            this.totalPartsCostTextBox.Enabled = false;
            this.totalPartsCostTextBox.Location = new System.Drawing.Point(197, 38);
            this.totalPartsCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.totalPartsCostTextBox.Name = "totalPartsCostTextBox";
            this.totalPartsCostTextBox.Size = new System.Drawing.Size(68, 20);
            this.totalPartsCostTextBox.TabIndex = 6;
            // 
            // otherCostsTabPage
            // 
            this.otherCostsTabPage.Controls.Add(this.otherCostsTextBox);
            this.otherCostsTabPage.Controls.Add(this.otherCostsDescriptionTextBox);
            this.otherCostsTabPage.Controls.Add(this.otherCostsDescriptionLabel);
            this.otherCostsTabPage.Controls.Add(this.otherCostsLabel);
            this.otherCostsTabPage.Location = new System.Drawing.Point(4, 22);
            this.otherCostsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.otherCostsTabPage.Name = "otherCostsTabPage";
            this.otherCostsTabPage.Size = new System.Drawing.Size(666, 430);
            this.otherCostsTabPage.TabIndex = 4;
            this.otherCostsTabPage.Text = "Other costs";
            this.otherCostsTabPage.UseVisualStyleBackColor = true;
            // 
            // otherCostsTextBox
            // 
            this.otherCostsTextBox.Location = new System.Drawing.Point(174, 14);
            this.otherCostsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.otherCostsTextBox.Name = "otherCostsTextBox";
            this.otherCostsTextBox.Size = new System.Drawing.Size(68, 20);
            this.otherCostsTextBox.TabIndex = 11;
            this.otherCostsTextBox.Text = "0";
            this.otherCostsTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.otherCostsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // otherCostsDescriptionTextBox
            // 
            this.otherCostsDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.otherCostsDescriptionTextBox.Location = new System.Drawing.Point(8, 67);
            this.otherCostsDescriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.otherCostsDescriptionTextBox.Multiline = true;
            this.otherCostsDescriptionTextBox.Name = "otherCostsDescriptionTextBox";
            this.otherCostsDescriptionTextBox.Size = new System.Drawing.Size(650, 85);
            this.otherCostsDescriptionTextBox.TabIndex = 8;
            this.otherCostsDescriptionTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // otherCostsDescriptionLabel
            // 
            this.otherCostsDescriptionLabel.AutoSize = true;
            this.otherCostsDescriptionLabel.Location = new System.Drawing.Point(5, 46);
            this.otherCostsDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.otherCostsDescriptionLabel.Name = "otherCostsDescriptionLabel";
            this.otherCostsDescriptionLabel.Size = new System.Drawing.Size(131, 15);
            this.otherCostsDescriptionLabel.TabIndex = 7;
            this.otherCostsDescriptionLabel.Text = "Other costs description";
            // 
            // otherCostsLabel
            // 
            this.otherCostsLabel.AutoSize = true;
            this.otherCostsLabel.Location = new System.Drawing.Point(5, 16);
            this.otherCostsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.otherCostsLabel.Name = "otherCostsLabel";
            this.otherCostsLabel.Size = new System.Drawing.Size(163, 15);
            this.otherCostsLabel.TabIndex = 6;
            this.otherCostsLabel.Text = "Other costs for one device, €:";
            // 
            // amountOfDevicesTextBox
            // 
            this.amountOfDevicesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.amountOfDevicesTextBox.Location = new System.Drawing.Point(594, 487);
            this.amountOfDevicesTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.amountOfDevicesTextBox.Name = "amountOfDevicesTextBox";
            this.amountOfDevicesTextBox.Size = new System.Drawing.Size(68, 20);
            this.amountOfDevicesTextBox.TabIndex = 5;
            this.amountOfDevicesTextBox.Text = "1";
            this.amountOfDevicesTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.amountOfDevicesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integersOnlyTextBox_KeyPress);
            // 
            // totalDeviceCostLabel
            // 
            this.totalDeviceCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalDeviceCostLabel.AutoSize = true;
            this.totalDeviceCostLabel.Location = new System.Drawing.Point(6, 564);
            this.totalDeviceCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalDeviceCostLabel.Name = "totalDeviceCostLabel";
            this.totalDeviceCostLabel.Size = new System.Drawing.Size(98, 15);
            this.totalDeviceCostLabel.TabIndex = 4;
            this.totalDeviceCostLabel.Text = "Total cost, €/unit:";
            // 
            // amountOfDevicesLabel
            // 
            this.amountOfDevicesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.amountOfDevicesLabel.AutoSize = true;
            this.amountOfDevicesLabel.Location = new System.Drawing.Point(435, 490);
            this.amountOfDevicesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.amountOfDevicesLabel.Name = "amountOfDevicesLabel";
            this.amountOfDevicesLabel.Size = new System.Drawing.Size(155, 15);
            this.amountOfDevicesLabel.TabIndex = 3;
            this.amountOfDevicesLabel.Text = "Amount of ordered devices:";
            // 
            // totalDeviceCostTextBox
            // 
            this.totalDeviceCostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalDeviceCostTextBox.Enabled = false;
            this.totalDeviceCostTextBox.Location = new System.Drawing.Point(223, 561);
            this.totalDeviceCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.totalDeviceCostTextBox.Name = "totalDeviceCostTextBox";
            this.totalDeviceCostTextBox.Size = new System.Drawing.Size(68, 20);
            this.totalDeviceCostTextBox.TabIndex = 6;
            this.totalDeviceCostTextBox.Text = "0";
            // 
            // saveToSolidworksButton
            // 
            this.saveToSolidworksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveToSolidworksButton.Location = new System.Drawing.Point(533, 537);
            this.saveToSolidworksButton.Name = "saveToSolidworksButton";
            this.saveToSolidworksButton.Size = new System.Drawing.Size(129, 39);
            this.saveToSolidworksButton.TabIndex = 7;
            this.saveToSolidworksButton.Text = "Save to Solidworks";
            this.saveToSolidworksButton.UseVisualStyleBackColor = true;
            this.saveToSolidworksButton.Click += new System.EventHandler(this.saveToSolidworksButton_Click);
            // 
            // totalDeviceHoursTextBox
            // 
            this.totalDeviceHoursTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalDeviceHoursTextBox.Enabled = false;
            this.totalDeviceHoursTextBox.Location = new System.Drawing.Point(594, 511);
            this.totalDeviceHoursTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.totalDeviceHoursTextBox.Name = "totalDeviceHoursTextBox";
            this.totalDeviceHoursTextBox.Size = new System.Drawing.Size(68, 20);
            this.totalDeviceHoursTextBox.TabIndex = 9;
            this.totalDeviceHoursTextBox.Text = "0";
            // 
            // totalDeviceHoursLabel
            // 
            this.totalDeviceHoursLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalDeviceHoursLabel.AutoSize = true;
            this.totalDeviceHoursLabel.Location = new System.Drawing.Point(462, 514);
            this.totalDeviceHoursLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalDeviceHoursLabel.Name = "totalDeviceHoursLabel";
            this.totalDeviceHoursLabel.Size = new System.Drawing.Size(128, 15);
            this.totalDeviceHoursLabel.TabIndex = 8;
            this.totalDeviceHoursLabel.Text = "Total hours per unit, h:";
            // 
            // calculatedDesigningCost1Label
            // 
            this.calculatedDesigningCost1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.calculatedDesigningCost1Label.AutoSize = true;
            this.calculatedDesigningCost1Label.Location = new System.Drawing.Point(6, 459);
            this.calculatedDesigningCost1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.calculatedDesigningCost1Label.Name = "calculatedDesigningCost1Label";
            this.calculatedDesigningCost1Label.Size = new System.Drawing.Size(183, 15);
            this.calculatedDesigningCost1Label.TabIndex = 12;
            this.calculatedDesigningCost1Label.Text = "Calculated designing cost €/unit:";
            // 
            // calculatedAssemblyTabCostLabel
            // 
            this.calculatedAssemblyTabCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.calculatedAssemblyTabCostLabel.AutoSize = true;
            this.calculatedAssemblyTabCostLabel.Location = new System.Drawing.Point(6, 501);
            this.calculatedAssemblyTabCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.calculatedAssemblyTabCostLabel.Name = "calculatedAssemblyTabCostLabel";
            this.calculatedAssemblyTabCostLabel.Size = new System.Drawing.Size(181, 15);
            this.calculatedAssemblyTabCostLabel.TabIndex = 13;
            this.calculatedAssemblyTabCostLabel.Text = "Calculated assembly cost €/unit:";
            // 
            // calculatedWeldingCost1Label
            // 
            this.calculatedWeldingCost1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.calculatedWeldingCost1Label.AutoSize = true;
            this.calculatedWeldingCost1Label.Location = new System.Drawing.Point(6, 480);
            this.calculatedWeldingCost1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.calculatedWeldingCost1Label.Name = "calculatedWeldingCost1Label";
            this.calculatedWeldingCost1Label.Size = new System.Drawing.Size(172, 15);
            this.calculatedWeldingCost1Label.TabIndex = 14;
            this.calculatedWeldingCost1Label.Text = "Calculated welding cost €/unit:";
            // 
            // totalPartsAndToolboxCost1Label
            // 
            this.totalPartsAndToolboxCost1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalPartsAndToolboxCost1Label.AutoSize = true;
            this.totalPartsAndToolboxCost1Label.Location = new System.Drawing.Point(5, 522);
            this.totalPartsAndToolboxCost1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalPartsAndToolboxCost1Label.Name = "totalPartsAndToolboxCost1Label";
            this.totalPartsAndToolboxCost1Label.Size = new System.Drawing.Size(156, 15);
            this.totalPartsAndToolboxCost1Label.TabIndex = 15;
            this.totalPartsAndToolboxCost1Label.Text = "Calculated parts cost €/unit:";
            // 
            // calculatedDesigningCost1TextBox
            // 
            this.calculatedDesigningCost1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.calculatedDesigningCost1TextBox.Enabled = false;
            this.calculatedDesigningCost1TextBox.Location = new System.Drawing.Point(223, 456);
            this.calculatedDesigningCost1TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.calculatedDesigningCost1TextBox.Name = "calculatedDesigningCost1TextBox";
            this.calculatedDesigningCost1TextBox.Size = new System.Drawing.Size(68, 20);
            this.calculatedDesigningCost1TextBox.TabIndex = 16;
            this.calculatedDesigningCost1TextBox.Text = "0";
            // 
            // calculatedWeldingCost1TextBox
            // 
            this.calculatedWeldingCost1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.calculatedWeldingCost1TextBox.Enabled = false;
            this.calculatedWeldingCost1TextBox.Location = new System.Drawing.Point(223, 477);
            this.calculatedWeldingCost1TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.calculatedWeldingCost1TextBox.Name = "calculatedWeldingCost1TextBox";
            this.calculatedWeldingCost1TextBox.Size = new System.Drawing.Size(68, 20);
            this.calculatedWeldingCost1TextBox.TabIndex = 17;
            this.calculatedWeldingCost1TextBox.Text = "0";
            // 
            // calculatedAssemblyTabCostTextBox
            // 
            this.calculatedAssemblyTabCostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.calculatedAssemblyTabCostTextBox.Enabled = false;
            this.calculatedAssemblyTabCostTextBox.Location = new System.Drawing.Point(223, 498);
            this.calculatedAssemblyTabCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.calculatedAssemblyTabCostTextBox.Name = "calculatedAssemblyTabCostTextBox";
            this.calculatedAssemblyTabCostTextBox.Size = new System.Drawing.Size(68, 20);
            this.calculatedAssemblyTabCostTextBox.TabIndex = 18;
            this.calculatedAssemblyTabCostTextBox.Text = "0";
            // 
            // otherCosts1TextBox
            // 
            this.otherCosts1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.otherCosts1TextBox.Enabled = false;
            this.otherCosts1TextBox.Location = new System.Drawing.Point(223, 540);
            this.otherCosts1TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.otherCosts1TextBox.Name = "otherCosts1TextBox";
            this.otherCosts1TextBox.Size = new System.Drawing.Size(68, 20);
            this.otherCosts1TextBox.TabIndex = 20;
            this.otherCosts1TextBox.Text = "0";
            // 
            // totalPartsAndToolboxCost1TextBox
            // 
            this.totalPartsAndToolboxCost1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalPartsAndToolboxCost1TextBox.Enabled = false;
            this.totalPartsAndToolboxCost1TextBox.Location = new System.Drawing.Point(223, 519);
            this.totalPartsAndToolboxCost1TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.totalPartsAndToolboxCost1TextBox.Name = "totalPartsAndToolboxCost1TextBox";
            this.totalPartsAndToolboxCost1TextBox.Size = new System.Drawing.Size(68, 20);
            this.totalPartsAndToolboxCost1TextBox.TabIndex = 19;
            this.totalPartsAndToolboxCost1TextBox.Text = "0";
            // 
            // otherCostsForOneDevice1Label
            // 
            this.otherCostsForOneDevice1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.otherCostsForOneDevice1Label.AutoSize = true;
            this.otherCostsForOneDevice1Label.Location = new System.Drawing.Point(6, 543);
            this.otherCostsForOneDevice1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.otherCostsForOneDevice1Label.Name = "otherCostsForOneDevice1Label";
            this.otherCostsForOneDevice1Label.Size = new System.Drawing.Size(98, 15);
            this.otherCostsForOneDevice1Label.TabIndex = 21;
            this.otherCostsForOneDevice1Label.Text = "Other cost €/unit:";
            // 
            // DeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 586);
            this.Controls.Add(this.otherCostsForOneDevice1Label);
            this.Controls.Add(this.otherCosts1TextBox);
            this.Controls.Add(this.totalPartsAndToolboxCost1TextBox);
            this.Controls.Add(this.calculatedAssemblyTabCostTextBox);
            this.Controls.Add(this.calculatedWeldingCost1TextBox);
            this.Controls.Add(this.calculatedDesigningCost1TextBox);
            this.Controls.Add(this.totalPartsAndToolboxCost1Label);
            this.Controls.Add(this.calculatedWeldingCost1Label);
            this.Controls.Add(this.calculatedAssemblyTabCostLabel);
            this.Controls.Add(this.calculatedDesigningCost1Label);
            this.Controls.Add(this.totalDeviceHoursTextBox);
            this.Controls.Add(this.totalDeviceHoursLabel);
            this.Controls.Add(this.saveToSolidworksButton);
            this.Controls.Add(this.totalDeviceCostTextBox);
            this.Controls.Add(this.amountOfDevicesTextBox);
            this.Controls.Add(this.totalDeviceCostLabel);
            this.Controls.Add(this.amountOfDevicesLabel);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DeviceForm";
            this.Text = "DeviceForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeviceForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.designingTabPage.ResumeLayout(false);
            this.designingTabPage.PerformLayout();
            this.weldingTabPage.ResumeLayout(false);
            this.weldingTabPage.PerformLayout();
            this.assemblyAndPackagingTabPage.ResumeLayout(false);
            this.assemblyAndPackagingTabPage.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.partsTabPage.ResumeLayout(false);
            this.partsTabPage.PerformLayout();
            this.otherCostsTabPage.ResumeLayout(false);
            this.otherCostsTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage designingTabPage;
        private System.Windows.Forms.TabPage weldingTabPage;
        private System.Windows.Forms.TabPage assemblyAndPackagingTabPage;
        private System.Windows.Forms.TabPage partsTabPage;
        private System.Windows.Forms.TabPage otherCostsTabPage;
        private TextBox calculatedDesigningCostTextBox;
        private TextBox designingCostTextBox;
        private TextBox plannedDesignDurationTextBox;
        private System.Windows.Forms.Label calculatedDesigningCostLabel;
        private System.Windows.Forms.Label designingCostLabel;
        private System.Windows.Forms.Label plannedDesignDurationLabel;
        private TextBox calculatedWeldingCostTextBox;
        private TextBox weldingCostTextBox;
        private TextBox plannedWeldingDurationTextBox;
        private System.Windows.Forms.Label calculatedWeldingCostLabel;
        private System.Windows.Forms.Label weldingCostLabel;
        private System.Windows.Forms.Label plannedWeldingDurationLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label totalPartsCostLabel;
        private TextBox totalPartsCostTextBox;
        private TextBox otherCostsTextBox;
        private TextBox otherCostsDescriptionTextBox;
        private System.Windows.Forms.Label otherCostsDescriptionLabel;
        private System.Windows.Forms.Label otherCostsLabel;
        private TextBox amountOfDevicesTextBox;
        private System.Windows.Forms.Label totalDeviceCostLabel;
        private System.Windows.Forms.Label amountOfDevicesLabel;
        private Label workManagementPanelLabel;
        private Label workManagementCostLabel;
        private Label totalWorkManagementDurationLabel;
        private TextBox workManagementCostTextBox;
        private TextBox totalWorkManagementDurationTextBox;
        private TextBox workManagementTotalCostTextBox;
        private Label supplyPanelLabel;
        private Panel panel2;
        private TextBox supplyTotalCostTextBox;
        private TextBox supplyCostTextBox;
        private TextBox totalSupplyDurationTextBox;
        private Label supplyCostLabel;
        private Label totalSupplyDurationLabel;
        private Label assemblyPanelLabel;
        private Panel panel3;
        private TextBox assemblyTotalCostTextBox;
        private TextBox assemblyCostTextBox;
        private TextBox childNodeAssemblyDurationTextBox;
        private Label assemblyCostLabel;
        private Label childNodeAssemblyDurationLabel;
        private TextBox assemblyToParentDurationTextBox;
        private Label assemblyToParentDurationLabel;
        private Label individualComponentsAssemblyLabel;
        private TextBox individualComponentsAssemblyTextBox;
        private Label packagingPanelLabel;
        private Panel panel4;
        private TextBox packagingTotalCostTextBox;
        private TextBox packingCostTextBox;
        private TextBox totalPackagingDurationTextBox;
        private Label packingCostLabel;
        private Label totalPackagingDurationLabel;
        private TextBox packagingMaterialCostTextBox;
        private Label packagingMaterialCostLabel;
        private TextBox totalDeviceCostTextBox;
        private TextBox totalAssemblyDurationTextBox;
        private Label totalAssemblyDurationLabel;
        private Button saveToSolidworksButton;
        private Label totalToolboxWeightLabel;
        private TextBox totalToolboxWeightTextBox;
        private Label totalToolboxCostLabel;
        private TextBox totalToolboxCostTextBox;
        private Label numberOfPartsLabel;
        private TextBox numberOfPartsTextBox;
        private Label totalPartsAndToolboxCostLabel;
        private TextBox totalPartsAndToolboxCostTextBox;
        private Label packagingTotalCostLabel;
        private Label assemblyTotalCostLabel;
        private Label supplyTotalCostLabel;
        private Label workManagementTotalCostLabel;
        private TextBox totalDeviceHoursTextBox;
        private Label totalDeviceHoursLabel;
        private Label calculatedDesigningCost1Label;
        private Label calculatedAssemblyTabCostLabel;
        private Label calculatedWeldingCost1Label;
        private Label totalPartsAndToolboxCost1Label;
        private TextBox calculatedDesigningCost1TextBox;
        private TextBox calculatedWeldingCost1TextBox;
        private TextBox calculatedAssemblyTabCostTextBox;
        private TextBox otherCosts1TextBox;
        private TextBox totalPartsAndToolboxCost1TextBox;
        private Label otherCostsForOneDevice1Label;
    }
}