using System.Windows.Forms;

namespace Janitor_V1
{
    partial class DetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsForm));
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.manufacturingTabPage = new System.Windows.Forms.TabPage();
            this.programmingCostTextBox = new System.Windows.Forms.TextBox();
            this.singlePieceManufacturingDurationTextBox = new System.Windows.Forms.TextBox();
            this.manufacturingCostTextBox = new System.Windows.Forms.TextBox();
            this.programmingDurationTextBox = new System.Windows.Forms.TextBox();
            this.amountOfThisPartTextBox = new System.Windows.Forms.TextBox();
            this.materialCostTextBox = new System.Windows.Forms.TextBox();
            this.materialWeightTextBox = new System.Windows.Forms.TextBox();
            this.manufacturingCostLabel = new System.Windows.Forms.Label();
            this.singlePieceManufacturingDurationLabel = new System.Windows.Forms.Label();
            this.programmingCostLabel = new System.Windows.Forms.Label();
            this.programmingDurationLabel = new System.Windows.Forms.Label();
            this.amountOfThisPartLabel = new System.Windows.Forms.Label();
            this.materialCostLabel = new System.Windows.Forms.Label();
            this.materialWeightLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.stripsTabPage = new System.Windows.Forms.TabPage();
            this.markupForStripTextBox = new System.Windows.Forms.TextBox();
            this.stripPurchaseCostTextBox = new System.Windows.Forms.TextBox();
            this.stripWidthTextBox = new System.Windows.Forms.TextBox();
            this.stripLengthTextBox = new System.Windows.Forms.TextBox();
            this.stripMaterialCostTextBox = new System.Windows.Forms.TextBox();
            this.markupForStripLabel = new System.Windows.Forms.Label();
            this.stripPurchaseCostLabel = new System.Windows.Forms.Label();
            this.stripWidthLabel = new System.Windows.Forms.Label();
            this.stripLengthLabel = new System.Windows.Forms.Label();
            this.stripMaterialCostLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.stripTypeLabel = new System.Windows.Forms.Label();
            this.purchasesTabPage = new System.Windows.Forms.TabPage();
            this.markupCostPurchaseTextBox = new System.Windows.Forms.TextBox();
            this.purchaseCostTextBox = new System.Windows.Forms.TextBox();
            this.technicalParametersTextBox = new System.Windows.Forms.TextBox();
            this.vendorNoTextBox = new System.Windows.Forms.TextBox();
            this.supplierTextBox = new System.Windows.Forms.TextBox();
            this.markupCostPurchaseLabel = new System.Windows.Forms.Label();
            this.purchaseCostLabel = new System.Windows.Forms.Label();
            this.technicalParametersLabel = new System.Windows.Forms.Label();
            this.vendorNoLabel = new System.Windows.Forms.Label();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.weldingTabPage = new System.Windows.Forms.TabPage();
            this.minutesLabel1 = new System.Windows.Forms.Label();
            this.hoursLabel1 = new System.Windows.Forms.Label();
            this.plannedWeldingDurationMinuteTextBox = new System.Windows.Forms.TextBox();
            this.plannedWeldingDurationHourTextBox = new System.Windows.Forms.TextBox();
            this.plannedWeldingDurationLabel = new System.Windows.Forms.Label();
            this.assemblyTabPage = new System.Windows.Forms.TabPage();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.assemblyToParentNodeDurationMinuteTextBox = new System.Windows.Forms.TextBox();
            this.combinedAssemblyTimeMinuteTextBox = new System.Windows.Forms.TextBox();
            this.individualComponentAssemblyDurationMinuteTextBox = new System.Windows.Forms.TextBox();
            this.childNodeAssemblyDurationMinuteTextBox = new System.Windows.Forms.TextBox();
            this.assemblyToParentNodeDurationHourTextBox = new System.Windows.Forms.TextBox();
            this.combinedAssemblyTimeHourTextBox = new System.Windows.Forms.TextBox();
            this.individualComponentAssemblyDurationHourTextBox = new System.Windows.Forms.TextBox();
            this.childNodeAssemblyDurationHourTextBox = new System.Windows.Forms.TextBox();
            this.combinedAssemblyTimeLabel = new System.Windows.Forms.Label();
            this.assemblyToParentNodeDurationLabel = new System.Windows.Forms.Label();
            this.individualComponentAssemblyDurationLabel = new System.Windows.Forms.Label();
            this.childNodeAssemblyDurationLabel = new System.Windows.Forms.Label();
            this.otherCostsTabPage = new System.Windows.Forms.TabPage();
            this.otherCostsTextBox = new System.Windows.Forms.TextBox();
            this.otherCostsDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.otherCostsDescriptionLabel = new System.Windows.Forms.Label();
            this.otherCostsLabel = new System.Windows.Forms.Label();
            this.propertiesTabPage = new System.Windows.Forms.TabPage();
            this.calculatedPriceLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.partDetailsPanel = new System.Windows.Forms.Panel();
            this.savePartButton = new System.Windows.Forms.Button();
            this.assemblyDetailsPanel = new System.Windows.Forms.Panel();
            this.saveAssemblyButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.takePictureButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.manufacturingTabPage.SuspendLayout();
            this.stripsTabPage.SuspendLayout();
            this.purchasesTabPage.SuspendLayout();
            this.weldingTabPage.SuspendLayout();
            this.assemblyTabPage.SuspendLayout();
            this.otherCostsTabPage.SuspendLayout();
            this.propertiesTabPage.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            this.partDetailsPanel.SuspendLayout();
            this.assemblyDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.generalTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(2, 2);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(2);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(588, 365);
            this.propertyGrid1.TabIndex = 0;
            this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.manufacturingTabPage);
            this.tabControl1.Controls.Add(this.stripsTabPage);
            this.tabControl1.Controls.Add(this.purchasesTabPage);
            this.tabControl1.Controls.Add(this.weldingTabPage);
            this.tabControl1.Controls.Add(this.assemblyTabPage);
            this.tabControl1.Controls.Add(this.otherCostsTabPage);
            this.tabControl1.Controls.Add(this.generalTabPage);
            this.tabControl1.Controls.Add(this.propertiesTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 395);
            this.tabControl1.TabIndex = 1;
            // 
            // manufacturingTabPage
            // 
            this.manufacturingTabPage.Controls.Add(this.programmingCostTextBox);
            this.manufacturingTabPage.Controls.Add(this.singlePieceManufacturingDurationTextBox);
            this.manufacturingTabPage.Controls.Add(this.manufacturingCostTextBox);
            this.manufacturingTabPage.Controls.Add(this.programmingDurationTextBox);
            this.manufacturingTabPage.Controls.Add(this.amountOfThisPartTextBox);
            this.manufacturingTabPage.Controls.Add(this.materialCostTextBox);
            this.manufacturingTabPage.Controls.Add(this.materialWeightTextBox);
            this.manufacturingTabPage.Controls.Add(this.manufacturingCostLabel);
            this.manufacturingTabPage.Controls.Add(this.singlePieceManufacturingDurationLabel);
            this.manufacturingTabPage.Controls.Add(this.programmingCostLabel);
            this.manufacturingTabPage.Controls.Add(this.programmingDurationLabel);
            this.manufacturingTabPage.Controls.Add(this.amountOfThisPartLabel);
            this.manufacturingTabPage.Controls.Add(this.materialCostLabel);
            this.manufacturingTabPage.Controls.Add(this.materialWeightLabel);
            this.manufacturingTabPage.Location = new System.Drawing.Point(4, 22);
            this.manufacturingTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.manufacturingTabPage.Name = "manufacturingTabPage";
            this.manufacturingTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.manufacturingTabPage.Size = new System.Drawing.Size(592, 369);
            this.manufacturingTabPage.TabIndex = 0;
            this.manufacturingTabPage.Text = "Manufacturing";
            this.manufacturingTabPage.UseVisualStyleBackColor = true;
            // 
            // programmingCostTextBox
            // 
            this.programmingCostTextBox.Location = new System.Drawing.Point(281, 119);
            this.programmingCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.programmingCostTextBox.Name = "programmingCostTextBox";
            this.programmingCostTextBox.Size = new System.Drawing.Size(68, 20);
            this.programmingCostTextBox.TabIndex = 15;
            // 
            // singlePieceManufacturingDurationTextBox
            // 
            this.singlePieceManufacturingDurationTextBox.Location = new System.Drawing.Point(281, 145);
            this.singlePieceManufacturingDurationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.singlePieceManufacturingDurationTextBox.Name = "singlePieceManufacturingDurationTextBox";
            this.singlePieceManufacturingDurationTextBox.Size = new System.Drawing.Size(68, 20);
            this.singlePieceManufacturingDurationTextBox.TabIndex = 14;
            // 
            // manufacturingCostTextBox
            // 
            this.manufacturingCostTextBox.Location = new System.Drawing.Point(281, 173);
            this.manufacturingCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.manufacturingCostTextBox.Name = "manufacturingCostTextBox";
            this.manufacturingCostTextBox.Size = new System.Drawing.Size(68, 20);
            this.manufacturingCostTextBox.TabIndex = 13;
            // 
            // programmingDurationTextBox
            // 
            this.programmingDurationTextBox.Location = new System.Drawing.Point(281, 93);
            this.programmingDurationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.programmingDurationTextBox.Name = "programmingDurationTextBox";
            this.programmingDurationTextBox.Size = new System.Drawing.Size(68, 20);
            this.programmingDurationTextBox.TabIndex = 12;
            // 
            // amountOfThisPartTextBox
            // 
            this.amountOfThisPartTextBox.Location = new System.Drawing.Point(281, 65);
            this.amountOfThisPartTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.amountOfThisPartTextBox.Name = "amountOfThisPartTextBox";
            this.amountOfThisPartTextBox.Size = new System.Drawing.Size(68, 20);
            this.amountOfThisPartTextBox.TabIndex = 11;
            // 
            // materialCostTextBox
            // 
            this.materialCostTextBox.Location = new System.Drawing.Point(281, 40);
            this.materialCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.materialCostTextBox.Name = "materialCostTextBox";
            this.materialCostTextBox.Size = new System.Drawing.Size(68, 20);
            this.materialCostTextBox.TabIndex = 10;
            // 
            // materialWeightTextBox
            // 
            this.materialWeightTextBox.Location = new System.Drawing.Point(281, 12);
            this.materialWeightTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.materialWeightTextBox.Name = "materialWeightTextBox";
            this.materialWeightTextBox.Size = new System.Drawing.Size(68, 20);
            this.materialWeightTextBox.TabIndex = 9;
            // 
            // manufacturingCostLabel
            // 
            this.manufacturingCostLabel.AutoSize = true;
            this.manufacturingCostLabel.Location = new System.Drawing.Point(12, 175);
            this.manufacturingCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manufacturingCostLabel.Name = "manufacturingCostLabel";
            this.manufacturingCostLabel.Size = new System.Drawing.Size(203, 15);
            this.manufacturingCostLabel.TabIndex = 8;
            this.manufacturingCostLabel.Text = "Manufacturing cost, €/h without VAT:";
            // 
            // singlePieceManufacturingDurationLabel
            // 
            this.singlePieceManufacturingDurationLabel.AutoSize = true;
            this.singlePieceManufacturingDurationLabel.Location = new System.Drawing.Point(12, 147);
            this.singlePieceManufacturingDurationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.singlePieceManufacturingDurationLabel.Name = "singlePieceManufacturingDurationLabel";
            this.singlePieceManufacturingDurationLabel.Size = new System.Drawing.Size(235, 15);
            this.singlePieceManufacturingDurationLabel.TabIndex = 7;
            this.singlePieceManufacturingDurationLabel.Text = "Single piece manufacturing duration, min:";
            // 
            // programmingCostLabel
            // 
            this.programmingCostLabel.AutoSize = true;
            this.programmingCostLabel.Location = new System.Drawing.Point(12, 121);
            this.programmingCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.programmingCostLabel.Name = "programmingCostLabel";
            this.programmingCostLabel.Size = new System.Drawing.Size(134, 15);
            this.programmingCostLabel.TabIndex = 6;
            this.programmingCostLabel.Text = "Programming cost, €/h:";
            // 
            // programmingDurationLabel
            // 
            this.programmingDurationLabel.AutoSize = true;
            this.programmingDurationLabel.Location = new System.Drawing.Point(12, 95);
            this.programmingDurationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.programmingDurationLabel.Name = "programmingDurationLabel";
            this.programmingDurationLabel.Size = new System.Drawing.Size(147, 15);
            this.programmingDurationLabel.TabIndex = 5;
            this.programmingDurationLabel.Text = "Programming duration, h:";
            // 
            // amountOfThisPartLabel
            // 
            this.amountOfThisPartLabel.AutoSize = true;
            this.amountOfThisPartLabel.Location = new System.Drawing.Point(12, 67);
            this.amountOfThisPartLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.amountOfThisPartLabel.Name = "amountOfThisPartLabel";
            this.amountOfThisPartLabel.Size = new System.Drawing.Size(162, 15);
            this.amountOfThisPartLabel.TabIndex = 4;
            this.amountOfThisPartLabel.Text = "Amount of this part in device:";
            // 
            // materialCostLabel
            // 
            this.materialCostLabel.AutoSize = true;
            this.materialCostLabel.Location = new System.Drawing.Point(12, 42);
            this.materialCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialCostLabel.Name = "materialCostLabel";
            this.materialCostLabel.Size = new System.Drawing.Size(103, 15);
            this.materialCostLabel.TabIndex = 3;
            this.materialCostLabel.Text = "Material cost €/kg";
            // 
            // materialWeightLabel
            // 
            this.materialWeightLabel.AutoSize = true;
            this.materialWeightLabel.Location = new System.Drawing.Point(12, 14);
            this.materialWeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialWeightLabel.Name = "materialWeightLabel";
            this.materialWeightLabel.Size = new System.Drawing.Size(113, 15);
            this.materialWeightLabel.TabIndex = 2;
            this.materialWeightLabel.Text = "Material weight, kg:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(10, 8);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(72, 15);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.Location = new System.Drawing.Point(7, 25);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(582, 49);
            this.descriptionTextBox.TabIndex = 0;
            // 
            // stripsTabPage
            // 
            this.stripsTabPage.Controls.Add(this.markupForStripTextBox);
            this.stripsTabPage.Controls.Add(this.stripPurchaseCostTextBox);
            this.stripsTabPage.Controls.Add(this.stripWidthTextBox);
            this.stripsTabPage.Controls.Add(this.stripLengthTextBox);
            this.stripsTabPage.Controls.Add(this.stripMaterialCostTextBox);
            this.stripsTabPage.Controls.Add(this.markupForStripLabel);
            this.stripsTabPage.Controls.Add(this.stripPurchaseCostLabel);
            this.stripsTabPage.Controls.Add(this.stripWidthLabel);
            this.stripsTabPage.Controls.Add(this.stripLengthLabel);
            this.stripsTabPage.Controls.Add(this.stripMaterialCostLabel);
            this.stripsTabPage.Controls.Add(this.comboBox1);
            this.stripsTabPage.Controls.Add(this.stripTypeLabel);
            this.stripsTabPage.Location = new System.Drawing.Point(4, 22);
            this.stripsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.stripsTabPage.Name = "stripsTabPage";
            this.stripsTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.stripsTabPage.Size = new System.Drawing.Size(592, 369);
            this.stripsTabPage.TabIndex = 2;
            this.stripsTabPage.Text = "Strips";
            this.stripsTabPage.UseVisualStyleBackColor = true;
            // 
            // markupForStripTextBox
            // 
            this.markupForStripTextBox.Location = new System.Drawing.Point(284, 185);
            this.markupForStripTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.markupForStripTextBox.Name = "markupForStripTextBox";
            this.markupForStripTextBox.Size = new System.Drawing.Size(68, 20);
            this.markupForStripTextBox.TabIndex = 11;
            // 
            // stripPurchaseCostTextBox
            // 
            this.stripPurchaseCostTextBox.Location = new System.Drawing.Point(284, 152);
            this.stripPurchaseCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.stripPurchaseCostTextBox.Name = "stripPurchaseCostTextBox";
            this.stripPurchaseCostTextBox.Size = new System.Drawing.Size(68, 20);
            this.stripPurchaseCostTextBox.TabIndex = 10;
            // 
            // stripWidthTextBox
            // 
            this.stripWidthTextBox.Location = new System.Drawing.Point(284, 120);
            this.stripWidthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.stripWidthTextBox.Name = "stripWidthTextBox";
            this.stripWidthTextBox.Size = new System.Drawing.Size(68, 20);
            this.stripWidthTextBox.TabIndex = 9;
            // 
            // stripLengthTextBox
            // 
            this.stripLengthTextBox.Location = new System.Drawing.Point(284, 94);
            this.stripLengthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.stripLengthTextBox.Name = "stripLengthTextBox";
            this.stripLengthTextBox.Size = new System.Drawing.Size(68, 20);
            this.stripLengthTextBox.TabIndex = 8;
            // 
            // stripMaterialCostTextBox
            // 
            this.stripMaterialCostTextBox.Location = new System.Drawing.Point(284, 64);
            this.stripMaterialCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.stripMaterialCostTextBox.Name = "stripMaterialCostTextBox";
            this.stripMaterialCostTextBox.Size = new System.Drawing.Size(68, 20);
            this.stripMaterialCostTextBox.TabIndex = 7;
            // 
            // markupForStripLabel
            // 
            this.markupForStripLabel.AutoSize = true;
            this.markupForStripLabel.Location = new System.Drawing.Point(18, 187);
            this.markupForStripLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.markupForStripLabel.Name = "markupForStripLabel";
            this.markupForStripLabel.Size = new System.Drawing.Size(134, 15);
            this.markupForStripLabel.TabIndex = 6;
            this.markupForStripLabel.Text = "Markup for component:";
            // 
            // stripPurchaseCostLabel
            // 
            this.stripPurchaseCostLabel.AutoSize = true;
            this.stripPurchaseCostLabel.Location = new System.Drawing.Point(18, 154);
            this.stripPurchaseCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stripPurchaseCostLabel.Name = "stripPurchaseCostLabel";
            this.stripPurchaseCostLabel.Size = new System.Drawing.Size(100, 15);
            this.stripPurchaseCostLabel.TabIndex = 5;
            this.stripPurchaseCostLabel.Text = "Purchase cost, €:";
            // 
            // stripWidthLabel
            // 
            this.stripWidthLabel.AutoSize = true;
            this.stripWidthLabel.Location = new System.Drawing.Point(18, 124);
            this.stripWidthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stripWidthLabel.Name = "stripWidthLabel";
            this.stripWidthLabel.Size = new System.Drawing.Size(95, 15);
            this.stripWidthLabel.TabIndex = 4;
            this.stripWidthLabel.Text = "Strip width, mm:";
            // 
            // stripLengthLabel
            // 
            this.stripLengthLabel.AutoSize = true;
            this.stripLengthLabel.Location = new System.Drawing.Point(18, 96);
            this.stripLengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stripLengthLabel.Name = "stripLengthLabel";
            this.stripLengthLabel.Size = new System.Drawing.Size(100, 15);
            this.stripLengthLabel.TabIndex = 3;
            this.stripLengthLabel.Text = "Strip length, mm:";
            // 
            // stripMaterialCostLabel
            // 
            this.stripMaterialCostLabel.AutoSize = true;
            this.stripMaterialCostLabel.Location = new System.Drawing.Point(18, 66);
            this.stripMaterialCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stripMaterialCostLabel.Name = "stripMaterialCostLabel";
            this.stripMaterialCostLabel.Size = new System.Drawing.Size(142, 15);
            this.stripMaterialCostLabel.TabIndex = 2;
            this.stripMaterialCostLabel.Text = "Strip material cost, €/m2:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Select 1",
            "Select 2",
            "Select 3"});
            this.comboBox1.Location = new System.Drawing.Point(284, 26);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // stripTypeLabel
            // 
            this.stripTypeLabel.AutoSize = true;
            this.stripTypeLabel.Location = new System.Drawing.Point(18, 28);
            this.stripTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stripTypeLabel.Name = "stripTypeLabel";
            this.stripTypeLabel.Size = new System.Drawing.Size(95, 15);
            this.stripTypeLabel.TabIndex = 0;
            this.stripTypeLabel.Text = "Select strip type:";
            // 
            // purchasesTabPage
            // 
            this.purchasesTabPage.Controls.Add(this.markupCostPurchaseTextBox);
            this.purchasesTabPage.Controls.Add(this.purchaseCostTextBox);
            this.purchasesTabPage.Controls.Add(this.technicalParametersTextBox);
            this.purchasesTabPage.Controls.Add(this.vendorNoTextBox);
            this.purchasesTabPage.Controls.Add(this.supplierTextBox);
            this.purchasesTabPage.Controls.Add(this.markupCostPurchaseLabel);
            this.purchasesTabPage.Controls.Add(this.purchaseCostLabel);
            this.purchasesTabPage.Controls.Add(this.technicalParametersLabel);
            this.purchasesTabPage.Controls.Add(this.vendorNoLabel);
            this.purchasesTabPage.Controls.Add(this.supplierLabel);
            this.purchasesTabPage.Location = new System.Drawing.Point(4, 22);
            this.purchasesTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.purchasesTabPage.Name = "purchasesTabPage";
            this.purchasesTabPage.Size = new System.Drawing.Size(592, 369);
            this.purchasesTabPage.TabIndex = 3;
            this.purchasesTabPage.Text = "Purchases";
            this.purchasesTabPage.UseVisualStyleBackColor = true;
            // 
            // markupCostPurchaseTextBox
            // 
            this.markupCostPurchaseTextBox.Location = new System.Drawing.Point(195, 129);
            this.markupCostPurchaseTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.markupCostPurchaseTextBox.Name = "markupCostPurchaseTextBox";
            this.markupCostPurchaseTextBox.Size = new System.Drawing.Size(68, 20);
            this.markupCostPurchaseTextBox.TabIndex = 11;
            this.markupCostPurchaseTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // purchaseCostTextBox
            // 
            this.purchaseCostTextBox.Location = new System.Drawing.Point(195, 101);
            this.purchaseCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.purchaseCostTextBox.Name = "purchaseCostTextBox";
            this.purchaseCostTextBox.Size = new System.Drawing.Size(68, 20);
            this.purchaseCostTextBox.TabIndex = 10;
            this.purchaseCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // technicalParametersTextBox
            // 
            this.technicalParametersTextBox.Location = new System.Drawing.Point(195, 71);
            this.technicalParametersTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.technicalParametersTextBox.Name = "technicalParametersTextBox";
            this.technicalParametersTextBox.Size = new System.Drawing.Size(150, 20);
            this.technicalParametersTextBox.TabIndex = 9;
            // 
            // vendorNoTextBox
            // 
            this.vendorNoTextBox.Location = new System.Drawing.Point(195, 40);
            this.vendorNoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.vendorNoTextBox.Name = "vendorNoTextBox";
            this.vendorNoTextBox.Size = new System.Drawing.Size(150, 20);
            this.vendorNoTextBox.TabIndex = 8;
            // 
            // supplierTextBox
            // 
            this.supplierTextBox.Location = new System.Drawing.Point(195, 13);
            this.supplierTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.supplierTextBox.Name = "supplierTextBox";
            this.supplierTextBox.Size = new System.Drawing.Size(150, 20);
            this.supplierTextBox.TabIndex = 7;
            // 
            // markupCostPurchaseLabel
            // 
            this.markupCostPurchaseLabel.AutoSize = true;
            this.markupCostPurchaseLabel.Location = new System.Drawing.Point(18, 131);
            this.markupCostPurchaseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.markupCostPurchaseLabel.Name = "markupCostPurchaseLabel";
            this.markupCostPurchaseLabel.Size = new System.Drawing.Size(134, 15);
            this.markupCostPurchaseLabel.TabIndex = 5;
            this.markupCostPurchaseLabel.Text = "Markup for component:";
            // 
            // purchaseCostLabel
            // 
            this.purchaseCostLabel.AutoSize = true;
            this.purchaseCostLabel.Location = new System.Drawing.Point(18, 103);
            this.purchaseCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.purchaseCostLabel.Name = "purchaseCostLabel";
            this.purchaseCostLabel.Size = new System.Drawing.Size(166, 15);
            this.purchaseCostLabel.TabIndex = 4;
            this.purchaseCostLabel.Text = "Purchase cost, € without VAT:";
            // 
            // technicalParametersLabel
            // 
            this.technicalParametersLabel.AutoSize = true;
            this.technicalParametersLabel.Location = new System.Drawing.Point(18, 73);
            this.technicalParametersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.technicalParametersLabel.Name = "technicalParametersLabel";
            this.technicalParametersLabel.Size = new System.Drawing.Size(129, 15);
            this.technicalParametersLabel.TabIndex = 3;
            this.technicalParametersLabel.Text = "Technical parameters:";
            // 
            // vendorNoLabel
            // 
            this.vendorNoLabel.AutoSize = true;
            this.vendorNoLabel.Location = new System.Drawing.Point(18, 42);
            this.vendorNoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vendorNoLabel.Name = "vendorNoLabel";
            this.vendorNoLabel.Size = new System.Drawing.Size(95, 15);
            this.vendorNoLabel.TabIndex = 2;
            this.vendorNoLabel.Text = "Vendor number:";
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Location = new System.Drawing.Point(18, 15);
            this.supplierLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(56, 15);
            this.supplierLabel.TabIndex = 1;
            this.supplierLabel.Text = "Supplier:";
            // 
            // weldingTabPage
            // 
            this.weldingTabPage.Controls.Add(this.minutesLabel1);
            this.weldingTabPage.Controls.Add(this.hoursLabel1);
            this.weldingTabPage.Controls.Add(this.plannedWeldingDurationMinuteTextBox);
            this.weldingTabPage.Controls.Add(this.plannedWeldingDurationHourTextBox);
            this.weldingTabPage.Controls.Add(this.plannedWeldingDurationLabel);
            this.weldingTabPage.Location = new System.Drawing.Point(4, 22);
            this.weldingTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.weldingTabPage.Name = "weldingTabPage";
            this.weldingTabPage.Size = new System.Drawing.Size(592, 369);
            this.weldingTabPage.TabIndex = 5;
            this.weldingTabPage.Text = "Welding";
            this.weldingTabPage.UseVisualStyleBackColor = true;
            // 
            // minutesLabel1
            // 
            this.minutesLabel1.AutoSize = true;
            this.minutesLabel1.Location = new System.Drawing.Point(261, 12);
            this.minutesLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minutesLabel1.Name = "minutesLabel1";
            this.minutesLabel1.Size = new System.Drawing.Size(51, 15);
            this.minutesLabel1.TabIndex = 17;
            this.minutesLabel1.Text = "Minutes";
            // 
            // hoursLabel1
            // 
            this.hoursLabel1.AutoSize = true;
            this.hoursLabel1.Location = new System.Drawing.Point(173, 12);
            this.hoursLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hoursLabel1.Name = "hoursLabel1";
            this.hoursLabel1.Size = new System.Drawing.Size(40, 15);
            this.hoursLabel1.TabIndex = 16;
            this.hoursLabel1.Text = "Hours";
            // 
            // plannedWeldingDurationMinuteTextBox
            // 
            this.plannedWeldingDurationMinuteTextBox.Location = new System.Drawing.Point(248, 27);
            this.plannedWeldingDurationMinuteTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.plannedWeldingDurationMinuteTextBox.Name = "plannedWeldingDurationMinuteTextBox";
            this.plannedWeldingDurationMinuteTextBox.Size = new System.Drawing.Size(68, 20);
            this.plannedWeldingDurationMinuteTextBox.TabIndex = 6;
            this.plannedWeldingDurationMinuteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integersOnlyTextBox_KeyPress);
            // 
            // plannedWeldingDurationHourTextBox
            // 
            this.plannedWeldingDurationHourTextBox.Location = new System.Drawing.Point(157, 27);
            this.plannedWeldingDurationHourTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.plannedWeldingDurationHourTextBox.Name = "plannedWeldingDurationHourTextBox";
            this.plannedWeldingDurationHourTextBox.Size = new System.Drawing.Size(68, 20);
            this.plannedWeldingDurationHourTextBox.TabIndex = 4;
            this.plannedWeldingDurationHourTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integersOnlyTextBox_KeyPress);
            // 
            // plannedWeldingDurationLabel
            // 
            this.plannedWeldingDurationLabel.AutoSize = true;
            this.plannedWeldingDurationLabel.Location = new System.Drawing.Point(7, 30);
            this.plannedWeldingDurationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.plannedWeldingDurationLabel.Name = "plannedWeldingDurationLabel";
            this.plannedWeldingDurationLabel.Size = new System.Drawing.Size(143, 15);
            this.plannedWeldingDurationLabel.TabIndex = 0;
            this.plannedWeldingDurationLabel.Text = "Planned wlding duration:";
            // 
            // assemblyTabPage
            // 
            this.assemblyTabPage.Controls.Add(this.minutesLabel);
            this.assemblyTabPage.Controls.Add(this.hoursLabel);
            this.assemblyTabPage.Controls.Add(this.assemblyToParentNodeDurationMinuteTextBox);
            this.assemblyTabPage.Controls.Add(this.combinedAssemblyTimeMinuteTextBox);
            this.assemblyTabPage.Controls.Add(this.individualComponentAssemblyDurationMinuteTextBox);
            this.assemblyTabPage.Controls.Add(this.childNodeAssemblyDurationMinuteTextBox);
            this.assemblyTabPage.Controls.Add(this.assemblyToParentNodeDurationHourTextBox);
            this.assemblyTabPage.Controls.Add(this.combinedAssemblyTimeHourTextBox);
            this.assemblyTabPage.Controls.Add(this.individualComponentAssemblyDurationHourTextBox);
            this.assemblyTabPage.Controls.Add(this.childNodeAssemblyDurationHourTextBox);
            this.assemblyTabPage.Controls.Add(this.combinedAssemblyTimeLabel);
            this.assemblyTabPage.Controls.Add(this.assemblyToParentNodeDurationLabel);
            this.assemblyTabPage.Controls.Add(this.individualComponentAssemblyDurationLabel);
            this.assemblyTabPage.Controls.Add(this.childNodeAssemblyDurationLabel);
            this.assemblyTabPage.Location = new System.Drawing.Point(4, 22);
            this.assemblyTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.assemblyTabPage.Name = "assemblyTabPage";
            this.assemblyTabPage.Size = new System.Drawing.Size(592, 369);
            this.assemblyTabPage.TabIndex = 6;
            this.assemblyTabPage.Text = "Assembly";
            this.assemblyTabPage.UseVisualStyleBackColor = true;
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(385, 18);
            this.minutesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(51, 15);
            this.minutesLabel.TabIndex = 16;
            this.minutesLabel.Text = "Minutes";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(283, 18);
            this.hoursLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(40, 15);
            this.hoursLabel.TabIndex = 15;
            this.hoursLabel.Text = "Hours";
            // 
            // assemblyToParentNodeDurationMinuteTextBox
            // 
            this.assemblyToParentNodeDurationMinuteTextBox.Location = new System.Drawing.Point(372, 82);
            this.assemblyToParentNodeDurationMinuteTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.assemblyToParentNodeDurationMinuteTextBox.Name = "assemblyToParentNodeDurationMinuteTextBox";
            this.assemblyToParentNodeDurationMinuteTextBox.Size = new System.Drawing.Size(68, 20);
            this.assemblyToParentNodeDurationMinuteTextBox.TabIndex = 13;
            this.assemblyToParentNodeDurationMinuteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integersOnlyTextBox_KeyPress);
            // 
            // combinedAssemblyTimeMinuteTextBox
            // 
            this.combinedAssemblyTimeMinuteTextBox.Location = new System.Drawing.Point(372, 119);
            this.combinedAssemblyTimeMinuteTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.combinedAssemblyTimeMinuteTextBox.Name = "combinedAssemblyTimeMinuteTextBox";
            this.combinedAssemblyTimeMinuteTextBox.ReadOnly = true;
            this.combinedAssemblyTimeMinuteTextBox.Size = new System.Drawing.Size(68, 20);
            this.combinedAssemblyTimeMinuteTextBox.TabIndex = 12;
            this.combinedAssemblyTimeMinuteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integersOnlyTextBox_KeyPress);
            // 
            // individualComponentAssemblyDurationMinuteTextBox
            // 
            this.individualComponentAssemblyDurationMinuteTextBox.Location = new System.Drawing.Point(372, 61);
            this.individualComponentAssemblyDurationMinuteTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.individualComponentAssemblyDurationMinuteTextBox.Name = "individualComponentAssemblyDurationMinuteTextBox";
            this.individualComponentAssemblyDurationMinuteTextBox.Size = new System.Drawing.Size(68, 20);
            this.individualComponentAssemblyDurationMinuteTextBox.TabIndex = 11;
            this.individualComponentAssemblyDurationMinuteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integersOnlyTextBox_KeyPress);
            // 
            // childNodeAssemblyDurationMinuteTextBox
            // 
            this.childNodeAssemblyDurationMinuteTextBox.Location = new System.Drawing.Point(372, 40);
            this.childNodeAssemblyDurationMinuteTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.childNodeAssemblyDurationMinuteTextBox.Name = "childNodeAssemblyDurationMinuteTextBox";
            this.childNodeAssemblyDurationMinuteTextBox.ReadOnly = true;
            this.childNodeAssemblyDurationMinuteTextBox.Size = new System.Drawing.Size(68, 20);
            this.childNodeAssemblyDurationMinuteTextBox.TabIndex = 10;
            this.childNodeAssemblyDurationMinuteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integersOnlyTextBox_KeyPress);
            // 
            // assemblyToParentNodeDurationHourTextBox
            // 
            this.assemblyToParentNodeDurationHourTextBox.Location = new System.Drawing.Point(268, 82);
            this.assemblyToParentNodeDurationHourTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.assemblyToParentNodeDurationHourTextBox.Name = "assemblyToParentNodeDurationHourTextBox";
            this.assemblyToParentNodeDurationHourTextBox.Size = new System.Drawing.Size(68, 20);
            this.assemblyToParentNodeDurationHourTextBox.TabIndex = 8;
            this.assemblyToParentNodeDurationHourTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integersOnlyTextBox_KeyPress);
            // 
            // combinedAssemblyTimeHourTextBox
            // 
            this.combinedAssemblyTimeHourTextBox.Location = new System.Drawing.Point(268, 119);
            this.combinedAssemblyTimeHourTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.combinedAssemblyTimeHourTextBox.Name = "combinedAssemblyTimeHourTextBox";
            this.combinedAssemblyTimeHourTextBox.ReadOnly = true;
            this.combinedAssemblyTimeHourTextBox.Size = new System.Drawing.Size(68, 20);
            this.combinedAssemblyTimeHourTextBox.TabIndex = 7;
            this.combinedAssemblyTimeHourTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integersOnlyTextBox_KeyPress);
            // 
            // individualComponentAssemblyDurationHourTextBox
            // 
            this.individualComponentAssemblyDurationHourTextBox.Location = new System.Drawing.Point(268, 61);
            this.individualComponentAssemblyDurationHourTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.individualComponentAssemblyDurationHourTextBox.Name = "individualComponentAssemblyDurationHourTextBox";
            this.individualComponentAssemblyDurationHourTextBox.Size = new System.Drawing.Size(68, 20);
            this.individualComponentAssemblyDurationHourTextBox.TabIndex = 6;
            this.individualComponentAssemblyDurationHourTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // childNodeAssemblyDurationHourTextBox
            // 
            this.childNodeAssemblyDurationHourTextBox.Location = new System.Drawing.Point(268, 40);
            this.childNodeAssemblyDurationHourTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.childNodeAssemblyDurationHourTextBox.Name = "childNodeAssemblyDurationHourTextBox";
            this.childNodeAssemblyDurationHourTextBox.ReadOnly = true;
            this.childNodeAssemblyDurationHourTextBox.Size = new System.Drawing.Size(68, 20);
            this.childNodeAssemblyDurationHourTextBox.TabIndex = 5;
            this.childNodeAssemblyDurationHourTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integersOnlyTextBox_KeyPress);
            // 
            // combinedAssemblyTimeLabel
            // 
            this.combinedAssemblyTimeLabel.AutoSize = true;
            this.combinedAssemblyTimeLabel.Location = new System.Drawing.Point(18, 121);
            this.combinedAssemblyTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.combinedAssemblyTimeLabel.Name = "combinedAssemblyTimeLabel";
            this.combinedAssemblyTimeLabel.Size = new System.Drawing.Size(149, 15);
            this.combinedAssemblyTimeLabel.TabIndex = 3;
            this.combinedAssemblyTimeLabel.Text = "Combined assembly time:";
            // 
            // assemblyToParentNodeDurationLabel
            // 
            this.assemblyToParentNodeDurationLabel.AutoSize = true;
            this.assemblyToParentNodeDurationLabel.Location = new System.Drawing.Point(18, 84);
            this.assemblyToParentNodeDurationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.assemblyToParentNodeDurationLabel.Name = "assemblyToParentNodeDurationLabel";
            this.assemblyToParentNodeDurationLabel.Size = new System.Drawing.Size(192, 15);
            this.assemblyToParentNodeDurationLabel.TabIndex = 2;
            this.assemblyToParentNodeDurationLabel.Text = "Assembly to parent node duration:";
            // 
            // individualComponentAssemblyDurationLabel
            // 
            this.individualComponentAssemblyDurationLabel.AutoSize = true;
            this.individualComponentAssemblyDurationLabel.Location = new System.Drawing.Point(18, 63);
            this.individualComponentAssemblyDurationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.individualComponentAssemblyDurationLabel.Name = "individualComponentAssemblyDurationLabel";
            this.individualComponentAssemblyDurationLabel.Size = new System.Drawing.Size(230, 15);
            this.individualComponentAssemblyDurationLabel.TabIndex = 1;
            this.individualComponentAssemblyDurationLabel.Text = "Individual component assembly duration:";
            // 
            // childNodeAssemblyDurationLabel
            // 
            this.childNodeAssemblyDurationLabel.AutoSize = true;
            this.childNodeAssemblyDurationLabel.Location = new System.Drawing.Point(18, 42);
            this.childNodeAssemblyDurationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.childNodeAssemblyDurationLabel.Name = "childNodeAssemblyDurationLabel";
            this.childNodeAssemblyDurationLabel.Size = new System.Drawing.Size(172, 15);
            this.childNodeAssemblyDurationLabel.TabIndex = 0;
            this.childNodeAssemblyDurationLabel.Text = "Child node assembly duration:";
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
            this.otherCostsTabPage.Size = new System.Drawing.Size(592, 369);
            this.otherCostsTabPage.TabIndex = 8;
            this.otherCostsTabPage.Text = "Other costs";
            this.otherCostsTabPage.UseVisualStyleBackColor = true;
            // 
            // otherCostsTextBox
            // 
            this.otherCostsTextBox.Location = new System.Drawing.Point(182, 12);
            this.otherCostsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.otherCostsTextBox.Name = "otherCostsTextBox";
            this.otherCostsTextBox.Size = new System.Drawing.Size(68, 20);
            this.otherCostsTextBox.TabIndex = 5;
            this.otherCostsTextBox.Text = "0";
            this.otherCostsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // otherCostsDescriptionTextBox
            // 
            this.otherCostsDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.otherCostsDescriptionTextBox.Location = new System.Drawing.Point(16, 59);
            this.otherCostsDescriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.otherCostsDescriptionTextBox.Multiline = true;
            this.otherCostsDescriptionTextBox.Name = "otherCostsDescriptionTextBox";
            this.otherCostsDescriptionTextBox.Size = new System.Drawing.Size(565, 85);
            this.otherCostsDescriptionTextBox.TabIndex = 2;
            // 
            // otherCostsDescriptionLabel
            // 
            this.otherCostsDescriptionLabel.AutoSize = true;
            this.otherCostsDescriptionLabel.Location = new System.Drawing.Point(13, 44);
            this.otherCostsDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.otherCostsDescriptionLabel.Name = "otherCostsDescriptionLabel";
            this.otherCostsDescriptionLabel.Size = new System.Drawing.Size(131, 15);
            this.otherCostsDescriptionLabel.TabIndex = 1;
            this.otherCostsDescriptionLabel.Text = "Other costs description";
            // 
            // otherCostsLabel
            // 
            this.otherCostsLabel.AutoSize = true;
            this.otherCostsLabel.Location = new System.Drawing.Point(13, 14);
            this.otherCostsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.otherCostsLabel.Name = "otherCostsLabel";
            this.otherCostsLabel.Size = new System.Drawing.Size(150, 15);
            this.otherCostsLabel.TabIndex = 0;
            this.otherCostsLabel.Text = "Other costs, € without VAT:";
            // 
            // propertiesTabPage
            // 
            this.propertiesTabPage.Controls.Add(this.propertyGrid1);
            this.propertiesTabPage.Location = new System.Drawing.Point(4, 22);
            this.propertiesTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.propertiesTabPage.Name = "propertiesTabPage";
            this.propertiesTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.propertiesTabPage.Size = new System.Drawing.Size(592, 369);
            this.propertiesTabPage.TabIndex = 1;
            this.propertiesTabPage.Text = "Properties";
            this.propertiesTabPage.UseVisualStyleBackColor = true;
            // 
            // calculatedPriceLabel
            // 
            this.calculatedPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.calculatedPriceLabel.AutoSize = true;
            this.calculatedPriceLabel.Location = new System.Drawing.Point(5, 16);
            this.calculatedPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.calculatedPriceLabel.Name = "calculatedPriceLabel";
            this.calculatedPriceLabel.Size = new System.Drawing.Size(98, 15);
            this.calculatedPriceLabel.TabIndex = 9;
            this.calculatedPriceLabel.Text = "Calculated price:";
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.Location = new System.Drawing.Point(765, 3);
            this.nextButton.Margin = new System.Windows.Forms.Padding(2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(83, 26);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next >";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.previousButton.Location = new System.Drawing.Point(3, 3);
            this.previousButton.Margin = new System.Windows.Forms.Padding(2);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(83, 26);
            this.previousButton.TabIndex = 3;
            this.previousButton.Text = "< Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.previousButton);
            this.controlsPanel.Controls.Add(this.nextButton);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlsPanel.Location = new System.Drawing.Point(0, 488);
            this.controlsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(850, 31);
            this.controlsPanel.TabIndex = 10;
            // 
            // partDetailsPanel
            // 
            this.partDetailsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.partDetailsPanel.Controls.Add(this.savePartButton);
            this.partDetailsPanel.Controls.Add(this.calculatedPriceLabel);
            this.partDetailsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.partDetailsPanel.Location = new System.Drawing.Point(0, 441);
            this.partDetailsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.partDetailsPanel.Name = "partDetailsPanel";
            this.partDetailsPanel.Size = new System.Drawing.Size(850, 47);
            this.partDetailsPanel.TabIndex = 11;
            // 
            // savePartButton
            // 
            this.savePartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.savePartButton.Location = new System.Drawing.Point(695, 20);
            this.savePartButton.Margin = new System.Windows.Forms.Padding(2);
            this.savePartButton.Name = "savePartButton";
            this.savePartButton.Size = new System.Drawing.Size(152, 26);
            this.savePartButton.TabIndex = 4;
            this.savePartButton.Text = "Save part";
            this.savePartButton.UseVisualStyleBackColor = true;
            this.savePartButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // assemblyDetailsPanel
            // 
            this.assemblyDetailsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.assemblyDetailsPanel.Controls.Add(this.saveAssemblyButton);
            this.assemblyDetailsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.assemblyDetailsPanel.Location = new System.Drawing.Point(0, 395);
            this.assemblyDetailsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.assemblyDetailsPanel.Name = "assemblyDetailsPanel";
            this.assemblyDetailsPanel.Size = new System.Drawing.Size(850, 46);
            this.assemblyDetailsPanel.TabIndex = 12;
            // 
            // saveAssemblyButton
            // 
            this.saveAssemblyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveAssemblyButton.Location = new System.Drawing.Point(695, 18);
            this.saveAssemblyButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveAssemblyButton.Name = "saveAssemblyButton";
            this.saveAssemblyButton.Size = new System.Drawing.Size(152, 26);
            this.saveAssemblyButton.TabIndex = 10;
            this.saveAssemblyButton.Text = "Save assembly";
            this.saveAssemblyButton.UseVisualStyleBackColor = true;
            this.saveAssemblyButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.takePictureButton);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(850, 395);
            this.splitContainer1.SplitterDistance = 600;
            this.splitContainer1.TabIndex = 13;
            // 
            // takePictureButton
            // 
            this.takePictureButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.takePictureButton.Location = new System.Drawing.Point(0, 0);
            this.takePictureButton.Margin = new System.Windows.Forms.Padding(2);
            this.takePictureButton.Name = "takePictureButton";
            this.takePictureButton.Size = new System.Drawing.Size(246, 29);
            this.takePictureButton.TabIndex = 1;
            this.takePictureButton.Text = "Take picture";
            this.takePictureButton.UseVisualStyleBackColor = true;
            this.takePictureButton.Click += new System.EventHandler(this.takePictureButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 360);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // generalTabPage
            // 
            this.generalTabPage.Controls.Add(this.notesTextBox);
            this.generalTabPage.Controls.Add(this.notesLabel);
            this.generalTabPage.Controls.Add(this.descriptionTextBox);
            this.generalTabPage.Controls.Add(this.descriptionLabel);
            this.generalTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalTabPage.Size = new System.Drawing.Size(592, 369);
            this.generalTabPage.TabIndex = 9;
            this.generalTabPage.Text = "General";
            this.generalTabPage.UseVisualStyleBackColor = true;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesTextBox.Location = new System.Drawing.Point(7, 101);
            this.notesTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(582, 49);
            this.notesTextBox.TabIndex = 2;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(10, 84);
            this.notesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(42, 15);
            this.notesLabel.TabIndex = 3;
            this.notesLabel.Text = "Notes:";
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 519);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.assemblyDetailsPanel);
            this.Controls.Add(this.partDetailsPanel);
            this.Controls.Add(this.controlsPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DetailsForm";
            this.Text = "DetailsForm";
            this.Load += new System.EventHandler(this.DetailsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.manufacturingTabPage.ResumeLayout(false);
            this.manufacturingTabPage.PerformLayout();
            this.stripsTabPage.ResumeLayout(false);
            this.stripsTabPage.PerformLayout();
            this.purchasesTabPage.ResumeLayout(false);
            this.purchasesTabPage.PerformLayout();
            this.weldingTabPage.ResumeLayout(false);
            this.weldingTabPage.PerformLayout();
            this.assemblyTabPage.ResumeLayout(false);
            this.assemblyTabPage.PerformLayout();
            this.otherCostsTabPage.ResumeLayout(false);
            this.otherCostsTabPage.PerformLayout();
            this.propertiesTabPage.ResumeLayout(false);
            this.controlsPanel.ResumeLayout(false);
            this.partDetailsPanel.ResumeLayout(false);
            this.partDetailsPanel.PerformLayout();
            this.assemblyDetailsPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.generalTabPage.ResumeLayout(false);
            this.generalTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage manufacturingTabPage;
        private System.Windows.Forms.TabPage stripsTabPage;
        private System.Windows.Forms.TabPage purchasesTabPage;
        private System.Windows.Forms.TabPage propertiesTabPage;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Label descriptionLabel;
        private TextBox descriptionTextBox;
        private System.Windows.Forms.Label calculatedPriceLabel;
        private System.Windows.Forms.Label manufacturingCostLabel;
        private System.Windows.Forms.Label singlePieceManufacturingDurationLabel;
        private System.Windows.Forms.Label programmingCostLabel;
        private System.Windows.Forms.Label programmingDurationLabel;
        private System.Windows.Forms.Label amountOfThisPartLabel;
        private System.Windows.Forms.Label materialCostLabel;
        private System.Windows.Forms.Label materialWeightLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label stripTypeLabel;
        private System.Windows.Forms.Label markupForStripLabel;
        private System.Windows.Forms.Label stripPurchaseCostLabel;
        private System.Windows.Forms.Label stripWidthLabel;
        private System.Windows.Forms.Label stripLengthLabel;
        private System.Windows.Forms.Label stripMaterialCostLabel;
        private System.Windows.Forms.Label technicalParametersLabel;
        private System.Windows.Forms.Label vendorNoLabel;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.Label markupCostPurchaseLabel;
        private System.Windows.Forms.Label purchaseCostLabel;
        private System.Windows.Forms.TabPage weldingTabPage;
        private System.Windows.Forms.TabPage assemblyTabPage;
        private System.Windows.Forms.TabPage otherCostsTabPage;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Panel partDetailsPanel;
        private System.Windows.Forms.Panel assemblyDetailsPanel;
        private TextBox plannedWeldingDurationHourTextBox;
        private System.Windows.Forms.Label plannedWeldingDurationLabel;
        private System.Windows.Forms.Label otherCostsLabel;
        private TextBox programmingCostTextBox;
        private TextBox singlePieceManufacturingDurationTextBox;
        private TextBox manufacturingCostTextBox;
        private TextBox programmingDurationTextBox;
        private TextBox amountOfThisPartTextBox;
        private TextBox materialCostTextBox;
        private TextBox materialWeightTextBox;
        private TextBox markupForStripTextBox;
        private TextBox stripPurchaseCostTextBox;
        private TextBox stripWidthTextBox;
        private TextBox stripLengthTextBox;
        private TextBox stripMaterialCostTextBox;
        private TextBox markupCostPurchaseTextBox;
        private TextBox purchaseCostTextBox;
        private TextBox technicalParametersTextBox;
        private TextBox vendorNoTextBox;
        private TextBox supplierTextBox;
        private TextBox otherCostsTextBox;
        private TextBox otherCostsDescriptionTextBox;
        private System.Windows.Forms.Label otherCostsDescriptionLabel;
        private System.Windows.Forms.Label combinedAssemblyTimeLabel;
        private System.Windows.Forms.Label assemblyToParentNodeDurationLabel;
        private System.Windows.Forms.Label individualComponentAssemblyDurationLabel;
        private System.Windows.Forms.Label childNodeAssemblyDurationLabel;
        private TextBox assemblyToParentNodeDurationHourTextBox;
        private TextBox combinedAssemblyTimeHourTextBox;
        private TextBox individualComponentAssemblyDurationHourTextBox;
        private TextBox childNodeAssemblyDurationHourTextBox;
        private TextBox assemblyToParentNodeDurationMinuteTextBox;
        private TextBox combinedAssemblyTimeMinuteTextBox;
        private TextBox individualComponentAssemblyDurationMinuteTextBox;
        private TextBox childNodeAssemblyDurationMinuteTextBox;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label hoursLabel;
        private Button savePartButton;
        private Button saveAssemblyButton;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private TextBox plannedWeldingDurationMinuteTextBox;
        private Label minutesLabel1;
        private Label hoursLabel1;
        private Button takePictureButton;
        private TabPage generalTabPage;
        private TextBox notesTextBox;
        private Label notesLabel;
    }
}