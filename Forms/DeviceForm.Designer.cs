﻿using System.Windows.Forms;

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
            this.realDesigningDurationTextBox = new System.Windows.Forms.TextBox();
            this.plannedDesignDurationTextBox = new System.Windows.Forms.TextBox();
            this.calculatedDesigningCostLabel = new System.Windows.Forms.Label();
            this.designingCostLabel = new System.Windows.Forms.Label();
            this.realDesigningDurationLabel = new System.Windows.Forms.Label();
            this.plannedDesignDurationLabel = new System.Windows.Forms.Label();
            this.weldingTabPage = new System.Windows.Forms.TabPage();
            this.calculatedWeldingCostTextBox = new System.Windows.Forms.TextBox();
            this.weldingCostTextBox = new System.Windows.Forms.TextBox();
            this.realWeldingDurationTextBox = new System.Windows.Forms.TextBox();
            this.plannedWeldingDurationTextBox = new System.Windows.Forms.TextBox();
            this.calculatedWeldingCostLabel = new System.Windows.Forms.Label();
            this.weldingCostLabel = new System.Windows.Forms.Label();
            this.realWeldingDurationLabel = new System.Windows.Forms.Label();
            this.plannedWeldingDurationLabel = new System.Windows.Forms.Label();
            this.assemblyAndPackagingTabPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.partsTabPage = new System.Windows.Forms.TabPage();
            this.totalPartsCostLabel = new System.Windows.Forms.Label();
            this.totalPartsCostTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.processPartsButton = new System.Windows.Forms.Button();
            this.otherCostsTabPage = new System.Windows.Forms.TabPage();
            this.otherCostsTextBox = new System.Windows.Forms.TextBox();
            this.otherCostsForOneDeviceTextBox = new System.Windows.Forms.TextBox();
            this.otherCostsForOneDeviceLabel = new System.Windows.Forms.Label();
            this.otherCostsDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.otherCostsDescriptionLabel = new System.Windows.Forms.Label();
            this.otherCostsLabel = new System.Windows.Forms.Label();
            this.amountOfDevicesTextBox = new System.Windows.Forms.TextBox();
            this.totalDeviceCostLabel = new System.Windows.Forms.Label();
            this.amountOfDevicesLabel = new System.Windows.Forms.Label();
            this.workManagementPanelLabel = new System.Windows.Forms.Label();
            this.totalWorkManagementDurationLabel = new System.Windows.Forms.Label();
            this.workManagementCostLabel = new System.Windows.Forms.Label();
            this.totalWorkManagementDurationTextBox = new System.Windows.Forms.TextBox();
            this.workManagementCostTextBox = new System.Windows.Forms.TextBox();
            this.workManagementTotalCostTextBox = new System.Windows.Forms.TextBox();
            this.supplyPanelLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.supplyTotalCostTextBox = new System.Windows.Forms.TextBox();
            this.supplyCostTextBox = new System.Windows.Forms.TextBox();
            this.totalSupplyDurationTextBox = new System.Windows.Forms.TextBox();
            this.supplyCostLabel = new System.Windows.Forms.Label();
            this.totalSupplyDurationLabel = new System.Windows.Forms.Label();
            this.assemblyPanelLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.assemblyTotalCostTextBox = new System.Windows.Forms.TextBox();
            this.assemblyCostTextBox = new System.Windows.Forms.TextBox();
            this.totalAssemblyDurationTextBox = new System.Windows.Forms.TextBox();
            this.assemblyCostLabel = new System.Windows.Forms.Label();
            this.totalAssemblyDurationLabel = new System.Windows.Forms.Label();
            this.assemblyToParentDurationTextBox = new System.Windows.Forms.TextBox();
            this.assemblyToParentDurationLabel = new System.Windows.Forms.Label();
            this.individualComponentsAssemblyLabel = new System.Windows.Forms.Label();
            this.individualComponentsAssemblyTextBox = new System.Windows.Forms.TextBox();
            this.packagingPanelLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.packagingTotalCostTextBox = new System.Windows.Forms.TextBox();
            this.packingCostTextBox = new System.Windows.Forms.TextBox();
            this.totalPackagingDurationTextBox = new System.Windows.Forms.TextBox();
            this.packingCostLabel = new System.Windows.Forms.Label();
            this.totalPackagingDurationLabel = new System.Windows.Forms.Label();
            this.packagingMaterialCostTextBox = new System.Windows.Forms.TextBox();
            this.packagingMaterialCostLabel = new System.Windows.Forms.Label();
            this.totalDeviceCostTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.designingTabPage.SuspendLayout();
            this.weldingTabPage.SuspendLayout();
            this.assemblyAndPackagingTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.partsTabPage.SuspendLayout();
            this.otherCostsTabPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(936, 713);
            this.tabControl1.TabIndex = 0;
            // 
            // designingTabPage
            // 
            this.designingTabPage.Controls.Add(this.calculatedDesigningCostTextBox);
            this.designingTabPage.Controls.Add(this.designingCostTextBox);
            this.designingTabPage.Controls.Add(this.realDesigningDurationTextBox);
            this.designingTabPage.Controls.Add(this.plannedDesignDurationTextBox);
            this.designingTabPage.Controls.Add(this.calculatedDesigningCostLabel);
            this.designingTabPage.Controls.Add(this.designingCostLabel);
            this.designingTabPage.Controls.Add(this.realDesigningDurationLabel);
            this.designingTabPage.Controls.Add(this.plannedDesignDurationLabel);
            this.designingTabPage.Location = new System.Drawing.Point(4, 29);
            this.designingTabPage.Name = "designingTabPage";
            this.designingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.designingTabPage.Size = new System.Drawing.Size(928, 680);
            this.designingTabPage.TabIndex = 0;
            this.designingTabPage.Text = "Designing";
            this.designingTabPage.UseVisualStyleBackColor = true;
            // 
            // calculatedDesigningCostTextBox
            // 
            this.calculatedDesigningCostTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.calculatedDesigningCostTextBox.Enabled = false;
            this.calculatedDesigningCostTextBox.Location = new System.Drawing.Point(296, 180);
            this.calculatedDesigningCostTextBox.Name = "calculatedDesigningCostTextBox";
            this.calculatedDesigningCostTextBox.Size = new System.Drawing.Size(100, 26);
            this.calculatedDesigningCostTextBox.TabIndex = 15;
            this.calculatedDesigningCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // designingCostTextBox
            // 
            this.designingCostTextBox.Location = new System.Drawing.Point(296, 125);
            this.designingCostTextBox.Name = "designingCostTextBox";
            this.designingCostTextBox.Size = new System.Drawing.Size(100, 26);
            this.designingCostTextBox.TabIndex = 14;
            this.designingCostTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.designingCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // realDesigningDurationTextBox
            // 
            this.realDesigningDurationTextBox.Location = new System.Drawing.Point(659, 31);
            this.realDesigningDurationTextBox.Name = "realDesigningDurationTextBox";
            this.realDesigningDurationTextBox.Size = new System.Drawing.Size(100, 26);
            this.realDesigningDurationTextBox.TabIndex = 13;
            this.realDesigningDurationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // plannedDesignDurationTextBox
            // 
            this.plannedDesignDurationTextBox.Location = new System.Drawing.Point(238, 31);
            this.plannedDesignDurationTextBox.Name = "plannedDesignDurationTextBox";
            this.plannedDesignDurationTextBox.Size = new System.Drawing.Size(100, 26);
            this.plannedDesignDurationTextBox.TabIndex = 12;
            this.plannedDesignDurationTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.plannedDesignDurationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // calculatedDesigningCostLabel
            // 
            this.calculatedDesigningCostLabel.AutoSize = true;
            this.calculatedDesigningCostLabel.Location = new System.Drawing.Point(18, 183);
            this.calculatedDesigningCostLabel.Name = "calculatedDesigningCostLabel";
            this.calculatedDesigningCostLabel.Size = new System.Drawing.Size(229, 20);
            this.calculatedDesigningCostLabel.TabIndex = 11;
            this.calculatedDesigningCostLabel.Text = "Calculated designing total cost:";
            // 
            // designingCostLabel
            // 
            this.designingCostLabel.AutoSize = true;
            this.designingCostLabel.Location = new System.Drawing.Point(18, 128);
            this.designingCostLabel.Name = "designingCostLabel";
            this.designingCostLabel.Size = new System.Drawing.Size(260, 20);
            this.designingCostLabel.TabIndex = 10;
            this.designingCostLabel.Text = "Designing cost EUR/h without VAT:";
            // 
            // realDesigningDurationLabel
            // 
            this.realDesigningDurationLabel.AutoSize = true;
            this.realDesigningDurationLabel.Location = new System.Drawing.Point(473, 34);
            this.realDesigningDurationLabel.Name = "realDesigningDurationLabel";
            this.realDesigningDurationLabel.Size = new System.Drawing.Size(180, 20);
            this.realDesigningDurationLabel.TabIndex = 9;
            this.realDesigningDurationLabel.Text = "Real designing duration:";
            // 
            // plannedDesignDurationLabel
            // 
            this.plannedDesignDurationLabel.AutoSize = true;
            this.plannedDesignDurationLabel.Location = new System.Drawing.Point(18, 34);
            this.plannedDesignDurationLabel.Name = "plannedDesignDurationLabel";
            this.plannedDesignDurationLabel.Size = new System.Drawing.Size(205, 20);
            this.plannedDesignDurationLabel.TabIndex = 8;
            this.plannedDesignDurationLabel.Text = "Planned designing duration:";
            // 
            // weldingTabPage
            // 
            this.weldingTabPage.Controls.Add(this.calculatedWeldingCostTextBox);
            this.weldingTabPage.Controls.Add(this.weldingCostTextBox);
            this.weldingTabPage.Controls.Add(this.realWeldingDurationTextBox);
            this.weldingTabPage.Controls.Add(this.plannedWeldingDurationTextBox);
            this.weldingTabPage.Controls.Add(this.calculatedWeldingCostLabel);
            this.weldingTabPage.Controls.Add(this.weldingCostLabel);
            this.weldingTabPage.Controls.Add(this.realWeldingDurationLabel);
            this.weldingTabPage.Controls.Add(this.plannedWeldingDurationLabel);
            this.weldingTabPage.Location = new System.Drawing.Point(4, 29);
            this.weldingTabPage.Name = "weldingTabPage";
            this.weldingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.weldingTabPage.Size = new System.Drawing.Size(928, 680);
            this.weldingTabPage.TabIndex = 1;
            this.weldingTabPage.Text = "Welding";
            this.weldingTabPage.UseVisualStyleBackColor = true;
            // 
            // calculatedWeldingCostTextBox
            // 
            this.calculatedWeldingCostTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.calculatedWeldingCostTextBox.Enabled = false;
            this.calculatedWeldingCostTextBox.Location = new System.Drawing.Point(292, 168);
            this.calculatedWeldingCostTextBox.Name = "calculatedWeldingCostTextBox";
            this.calculatedWeldingCostTextBox.Size = new System.Drawing.Size(100, 26);
            this.calculatedWeldingCostTextBox.TabIndex = 15;
            this.calculatedWeldingCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // weldingCostTextBox
            // 
            this.weldingCostTextBox.Location = new System.Drawing.Point(292, 116);
            this.weldingCostTextBox.Name = "weldingCostTextBox";
            this.weldingCostTextBox.Size = new System.Drawing.Size(100, 26);
            this.weldingCostTextBox.TabIndex = 14;
            this.weldingCostTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.weldingCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // realWeldingDurationTextBox
            // 
            this.realWeldingDurationTextBox.Location = new System.Drawing.Point(664, 35);
            this.realWeldingDurationTextBox.Name = "realWeldingDurationTextBox";
            this.realWeldingDurationTextBox.Size = new System.Drawing.Size(119, 26);
            this.realWeldingDurationTextBox.TabIndex = 13;
            this.realWeldingDurationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // plannedWeldingDurationTextBox
            // 
            this.plannedWeldingDurationTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.plannedWeldingDurationTextBox.Enabled = false;
            this.plannedWeldingDurationTextBox.Location = new System.Drawing.Point(211, 35);
            this.plannedWeldingDurationTextBox.Name = "plannedWeldingDurationTextBox";
            this.plannedWeldingDurationTextBox.Size = new System.Drawing.Size(119, 26);
            this.plannedWeldingDurationTextBox.TabIndex = 12;
            this.plannedWeldingDurationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // calculatedWeldingCostLabel
            // 
            this.calculatedWeldingCostLabel.AutoSize = true;
            this.calculatedWeldingCostLabel.Location = new System.Drawing.Point(24, 171);
            this.calculatedWeldingCostLabel.Name = "calculatedWeldingCostLabel";
            this.calculatedWeldingCostLabel.Size = new System.Drawing.Size(214, 20);
            this.calculatedWeldingCostLabel.TabIndex = 11;
            this.calculatedWeldingCostLabel.Text = "Calculated welding total cost:";
            // 
            // weldingCostLabel
            // 
            this.weldingCostLabel.AutoSize = true;
            this.weldingCostLabel.Location = new System.Drawing.Point(24, 119);
            this.weldingCostLabel.Name = "weldingCostLabel";
            this.weldingCostLabel.Size = new System.Drawing.Size(250, 20);
            this.weldingCostLabel.TabIndex = 10;
            this.weldingCostLabel.Text = "Welding cost, EUR/h without VAT:";
            // 
            // realWeldingDurationLabel
            // 
            this.realWeldingDurationLabel.AutoSize = true;
            this.realWeldingDurationLabel.Location = new System.Drawing.Point(493, 38);
            this.realWeldingDurationLabel.Name = "realWeldingDurationLabel";
            this.realWeldingDurationLabel.Size = new System.Drawing.Size(165, 20);
            this.realWeldingDurationLabel.TabIndex = 9;
            this.realWeldingDurationLabel.Text = "Real welding duration:";
            // 
            // plannedWeldingDurationLabel
            // 
            this.plannedWeldingDurationLabel.AutoSize = true;
            this.plannedWeldingDurationLabel.Location = new System.Drawing.Point(24, 38);
            this.plannedWeldingDurationLabel.Name = "plannedWeldingDurationLabel";
            this.plannedWeldingDurationLabel.Size = new System.Drawing.Size(181, 20);
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
            this.assemblyAndPackagingTabPage.Location = new System.Drawing.Point(4, 29);
            this.assemblyAndPackagingTabPage.Name = "assemblyAndPackagingTabPage";
            this.assemblyAndPackagingTabPage.Size = new System.Drawing.Size(928, 680);
            this.assemblyAndPackagingTabPage.TabIndex = 2;
            this.assemblyAndPackagingTabPage.Text = "Assembly and packaging";
            this.assemblyAndPackagingTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.workManagementTotalCostTextBox);
            this.panel1.Controls.Add(this.workManagementCostTextBox);
            this.panel1.Controls.Add(this.totalWorkManagementDurationTextBox);
            this.panel1.Controls.Add(this.workManagementCostLabel);
            this.panel1.Controls.Add(this.totalWorkManagementDurationLabel);
            this.panel1.Location = new System.Drawing.Point(8, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 100);
            this.panel1.TabIndex = 4;
            // 
            // partsTabPage
            // 
            this.partsTabPage.Controls.Add(this.totalPartsCostLabel);
            this.partsTabPage.Controls.Add(this.totalPartsCostTextBox);
            this.partsTabPage.Controls.Add(this.button1);
            this.partsTabPage.Controls.Add(this.processPartsButton);
            this.partsTabPage.Location = new System.Drawing.Point(4, 29);
            this.partsTabPage.Name = "partsTabPage";
            this.partsTabPage.Size = new System.Drawing.Size(928, 680);
            this.partsTabPage.TabIndex = 3;
            this.partsTabPage.Text = "Parts";
            this.partsTabPage.UseVisualStyleBackColor = true;
            // 
            // totalPartsCostLabel
            // 
            this.totalPartsCostLabel.AutoSize = true;
            this.totalPartsCostLabel.Location = new System.Drawing.Point(298, 141);
            this.totalPartsCostLabel.Name = "totalPartsCostLabel";
            this.totalPartsCostLabel.Size = new System.Drawing.Size(122, 20);
            this.totalPartsCostLabel.TabIndex = 7;
            this.totalPartsCostLabel.Text = "Total parts cost:";
            // 
            // totalPartsCostTextBox
            // 
            this.totalPartsCostTextBox.Location = new System.Drawing.Point(441, 138);
            this.totalPartsCostTextBox.Name = "totalPartsCostTextBox";
            this.totalPartsCostTextBox.Size = new System.Drawing.Size(100, 26);
            this.totalPartsCostTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate total parts cost";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // processPartsButton
            // 
            this.processPartsButton.Location = new System.Drawing.Point(31, 36);
            this.processPartsButton.Name = "processPartsButton";
            this.processPartsButton.Size = new System.Drawing.Size(185, 55);
            this.processPartsButton.TabIndex = 4;
            this.processPartsButton.Text = "Process parts from Solidworks";
            this.processPartsButton.UseVisualStyleBackColor = true;
            // 
            // otherCostsTabPage
            // 
            this.otherCostsTabPage.Controls.Add(this.otherCostsTextBox);
            this.otherCostsTabPage.Controls.Add(this.otherCostsForOneDeviceTextBox);
            this.otherCostsTabPage.Controls.Add(this.otherCostsForOneDeviceLabel);
            this.otherCostsTabPage.Controls.Add(this.otherCostsDescriptionTextBox);
            this.otherCostsTabPage.Controls.Add(this.otherCostsDescriptionLabel);
            this.otherCostsTabPage.Controls.Add(this.otherCostsLabel);
            this.otherCostsTabPage.Location = new System.Drawing.Point(4, 29);
            this.otherCostsTabPage.Name = "otherCostsTabPage";
            this.otherCostsTabPage.Size = new System.Drawing.Size(928, 625);
            this.otherCostsTabPage.TabIndex = 4;
            this.otherCostsTabPage.Text = "Other costs";
            this.otherCostsTabPage.UseVisualStyleBackColor = true;
            // 
            // otherCostsTextBox
            // 
            this.otherCostsTextBox.Location = new System.Drawing.Point(261, 22);
            this.otherCostsTextBox.Name = "otherCostsTextBox";
            this.otherCostsTextBox.Size = new System.Drawing.Size(100, 26);
            this.otherCostsTextBox.TabIndex = 11;
            // 
            // otherCostsForOneDeviceTextBox
            // 
            this.otherCostsForOneDeviceTextBox.Location = new System.Drawing.Point(261, 265);
            this.otherCostsForOneDeviceTextBox.Name = "otherCostsForOneDeviceTextBox";
            this.otherCostsForOneDeviceTextBox.Size = new System.Drawing.Size(100, 26);
            this.otherCostsForOneDeviceTextBox.TabIndex = 10;
            // 
            // otherCostsForOneDeviceLabel
            // 
            this.otherCostsForOneDeviceLabel.AutoSize = true;
            this.otherCostsForOneDeviceLabel.Location = new System.Drawing.Point(8, 268);
            this.otherCostsForOneDeviceLabel.Name = "otherCostsForOneDeviceLabel";
            this.otherCostsForOneDeviceLabel.Size = new System.Drawing.Size(198, 20);
            this.otherCostsForOneDeviceLabel.TabIndex = 9;
            this.otherCostsForOneDeviceLabel.Text = "Other costs for one device:";
            // 
            // otherCostsDescriptionTextBox
            // 
            this.otherCostsDescriptionTextBox.Location = new System.Drawing.Point(12, 94);
            this.otherCostsDescriptionTextBox.Multiline = true;
            this.otherCostsDescriptionTextBox.Name = "otherCostsDescriptionTextBox";
            this.otherCostsDescriptionTextBox.Size = new System.Drawing.Size(903, 128);
            this.otherCostsDescriptionTextBox.TabIndex = 8;
            // 
            // otherCostsDescriptionLabel
            // 
            this.otherCostsDescriptionLabel.AutoSize = true;
            this.otherCostsDescriptionLabel.Location = new System.Drawing.Point(8, 71);
            this.otherCostsDescriptionLabel.Name = "otherCostsDescriptionLabel";
            this.otherCostsDescriptionLabel.Size = new System.Drawing.Size(172, 20);
            this.otherCostsDescriptionLabel.TabIndex = 7;
            this.otherCostsDescriptionLabel.Text = "Other costs description";
            // 
            // otherCostsLabel
            // 
            this.otherCostsLabel.AutoSize = true;
            this.otherCostsLabel.Location = new System.Drawing.Point(8, 25);
            this.otherCostsLabel.Name = "otherCostsLabel";
            this.otherCostsLabel.Size = new System.Drawing.Size(228, 20);
            this.otherCostsLabel.TabIndex = 6;
            this.otherCostsLabel.Text = "Other costs, EUR without VAT:";
            // 
            // amountOfDevicesTextBox
            // 
            this.amountOfDevicesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.amountOfDevicesTextBox.Location = new System.Drawing.Point(221, 730);
            this.amountOfDevicesTextBox.Name = "amountOfDevicesTextBox";
            this.amountOfDevicesTextBox.Size = new System.Drawing.Size(100, 26);
            this.amountOfDevicesTextBox.TabIndex = 5;
            this.amountOfDevicesTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.amountOfDevicesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integersOnlyTextBox_KeyPress);
            // 
            // totalDeviceCostLabel
            // 
            this.totalDeviceCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalDeviceCostLabel.AutoSize = true;
            this.totalDeviceCostLabel.Location = new System.Drawing.Point(16, 769);
            this.totalDeviceCostLabel.Name = "totalDeviceCostLabel";
            this.totalDeviceCostLabel.Size = new System.Drawing.Size(82, 20);
            this.totalDeviceCostLabel.TabIndex = 4;
            this.totalDeviceCostLabel.Text = "Total cost:";
            // 
            // amountOfDevicesLabel
            // 
            this.amountOfDevicesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.amountOfDevicesLabel.AutoSize = true;
            this.amountOfDevicesLabel.Location = new System.Drawing.Point(12, 733);
            this.amountOfDevicesLabel.Name = "amountOfDevicesLabel";
            this.amountOfDevicesLabel.Size = new System.Drawing.Size(203, 20);
            this.amountOfDevicesLabel.TabIndex = 3;
            this.amountOfDevicesLabel.Text = "Amount of ordered devices:";
            // 
            // workManagementPanelLabel
            // 
            this.workManagementPanelLabel.AutoSize = true;
            this.workManagementPanelLabel.Location = new System.Drawing.Point(8, 25);
            this.workManagementPanelLabel.Name = "workManagementPanelLabel";
            this.workManagementPanelLabel.Size = new System.Drawing.Size(144, 20);
            this.workManagementPanelLabel.TabIndex = 5;
            this.workManagementPanelLabel.Text = "Work management";
            // 
            // totalWorkManagementDurationLabel
            // 
            this.totalWorkManagementDurationLabel.AutoSize = true;
            this.totalWorkManagementDurationLabel.Location = new System.Drawing.Point(3, 16);
            this.totalWorkManagementDurationLabel.Name = "totalWorkManagementDurationLabel";
            this.totalWorkManagementDurationLabel.Size = new System.Drawing.Size(245, 20);
            this.totalWorkManagementDurationLabel.TabIndex = 0;
            this.totalWorkManagementDurationLabel.Text = "Total work management duration:";
            // 
            // workManagementCostLabel
            // 
            this.workManagementCostLabel.AutoSize = true;
            this.workManagementCostLabel.Location = new System.Drawing.Point(3, 55);
            this.workManagementCostLabel.Name = "workManagementCostLabel";
            this.workManagementCostLabel.Size = new System.Drawing.Size(212, 20);
            this.workManagementCostLabel.TabIndex = 1;
            this.workManagementCostLabel.Text = "Work management cost, €/h:";
            // 
            // totalWorkManagementDurationTextBox
            // 
            this.totalWorkManagementDurationTextBox.Location = new System.Drawing.Point(322, 13);
            this.totalWorkManagementDurationTextBox.Name = "totalWorkManagementDurationTextBox";
            this.totalWorkManagementDurationTextBox.Size = new System.Drawing.Size(100, 26);
            this.totalWorkManagementDurationTextBox.TabIndex = 2;
            this.totalWorkManagementDurationTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.totalWorkManagementDurationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // workManagementCostTextBox
            // 
            this.workManagementCostTextBox.Location = new System.Drawing.Point(322, 52);
            this.workManagementCostTextBox.Name = "workManagementCostTextBox";
            this.workManagementCostTextBox.Size = new System.Drawing.Size(100, 26);
            this.workManagementCostTextBox.TabIndex = 3;
            this.workManagementCostTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.workManagementCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // workManagementTotalCostTextBox
            // 
            this.workManagementTotalCostTextBox.Enabled = false;
            this.workManagementTotalCostTextBox.Location = new System.Drawing.Point(797, 49);
            this.workManagementTotalCostTextBox.Name = "workManagementTotalCostTextBox";
            this.workManagementTotalCostTextBox.Size = new System.Drawing.Size(100, 26);
            this.workManagementTotalCostTextBox.TabIndex = 4;
            // 
            // supplyPanelLabel
            // 
            this.supplyPanelLabel.AutoSize = true;
            this.supplyPanelLabel.Location = new System.Drawing.Point(8, 162);
            this.supplyPanelLabel.Name = "supplyPanelLabel";
            this.supplyPanelLabel.Size = new System.Drawing.Size(57, 20);
            this.supplyPanelLabel.TabIndex = 7;
            this.supplyPanelLabel.Text = "Supply";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.supplyTotalCostTextBox);
            this.panel2.Controls.Add(this.supplyCostTextBox);
            this.panel2.Controls.Add(this.totalSupplyDurationTextBox);
            this.panel2.Controls.Add(this.supplyCostLabel);
            this.panel2.Controls.Add(this.totalSupplyDurationLabel);
            this.panel2.Location = new System.Drawing.Point(8, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 100);
            this.panel2.TabIndex = 6;
            // 
            // supplyTotalCostTextBox
            // 
            this.supplyTotalCostTextBox.Enabled = false;
            this.supplyTotalCostTextBox.Location = new System.Drawing.Point(797, 49);
            this.supplyTotalCostTextBox.Name = "supplyTotalCostTextBox";
            this.supplyTotalCostTextBox.Size = new System.Drawing.Size(100, 26);
            this.supplyTotalCostTextBox.TabIndex = 4;
            // 
            // supplyCostTextBox
            // 
            this.supplyCostTextBox.Location = new System.Drawing.Point(322, 52);
            this.supplyCostTextBox.Name = "supplyCostTextBox";
            this.supplyCostTextBox.Size = new System.Drawing.Size(100, 26);
            this.supplyCostTextBox.TabIndex = 3;
            this.supplyCostTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.supplyCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // totalSupplyDurationTextBox
            // 
            this.totalSupplyDurationTextBox.Location = new System.Drawing.Point(322, 13);
            this.totalSupplyDurationTextBox.Name = "totalSupplyDurationTextBox";
            this.totalSupplyDurationTextBox.Size = new System.Drawing.Size(100, 26);
            this.totalSupplyDurationTextBox.TabIndex = 2;
            this.totalSupplyDurationTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.totalSupplyDurationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // supplyCostLabel
            // 
            this.supplyCostLabel.AutoSize = true;
            this.supplyCostLabel.Location = new System.Drawing.Point(3, 55);
            this.supplyCostLabel.Name = "supplyCostLabel";
            this.supplyCostLabel.Size = new System.Drawing.Size(125, 20);
            this.supplyCostLabel.TabIndex = 1;
            this.supplyCostLabel.Text = "Supply cost, €/h:";
            // 
            // totalSupplyDurationLabel
            // 
            this.totalSupplyDurationLabel.AutoSize = true;
            this.totalSupplyDurationLabel.Location = new System.Drawing.Point(3, 16);
            this.totalSupplyDurationLabel.Name = "totalSupplyDurationLabel";
            this.totalSupplyDurationLabel.Size = new System.Drawing.Size(159, 20);
            this.totalSupplyDurationLabel.TabIndex = 0;
            this.totalSupplyDurationLabel.Text = "Total supply duration:";
            // 
            // assemblyPanelLabel
            // 
            this.assemblyPanelLabel.AutoSize = true;
            this.assemblyPanelLabel.Location = new System.Drawing.Point(8, 303);
            this.assemblyPanelLabel.Name = "assemblyPanelLabel";
            this.assemblyPanelLabel.Size = new System.Drawing.Size(77, 20);
            this.assemblyPanelLabel.TabIndex = 9;
            this.assemblyPanelLabel.Text = "Assembly";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.individualComponentsAssemblyTextBox);
            this.panel3.Controls.Add(this.individualComponentsAssemblyLabel);
            this.panel3.Controls.Add(this.assemblyToParentDurationTextBox);
            this.panel3.Controls.Add(this.assemblyToParentDurationLabel);
            this.panel3.Controls.Add(this.assemblyTotalCostTextBox);
            this.panel3.Controls.Add(this.assemblyCostTextBox);
            this.panel3.Controls.Add(this.totalAssemblyDurationTextBox);
            this.panel3.Controls.Add(this.assemblyCostLabel);
            this.panel3.Controls.Add(this.totalAssemblyDurationLabel);
            this.panel3.Location = new System.Drawing.Point(8, 326);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(912, 187);
            this.panel3.TabIndex = 8;
            // 
            // assemblyTotalCostTextBox
            // 
            this.assemblyTotalCostTextBox.Enabled = false;
            this.assemblyTotalCostTextBox.Location = new System.Drawing.Point(797, 140);
            this.assemblyTotalCostTextBox.Name = "assemblyTotalCostTextBox";
            this.assemblyTotalCostTextBox.Size = new System.Drawing.Size(100, 26);
            this.assemblyTotalCostTextBox.TabIndex = 4;
            // 
            // assemblyCostTextBox
            // 
            this.assemblyCostTextBox.Location = new System.Drawing.Point(322, 136);
            this.assemblyCostTextBox.Name = "assemblyCostTextBox";
            this.assemblyCostTextBox.Size = new System.Drawing.Size(100, 26);
            this.assemblyCostTextBox.TabIndex = 3;
            this.assemblyCostTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.assemblyCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // totalAssemblyDurationTextBox
            // 
            this.totalAssemblyDurationTextBox.Enabled = false;
            this.totalAssemblyDurationTextBox.Location = new System.Drawing.Point(322, 97);
            this.totalAssemblyDurationTextBox.Name = "totalAssemblyDurationTextBox";
            this.totalAssemblyDurationTextBox.Size = new System.Drawing.Size(100, 26);
            this.totalAssemblyDurationTextBox.TabIndex = 2;
            // 
            // assemblyCostLabel
            // 
            this.assemblyCostLabel.AutoSize = true;
            this.assemblyCostLabel.Location = new System.Drawing.Point(3, 139);
            this.assemblyCostLabel.Name = "assemblyCostLabel";
            this.assemblyCostLabel.Size = new System.Drawing.Size(145, 20);
            this.assemblyCostLabel.TabIndex = 1;
            this.assemblyCostLabel.Text = "Assembly cost, €/h:";
            // 
            // totalAssemblyDurationLabel
            // 
            this.totalAssemblyDurationLabel.AutoSize = true;
            this.totalAssemblyDurationLabel.Location = new System.Drawing.Point(3, 100);
            this.totalAssemblyDurationLabel.Name = "totalAssemblyDurationLabel";
            this.totalAssemblyDurationLabel.Size = new System.Drawing.Size(180, 20);
            this.totalAssemblyDurationLabel.TabIndex = 0;
            this.totalAssemblyDurationLabel.Text = "Total assembly duration:";
            // 
            // assemblyToParentDurationTextBox
            // 
            this.assemblyToParentDurationTextBox.Location = new System.Drawing.Point(322, 57);
            this.assemblyToParentDurationTextBox.Name = "assemblyToParentDurationTextBox";
            this.assemblyToParentDurationTextBox.Size = new System.Drawing.Size(100, 26);
            this.assemblyToParentDurationTextBox.TabIndex = 6;
            this.assemblyToParentDurationTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.assemblyToParentDurationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // assemblyToParentDurationLabel
            // 
            this.assemblyToParentDurationLabel.AutoSize = true;
            this.assemblyToParentDurationLabel.Location = new System.Drawing.Point(3, 60);
            this.assemblyToParentDurationLabel.Name = "assemblyToParentDurationLabel";
            this.assemblyToParentDurationLabel.Size = new System.Drawing.Size(211, 20);
            this.assemblyToParentDurationLabel.TabIndex = 5;
            this.assemblyToParentDurationLabel.Text = "Assembly to parent duration:";
            // 
            // individualComponentsAssemblyLabel
            // 
            this.individualComponentsAssemblyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.individualComponentsAssemblyLabel.AutoSize = true;
            this.individualComponentsAssemblyLabel.Location = new System.Drawing.Point(3, 20);
            this.individualComponentsAssemblyLabel.Name = "individualComponentsAssemblyLabel";
            this.individualComponentsAssemblyLabel.Size = new System.Drawing.Size(303, 20);
            this.individualComponentsAssemblyLabel.TabIndex = 7;
            this.individualComponentsAssemblyLabel.Text = "Individual components assembly duration:";
            // 
            // individualComponentsAssemblyTextBox
            // 
            this.individualComponentsAssemblyTextBox.Location = new System.Drawing.Point(322, 17);
            this.individualComponentsAssemblyTextBox.Name = "individualComponentsAssemblyTextBox";
            this.individualComponentsAssemblyTextBox.Size = new System.Drawing.Size(100, 26);
            this.individualComponentsAssemblyTextBox.TabIndex = 8;
            this.individualComponentsAssemblyTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.individualComponentsAssemblyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // packagingPanelLabel
            // 
            this.packagingPanelLabel.AutoSize = true;
            this.packagingPanelLabel.Location = new System.Drawing.Point(8, 530);
            this.packagingPanelLabel.Name = "packagingPanelLabel";
            this.packagingPanelLabel.Size = new System.Drawing.Size(83, 20);
            this.packagingPanelLabel.TabIndex = 11;
            this.packagingPanelLabel.Text = "Packaging";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.packagingMaterialCostTextBox);
            this.panel4.Controls.Add(this.packagingMaterialCostLabel);
            this.panel4.Controls.Add(this.packagingTotalCostTextBox);
            this.panel4.Controls.Add(this.packingCostTextBox);
            this.panel4.Controls.Add(this.totalPackagingDurationTextBox);
            this.panel4.Controls.Add(this.packingCostLabel);
            this.panel4.Controls.Add(this.totalPackagingDurationLabel);
            this.panel4.Location = new System.Drawing.Point(8, 553);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(912, 100);
            this.panel4.TabIndex = 10;
            // 
            // packagingTotalCostTextBox
            // 
            this.packagingTotalCostTextBox.Enabled = false;
            this.packagingTotalCostTextBox.Location = new System.Drawing.Point(797, 49);
            this.packagingTotalCostTextBox.Name = "packagingTotalCostTextBox";
            this.packagingTotalCostTextBox.Size = new System.Drawing.Size(100, 26);
            this.packagingTotalCostTextBox.TabIndex = 4;
            // 
            // packingCostTextBox
            // 
            this.packingCostTextBox.Location = new System.Drawing.Point(322, 52);
            this.packingCostTextBox.Name = "packingCostTextBox";
            this.packingCostTextBox.Size = new System.Drawing.Size(100, 26);
            this.packingCostTextBox.TabIndex = 3;
            this.packingCostTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.packingCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // totalPackagingDurationTextBox
            // 
            this.totalPackagingDurationTextBox.Location = new System.Drawing.Point(322, 13);
            this.totalPackagingDurationTextBox.Name = "totalPackagingDurationTextBox";
            this.totalPackagingDurationTextBox.Size = new System.Drawing.Size(100, 26);
            this.totalPackagingDurationTextBox.TabIndex = 2;
            this.totalPackagingDurationTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.totalPackagingDurationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // packingCostLabel
            // 
            this.packingCostLabel.AutoSize = true;
            this.packingCostLabel.Location = new System.Drawing.Point(3, 55);
            this.packingCostLabel.Name = "packingCostLabel";
            this.packingCostLabel.Size = new System.Drawing.Size(133, 20);
            this.packingCostLabel.TabIndex = 1;
            this.packingCostLabel.Text = "Packing cost, €/h:";
            // 
            // totalPackagingDurationLabel
            // 
            this.totalPackagingDurationLabel.AutoSize = true;
            this.totalPackagingDurationLabel.Location = new System.Drawing.Point(3, 16);
            this.totalPackagingDurationLabel.Name = "totalPackagingDurationLabel";
            this.totalPackagingDurationLabel.Size = new System.Drawing.Size(169, 20);
            this.totalPackagingDurationLabel.TabIndex = 0;
            this.totalPackagingDurationLabel.Text = "Total packing duration:";
            // 
            // packagingMaterialCostTextBox
            // 
            this.packagingMaterialCostTextBox.Location = new System.Drawing.Point(797, 13);
            this.packagingMaterialCostTextBox.Name = "packagingMaterialCostTextBox";
            this.packagingMaterialCostTextBox.Size = new System.Drawing.Size(100, 26);
            this.packagingMaterialCostTextBox.TabIndex = 6;
            this.packagingMaterialCostTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.packagingMaterialCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // packagingMaterialCostLabel
            // 
            this.packagingMaterialCostLabel.AutoSize = true;
            this.packagingMaterialCostLabel.Location = new System.Drawing.Point(478, 16);
            this.packagingMaterialCostLabel.Name = "packagingMaterialCostLabel";
            this.packagingMaterialCostLabel.Size = new System.Drawing.Size(198, 20);
            this.packagingMaterialCostLabel.TabIndex = 5;
            this.packagingMaterialCostLabel.Text = "Packaging material cost, €:";
            // 
            // totalDeviceCostTextBox
            // 
            this.totalDeviceCostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalDeviceCostTextBox.Enabled = false;
            this.totalDeviceCostTextBox.Location = new System.Drawing.Point(219, 766);
            this.totalDeviceCostTextBox.Name = "totalDeviceCostTextBox";
            this.totalDeviceCostTextBox.Size = new System.Drawing.Size(100, 26);
            this.totalDeviceCostTextBox.TabIndex = 6;
            // 
            // DeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 805);
            this.Controls.Add(this.totalDeviceCostTextBox);
            this.Controls.Add(this.amountOfDevicesTextBox);
            this.Controls.Add(this.totalDeviceCostLabel);
            this.Controls.Add(this.amountOfDevicesLabel);
            this.Controls.Add(this.tabControl1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.partsTabPage.ResumeLayout(false);
            this.partsTabPage.PerformLayout();
            this.otherCostsTabPage.ResumeLayout(false);
            this.otherCostsTabPage.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private TextBox realDesigningDurationTextBox;
        private TextBox plannedDesignDurationTextBox;
        private System.Windows.Forms.Label calculatedDesigningCostLabel;
        private System.Windows.Forms.Label designingCostLabel;
        private System.Windows.Forms.Label realDesigningDurationLabel;
        private System.Windows.Forms.Label plannedDesignDurationLabel;
        private TextBox calculatedWeldingCostTextBox;
        private TextBox weldingCostTextBox;
        private TextBox realWeldingDurationTextBox;
        private TextBox plannedWeldingDurationTextBox;
        private System.Windows.Forms.Label calculatedWeldingCostLabel;
        private System.Windows.Forms.Label weldingCostLabel;
        private System.Windows.Forms.Label realWeldingDurationLabel;
        private System.Windows.Forms.Label plannedWeldingDurationLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label totalPartsCostLabel;
        private TextBox totalPartsCostTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button processPartsButton;
        private TextBox otherCostsTextBox;
        private TextBox otherCostsForOneDeviceTextBox;
        private System.Windows.Forms.Label otherCostsForOneDeviceLabel;
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
        private TextBox totalAssemblyDurationTextBox;
        private Label assemblyCostLabel;
        private Label totalAssemblyDurationLabel;
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
    }
}