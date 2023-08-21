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
            this.weldingTabPage = new System.Windows.Forms.TabPage();
            this.assemblyAndPackagingTabPage = new System.Windows.Forms.TabPage();
            this.partsTabPage = new System.Windows.Forms.TabPage();
            this.otherCostsTabPage = new System.Windows.Forms.TabPage();
            this.calculatedDesigningCostTextBox = new TextBox();
            this.designingCostTextBox = new TextBox();
            this.realDesigningDurationTextBox = new TextBox();
            this.plannedDesignDurationTextBox = new TextBox();
            this.calculatedDesigningCostLabel = new System.Windows.Forms.Label();
            this.designingCostLabel = new System.Windows.Forms.Label();
            this.realDesigningDurationLabel = new System.Windows.Forms.Label();
            this.plannedDesignDurationLabel = new System.Windows.Forms.Label();
            this.calculatedWeldingCostTextBox = new TextBox();
            this.weldingCostTextBox = new TextBox();
            this.realWeldingDurationTextBox = new TextBox();
            this.plannedWeldingDurationTextBox = new TextBox();
            this.calculatedWeldingCostLabel = new System.Windows.Forms.Label();
            this.weldingCostLabel = new System.Windows.Forms.Label();
            this.realWeldingDurationLabel = new System.Windows.Forms.Label();
            this.plannedWeldingDurationLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalPartsCostLabel = new System.Windows.Forms.Label();
            this.totalPartsCostTextBox = new TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.processPartsButton = new System.Windows.Forms.Button();
            this.otherCostsTextBox = new TextBox();
            this.otherCostsForOneDeviceTextBox = new TextBox();
            this.otherCostsForOneDeviceLabel = new System.Windows.Forms.Label();
            this.otherCostsDescriptionTextBox = new TextBox();
            this.otherCostsDescriptionLabel = new System.Windows.Forms.Label();
            this.otherCostsLabel = new System.Windows.Forms.Label();
            this.amountOfDevicesTextBox = new TextBox();
            this.totalDeviceCostLabel = new System.Windows.Forms.Label();
            this.amountOfDevicesLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.designingTabPage.SuspendLayout();
            this.weldingTabPage.SuspendLayout();
            this.assemblyAndPackagingTabPage.SuspendLayout();
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(936, 658);
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
            this.designingTabPage.Size = new System.Drawing.Size(859, 660);
            this.designingTabPage.TabIndex = 0;
            this.designingTabPage.Text = "Designing";
            this.designingTabPage.UseVisualStyleBackColor = true;
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
            this.weldingTabPage.Size = new System.Drawing.Size(859, 660);
            this.weldingTabPage.TabIndex = 1;
            this.weldingTabPage.Text = "Welding";
            this.weldingTabPage.UseVisualStyleBackColor = true;
            // 
            // assemblyAndPackagingTabPage
            // 
            this.assemblyAndPackagingTabPage.Controls.Add(this.panel4);
            this.assemblyAndPackagingTabPage.Controls.Add(this.panel3);
            this.assemblyAndPackagingTabPage.Controls.Add(this.panel2);
            this.assemblyAndPackagingTabPage.Controls.Add(this.panel1);
            this.assemblyAndPackagingTabPage.Location = new System.Drawing.Point(4, 29);
            this.assemblyAndPackagingTabPage.Name = "assemblyAndPackagingTabPage";
            this.assemblyAndPackagingTabPage.Size = new System.Drawing.Size(928, 660);
            this.assemblyAndPackagingTabPage.TabIndex = 2;
            this.assemblyAndPackagingTabPage.Text = "Assembly and packaging";
            this.assemblyAndPackagingTabPage.UseVisualStyleBackColor = true;
            // 
            // partsTabPage
            // 
            this.partsTabPage.Controls.Add(this.totalPartsCostLabel);
            this.partsTabPage.Controls.Add(this.totalPartsCostTextBox);
            this.partsTabPage.Controls.Add(this.button1);
            this.partsTabPage.Controls.Add(this.processPartsButton);
            this.partsTabPage.Location = new System.Drawing.Point(4, 29);
            this.partsTabPage.Name = "partsTabPage";
            this.partsTabPage.Size = new System.Drawing.Size(928, 660);
            this.partsTabPage.TabIndex = 3;
            this.partsTabPage.Text = "Parts";
            this.partsTabPage.UseVisualStyleBackColor = true;
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
            // calculatedDesigningCostTextBox
            // 
            this.calculatedDesigningCostTextBox.Location = new System.Drawing.Point(296, 180);
            this.calculatedDesigningCostTextBox.Name = "calculatedDesigningCostTextBox";
            this.calculatedDesigningCostTextBox.Size = new System.Drawing.Size(100, 26);
            this.calculatedDesigningCostTextBox.TabIndex = 15;
            // 
            // designingCostTextBox
            // 
            this.designingCostTextBox.Location = new System.Drawing.Point(296, 125);
            this.designingCostTextBox.Name = "designingCostTextBox";
            this.designingCostTextBox.Size = new System.Drawing.Size(100, 26);
            this.designingCostTextBox.TabIndex = 14;
            // 
            // realDesigningDurationTextBox
            // 
            this.realDesigningDurationTextBox.Location = new System.Drawing.Point(659, 31);
            this.realDesigningDurationTextBox.Name = "realDesigningDurationTextBox";
            this.realDesigningDurationTextBox.Size = new System.Drawing.Size(100, 26);
            this.realDesigningDurationTextBox.TabIndex = 13;
            // 
            // plannedDesignDurationTextBox
            // 
            this.plannedDesignDurationTextBox.Location = new System.Drawing.Point(238, 31);
            this.plannedDesignDurationTextBox.Name = "plannedDesignDurationTextBox";
            this.plannedDesignDurationTextBox.Size = new System.Drawing.Size(100, 26);
            this.plannedDesignDurationTextBox.TabIndex = 12;
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
            // calculatedWeldingCostTextBox
            // 
            this.calculatedWeldingCostTextBox.Location = new System.Drawing.Point(292, 168);
            this.calculatedWeldingCostTextBox.Name = "calculatedWeldingCostTextBox";
            this.calculatedWeldingCostTextBox.Size = new System.Drawing.Size(100, 26);
            this.calculatedWeldingCostTextBox.TabIndex = 15;
            // 
            // weldingCostTextBox
            // 
            this.weldingCostTextBox.Location = new System.Drawing.Point(292, 116);
            this.weldingCostTextBox.Name = "weldingCostTextBox";
            this.weldingCostTextBox.Size = new System.Drawing.Size(100, 26);
            this.weldingCostTextBox.TabIndex = 14;
            // 
            // realWeldingDurationTextBox
            // 
            this.realWeldingDurationTextBox.Location = new System.Drawing.Point(664, 35);
            this.realWeldingDurationTextBox.Name = "realWeldingDurationTextBox";
            this.realWeldingDurationTextBox.Size = new System.Drawing.Size(119, 26);
            this.realWeldingDurationTextBox.TabIndex = 13;
            // 
            // plannedWeldingDurationTextBox
            // 
            this.plannedWeldingDurationTextBox.Location = new System.Drawing.Point(211, 35);
            this.plannedWeldingDurationTextBox.Name = "plannedWeldingDurationTextBox";
            this.plannedWeldingDurationTextBox.Size = new System.Drawing.Size(119, 26);
            this.plannedWeldingDurationTextBox.TabIndex = 12;
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
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(17, 381);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(904, 100);
            this.panel4.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(17, 261);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(904, 100);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(17, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 100);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(17, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 100);
            this.panel1.TabIndex = 4;
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
            this.amountOfDevicesTextBox.Location = new System.Drawing.Point(221, 675);
            this.amountOfDevicesTextBox.Name = "amountOfDevicesTextBox";
            this.amountOfDevicesTextBox.Size = new System.Drawing.Size(100, 26);
            this.amountOfDevicesTextBox.TabIndex = 5;
            // 
            // totalDeviceCostLabel
            // 
            this.totalDeviceCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalDeviceCostLabel.AutoSize = true;
            this.totalDeviceCostLabel.Location = new System.Drawing.Point(16, 714);
            this.totalDeviceCostLabel.Name = "totalDeviceCostLabel";
            this.totalDeviceCostLabel.Size = new System.Drawing.Size(82, 20);
            this.totalDeviceCostLabel.TabIndex = 4;
            this.totalDeviceCostLabel.Text = "Total cost:";
            // 
            // amountOfDevicesLabel
            // 
            this.amountOfDevicesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.amountOfDevicesLabel.AutoSize = true;
            this.amountOfDevicesLabel.Location = new System.Drawing.Point(12, 678);
            this.amountOfDevicesLabel.Name = "amountOfDevicesLabel";
            this.amountOfDevicesLabel.Size = new System.Drawing.Size(203, 20);
            this.amountOfDevicesLabel.TabIndex = 3;
            this.amountOfDevicesLabel.Text = "Amount of ordered devices:";
            // 
            // DeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 750);
            this.Controls.Add(this.amountOfDevicesTextBox);
            this.Controls.Add(this.totalDeviceCostLabel);
            this.Controls.Add(this.amountOfDevicesLabel);
            this.Controls.Add(this.tabControl1);
            this.Name = "DeviceForm";
            this.Text = "DeviceForm";
            this.tabControl1.ResumeLayout(false);
            this.designingTabPage.ResumeLayout(false);
            this.designingTabPage.PerformLayout();
            this.weldingTabPage.ResumeLayout(false);
            this.weldingTabPage.PerformLayout();
            this.assemblyAndPackagingTabPage.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
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
    }
}