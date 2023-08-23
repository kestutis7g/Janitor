using System.Windows.Forms;

namespace Janitor_V1
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeListView1 = new BrightIdeasSoftware.TreeListView();
            this.seachTextBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.finalPriceLabel = new System.Windows.Forms.Label();
            this.totalAssemblyCostGeneralLabel = new System.Windows.Forms.Label();
            this.totalPartsTabCostGeneralLabel = new System.Windows.Forms.Label();
            this.tabPageParts = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.totalPartsTabCostLabel = new System.Windows.Forms.Label();
            this.toolboxTotalPriceLabel = new System.Windows.Forms.Label();
            this.toolboxPriceLabel = new System.Windows.Forms.Label();
            this.toolboxWeightTextBox = new System.Windows.Forms.TextBox();
            this.toolboxWeightLabel = new System.Windows.Forms.Label();
            this.toolboxTypeLabel = new System.Windows.Forms.Label();
            this.useStainlessSteel = new System.Windows.Forms.RadioButton();
            this.useBlackSteel = new System.Windows.Forms.RadioButton();
            this.totalPartsCostLabel = new System.Windows.Forms.Label();
            this.totalPartsLabel = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeListView2 = new BrightIdeasSoftware.TreeListView();
            this.seachTextBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPageAssemblies = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.totalAssemblyCostLabel = new System.Windows.Forms.Label();
            this.assemblyCostLabel = new System.Windows.Forms.Label();
            this.combinedAssemblyDurationLabel = new System.Windows.Forms.Label();
            this.assemblyToParentTextBox = new System.Windows.Forms.TextBox();
            this.assemblyToParentLabel = new System.Windows.Forms.Label();
            this.individualComponentsAssemblyTextBox = new System.Windows.Forms.TextBox();
            this.individualComponentsAssemblyLabel = new System.Windows.Forms.Label();
            this.rootChildNodeAssemblyTime = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.seachTextBox3 = new System.Windows.Forms.TextBox();
            this.treeListView3 = new BrightIdeasSoftware.TreeListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.panel7 = new System.Windows.Forms.Panel();
            this.deviceButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pricesButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabPageParts.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPageAssemblies.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageGeneral);
            this.tabControl1.Controls.Add(this.tabPageParts);
            this.tabControl1.Controls.Add(this.tabPageAssemblies);
            this.tabControl1.Location = new System.Drawing.Point(1, 33);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(889, 569);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.splitContainer1);
            this.tabPageGeneral.Controls.Add(this.panel4);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPageGeneral.Size = new System.Drawing.Size(881, 543);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.treeListView1);
            this.splitContainer1.Panel1.Controls.Add(this.seachTextBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(879, 475);
            this.splitContainer1.SplitterDistance = 647;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 5;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer_SplitterMoved);
            // 
            // treeListView1
            // 
            this.treeListView1.AllowColumnReorder = true;
            this.treeListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeListView1.CellEditUseWholeCell = false;
            this.treeListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeListView1.HideSelection = false;
            this.treeListView1.Location = new System.Drawing.Point(2, 23);
            this.treeListView1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.treeListView1.Name = "treeListView1";
            this.treeListView1.SelectColumnsMenuStaysOpen = false;
            this.treeListView1.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.treeListView1.ShowCommandMenuOnRightClick = true;
            this.treeListView1.ShowGroups = false;
            this.treeListView1.ShowImagesOnSubItems = true;
            this.treeListView1.ShowItemToolTips = true;
            this.treeListView1.Size = new System.Drawing.Size(643, 451);
            this.treeListView1.TabIndex = 3;
            this.treeListView1.UseCompatibleStateImageBehavior = false;
            this.treeListView1.UseFilterIndicator = true;
            this.treeListView1.UseFiltering = true;
            this.treeListView1.UseHotItem = true;
            this.treeListView1.View = System.Windows.Forms.View.Details;
            this.treeListView1.VirtualMode = true;
            this.treeListView1.ItemActivate += new System.EventHandler(this.treeListView_ItemActivate);
            this.treeListView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.treeListView_ItemSelectionChanged);
            // 
            // seachTextBox1
            // 
            this.seachTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.seachTextBox1.Location = new System.Drawing.Point(0, 0);
            this.seachTextBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.seachTextBox1.Name = "seachTextBox1";
            this.seachTextBox1.Size = new System.Drawing.Size(647, 20);
            this.seachTextBox1.TabIndex = 4;
            this.seachTextBox1.TextChanged += new System.EventHandler(this.seachTextBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 513);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 120);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 25);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 27);
            this.button2.TabIndex = 0;
            this.button2.Text = "Open item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.openItemButton_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Do stuff";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.finalPriceLabel);
            this.panel4.Controls.Add(this.totalAssemblyCostGeneralLabel);
            this.panel4.Controls.Add(this.totalPartsTabCostGeneralLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(2, 477);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(877, 65);
            this.panel4.TabIndex = 2;
            // 
            // finalPriceLabel
            // 
            this.finalPriceLabel.AutoSize = true;
            this.finalPriceLabel.Location = new System.Drawing.Point(247, 12);
            this.finalPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.finalPriceLabel.Name = "finalPriceLabel";
            this.finalPriceLabel.Size = new System.Drawing.Size(76, 13);
            this.finalPriceLabel.TabIndex = 12;
            this.finalPriceLabel.Text = "Final price: 0 €";
            // 
            // totalAssemblyCostGeneralLabel
            // 
            this.totalAssemblyCostGeneralLabel.AutoSize = true;
            this.totalAssemblyCostGeneralLabel.Location = new System.Drawing.Point(10, 38);
            this.totalAssemblyCostGeneralLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalAssemblyCostGeneralLabel.Name = "totalAssemblyCostGeneralLabel";
            this.totalAssemblyCostGeneralLabel.Size = new System.Drawing.Size(121, 13);
            this.totalAssemblyCostGeneralLabel.TabIndex = 11;
            this.totalAssemblyCostGeneralLabel.Text = "Total assembly cost: 0 €";
            // 
            // totalPartsTabCostGeneralLabel
            // 
            this.totalPartsTabCostGeneralLabel.AutoSize = true;
            this.totalPartsTabCostGeneralLabel.Location = new System.Drawing.Point(10, 12);
            this.totalPartsTabCostGeneralLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalPartsTabCostGeneralLabel.Name = "totalPartsTabCostGeneralLabel";
            this.totalPartsTabCostGeneralLabel.Size = new System.Drawing.Size(159, 13);
            this.totalPartsTabCostGeneralLabel.TabIndex = 10;
            this.totalPartsTabCostGeneralLabel.Text = "Total parts and toolbox cost: 0 €";
            // 
            // tabPageParts
            // 
            this.tabPageParts.Controls.Add(this.panel5);
            this.tabPageParts.Controls.Add(this.splitContainer2);
            this.tabPageParts.Location = new System.Drawing.Point(4, 22);
            this.tabPageParts.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPageParts.Name = "tabPageParts";
            this.tabPageParts.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPageParts.Size = new System.Drawing.Size(881, 543);
            this.tabPageParts.TabIndex = 2;
            this.tabPageParts.Text = "Parts";
            this.tabPageParts.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.totalPartsTabCostLabel);
            this.panel5.Controls.Add(this.toolboxTotalPriceLabel);
            this.panel5.Controls.Add(this.toolboxPriceLabel);
            this.panel5.Controls.Add(this.toolboxWeightTextBox);
            this.panel5.Controls.Add(this.toolboxWeightLabel);
            this.panel5.Controls.Add(this.toolboxTypeLabel);
            this.panel5.Controls.Add(this.useStainlessSteel);
            this.panel5.Controls.Add(this.useBlackSteel);
            this.panel5.Controls.Add(this.totalPartsCostLabel);
            this.panel5.Controls.Add(this.totalPartsLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(2, 477);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(877, 65);
            this.panel5.TabIndex = 7;
            // 
            // totalPartsTabCostLabel
            // 
            this.totalPartsTabCostLabel.AutoSize = true;
            this.totalPartsTabCostLabel.Location = new System.Drawing.Point(542, 27);
            this.totalPartsTabCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalPartsTabCostLabel.Name = "totalPartsTabCostLabel";
            this.totalPartsTabCostLabel.Size = new System.Drawing.Size(159, 13);
            this.totalPartsTabCostLabel.TabIndex = 9;
            this.totalPartsTabCostLabel.Text = "Total parts and toolbox cost: 0 €";
            // 
            // toolboxTotalPriceLabel
            // 
            this.toolboxTotalPriceLabel.AutoSize = true;
            this.toolboxTotalPriceLabel.Location = new System.Drawing.Point(346, 47);
            this.toolboxTotalPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toolboxTotalPriceLabel.Name = "toolboxTotalPriceLabel";
            this.toolboxTotalPriceLabel.Size = new System.Drawing.Size(92, 13);
            this.toolboxTotalPriceLabel.TabIndex = 8;
            this.toolboxTotalPriceLabel.Text = "Toolbox price: 0 €";
            // 
            // toolboxPriceLabel
            // 
            this.toolboxPriceLabel.AutoSize = true;
            this.toolboxPriceLabel.Location = new System.Drawing.Point(346, 29);
            this.toolboxPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toolboxPriceLabel.Name = "toolboxPriceLabel";
            this.toolboxPriceLabel.Size = new System.Drawing.Size(109, 13);
            this.toolboxPriceLabel.TabIndex = 7;
            this.toolboxPriceLabel.Text = "Toolbox price: 0 €/kg";
            // 
            // toolboxWeightTextBox
            // 
            this.toolboxWeightTextBox.Location = new System.Drawing.Point(426, 6);
            this.toolboxWeightTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.toolboxWeightTextBox.Name = "toolboxWeightTextBox";
            this.toolboxWeightTextBox.Size = new System.Drawing.Size(68, 20);
            this.toolboxWeightTextBox.TabIndex = 6;
            this.toolboxWeightTextBox.Text = "0";
            this.toolboxWeightTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.toolboxWeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // toolboxWeightLabel
            // 
            this.toolboxWeightLabel.AutoSize = true;
            this.toolboxWeightLabel.Location = new System.Drawing.Point(346, 8);
            this.toolboxWeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toolboxWeightLabel.Name = "toolboxWeightLabel";
            this.toolboxWeightLabel.Size = new System.Drawing.Size(79, 13);
            this.toolboxWeightLabel.TabIndex = 5;
            this.toolboxWeightLabel.Text = "Toolbox weight";
            // 
            // toolboxTypeLabel
            // 
            this.toolboxTypeLabel.AutoSize = true;
            this.toolboxTypeLabel.Location = new System.Drawing.Point(201, 8);
            this.toolboxTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toolboxTypeLabel.Name = "toolboxTypeLabel";
            this.toolboxTypeLabel.Size = new System.Drawing.Size(71, 13);
            this.toolboxTypeLabel.TabIndex = 4;
            this.toolboxTypeLabel.Text = "Toolbox type:";
            // 
            // useStainlessSteel
            // 
            this.useStainlessSteel.AutoSize = true;
            this.useStainlessSteel.Location = new System.Drawing.Point(204, 46);
            this.useStainlessSteel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.useStainlessSteel.Name = "useStainlessSteel";
            this.useStainlessSteel.Size = new System.Drawing.Size(92, 17);
            this.useStainlessSteel.TabIndex = 3;
            this.useStainlessSteel.Text = "Stainless steel";
            this.useStainlessSteel.UseVisualStyleBackColor = true;
            this.useStainlessSteel.CheckedChanged += new System.EventHandler(this.useSteel_CheckedChanged);
            // 
            // useBlackSteel
            // 
            this.useBlackSteel.AutoSize = true;
            this.useBlackSteel.Checked = true;
            this.useBlackSteel.Location = new System.Drawing.Point(204, 26);
            this.useBlackSteel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.useBlackSteel.Name = "useBlackSteel";
            this.useBlackSteel.Size = new System.Drawing.Size(77, 17);
            this.useBlackSteel.TabIndex = 2;
            this.useBlackSteel.TabStop = true;
            this.useBlackSteel.Text = "Black steel";
            this.useBlackSteel.UseVisualStyleBackColor = true;
            this.useBlackSteel.CheckedChanged += new System.EventHandler(this.useSteel_CheckedChanged);
            // 
            // totalPartsCostLabel
            // 
            this.totalPartsCostLabel.AutoSize = true;
            this.totalPartsCostLabel.Location = new System.Drawing.Point(10, 32);
            this.totalPartsCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalPartsCostLabel.Name = "totalPartsCostLabel";
            this.totalPartsCostLabel.Size = new System.Drawing.Size(101, 13);
            this.totalPartsCostLabel.TabIndex = 1;
            this.totalPartsCostLabel.Text = "Total parts cost: 0 €";
            // 
            // totalPartsLabel
            // 
            this.totalPartsLabel.AutoSize = true;
            this.totalPartsLabel.Location = new System.Drawing.Point(10, 8);
            this.totalPartsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalPartsLabel.Name = "totalPartsLabel";
            this.totalPartsLabel.Size = new System.Drawing.Size(69, 13);
            this.totalPartsLabel.TabIndex = 0;
            this.totalPartsLabel.Text = "Total parts: 0";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeListView2);
            this.splitContainer2.Panel1.Controls.Add(this.seachTextBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer2.Panel2.Controls.Add(this.panel2);
            this.splitContainer2.Size = new System.Drawing.Size(879, 475);
            this.splitContainer2.SplitterDistance = 636;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 6;
            // 
            // treeListView2
            // 
            this.treeListView2.AllowColumnReorder = true;
            this.treeListView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeListView2.CellEditUseWholeCell = false;
            this.treeListView2.HideSelection = false;
            this.treeListView2.Location = new System.Drawing.Point(2, 22);
            this.treeListView2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.treeListView2.Name = "treeListView2";
            this.treeListView2.SelectColumnsMenuStaysOpen = false;
            this.treeListView2.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.treeListView2.ShowCommandMenuOnRightClick = true;
            this.treeListView2.ShowGroups = false;
            this.treeListView2.ShowImagesOnSubItems = true;
            this.treeListView2.ShowItemToolTips = true;
            this.treeListView2.Size = new System.Drawing.Size(634, 452);
            this.treeListView2.TabIndex = 4;
            this.treeListView2.UseCompatibleStateImageBehavior = false;
            this.treeListView2.UseFilterIndicator = true;
            this.treeListView2.UseFiltering = true;
            this.treeListView2.UseHotItem = true;
            this.treeListView2.View = System.Windows.Forms.View.Details;
            this.treeListView2.VirtualMode = true;
            this.treeListView2.ItemActivate += new System.EventHandler(this.treeListView_ItemActivate);
            this.treeListView2.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.treeListView_ItemSelectionChanged);
            // 
            // seachTextBox2
            // 
            this.seachTextBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.seachTextBox2.Location = new System.Drawing.Point(0, 0);
            this.seachTextBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.seachTextBox2.Name = "seachTextBox2";
            this.seachTextBox2.Size = new System.Drawing.Size(636, 20);
            this.seachTextBox2.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 541);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(223, 120);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 25);
            this.button3.TabIndex = 0;
            this.button3.Text = "Open item";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.openItemButton_Click);
            // 
            // tabPageAssemblies
            // 
            this.tabPageAssemblies.Controls.Add(this.panel6);
            this.tabPageAssemblies.Controls.Add(this.splitContainer3);
            this.tabPageAssemblies.Location = new System.Drawing.Point(4, 22);
            this.tabPageAssemblies.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPageAssemblies.Name = "tabPageAssemblies";
            this.tabPageAssemblies.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPageAssemblies.Size = new System.Drawing.Size(881, 543);
            this.tabPageAssemblies.TabIndex = 3;
            this.tabPageAssemblies.Text = "Assemblies";
            this.tabPageAssemblies.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.totalAssemblyCostLabel);
            this.panel6.Controls.Add(this.assemblyCostLabel);
            this.panel6.Controls.Add(this.combinedAssemblyDurationLabel);
            this.panel6.Controls.Add(this.assemblyToParentTextBox);
            this.panel6.Controls.Add(this.assemblyToParentLabel);
            this.panel6.Controls.Add(this.individualComponentsAssemblyTextBox);
            this.panel6.Controls.Add(this.individualComponentsAssemblyLabel);
            this.panel6.Controls.Add(this.rootChildNodeAssemblyTime);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(2, 476);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(877, 66);
            this.panel6.TabIndex = 1;
            // 
            // totalAssemblyCostLabel
            // 
            this.totalAssemblyCostLabel.AutoSize = true;
            this.totalAssemblyCostLabel.Location = new System.Drawing.Point(330, 51);
            this.totalAssemblyCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalAssemblyCostLabel.Name = "totalAssemblyCostLabel";
            this.totalAssemblyCostLabel.Size = new System.Drawing.Size(121, 13);
            this.totalAssemblyCostLabel.TabIndex = 8;
            this.totalAssemblyCostLabel.Text = "Total assembly cost: 0 €";
            // 
            // assemblyCostLabel
            // 
            this.assemblyCostLabel.AutoSize = true;
            this.assemblyCostLabel.Location = new System.Drawing.Point(330, 29);
            this.assemblyCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.assemblyCostLabel.Name = "assemblyCostLabel";
            this.assemblyCostLabel.Size = new System.Drawing.Size(106, 13);
            this.assemblyCostLabel.TabIndex = 7;
            this.assemblyCostLabel.Text = "Assembly cost: 0 €/h";
            // 
            // combinedAssemblyDurationLabel
            // 
            this.combinedAssemblyDurationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.combinedAssemblyDurationLabel.AutoSize = true;
            this.combinedAssemblyDurationLabel.Location = new System.Drawing.Point(330, 7);
            this.combinedAssemblyDurationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.combinedAssemblyDurationLabel.Name = "combinedAssemblyDurationLabel";
            this.combinedAssemblyDurationLabel.Size = new System.Drawing.Size(144, 13);
            this.combinedAssemblyDurationLabel.TabIndex = 6;
            this.combinedAssemblyDurationLabel.Text = "Combined assembly duration:";
            // 
            // assemblyToParentTextBox
            // 
            this.assemblyToParentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.assemblyToParentTextBox.Location = new System.Drawing.Point(221, 47);
            this.assemblyToParentTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.assemblyToParentTextBox.Name = "assemblyToParentTextBox";
            this.assemblyToParentTextBox.Size = new System.Drawing.Size(68, 20);
            this.assemblyToParentTextBox.TabIndex = 5;
            this.assemblyToParentTextBox.Text = "0";
            this.assemblyToParentTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.assemblyToParentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // assemblyToParentLabel
            // 
            this.assemblyToParentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.assemblyToParentLabel.AutoSize = true;
            this.assemblyToParentLabel.Location = new System.Drawing.Point(9, 51);
            this.assemblyToParentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.assemblyToParentLabel.Name = "assemblyToParentLabel";
            this.assemblyToParentLabel.Size = new System.Drawing.Size(137, 13);
            this.assemblyToParentLabel.TabIndex = 4;
            this.assemblyToParentLabel.Text = "Assembly to parent duration";
            // 
            // individualComponentsAssemblyTextBox
            // 
            this.individualComponentsAssemblyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.individualComponentsAssemblyTextBox.Location = new System.Drawing.Point(221, 27);
            this.individualComponentsAssemblyTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.individualComponentsAssemblyTextBox.Name = "individualComponentsAssemblyTextBox";
            this.individualComponentsAssemblyTextBox.Size = new System.Drawing.Size(68, 20);
            this.individualComponentsAssemblyTextBox.TabIndex = 3;
            this.individualComponentsAssemblyTextBox.Text = "0";
            this.individualComponentsAssemblyTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.individualComponentsAssemblyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyTextBox_KeyPress);
            // 
            // individualComponentsAssemblyLabel
            // 
            this.individualComponentsAssemblyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.individualComponentsAssemblyLabel.AutoSize = true;
            this.individualComponentsAssemblyLabel.Location = new System.Drawing.Point(9, 29);
            this.individualComponentsAssemblyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.individualComponentsAssemblyLabel.Name = "individualComponentsAssemblyLabel";
            this.individualComponentsAssemblyLabel.Size = new System.Drawing.Size(200, 13);
            this.individualComponentsAssemblyLabel.TabIndex = 2;
            this.individualComponentsAssemblyLabel.Text = "Individual components assembly duration";
            // 
            // rootChildNodeAssemblyTime
            // 
            this.rootChildNodeAssemblyTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rootChildNodeAssemblyTime.AutoSize = true;
            this.rootChildNodeAssemblyTime.Location = new System.Drawing.Point(9, 7);
            this.rootChildNodeAssemblyTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rootChildNodeAssemblyTime.Name = "rootChildNodeAssemblyTime";
            this.rootChildNodeAssemblyTime.Size = new System.Drawing.Size(131, 13);
            this.rootChildNodeAssemblyTime.TabIndex = 1;
            this.rootChildNodeAssemblyTime.Text = "Child node assembly time: ";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.seachTextBox3);
            this.splitContainer3.Panel1.Controls.Add(this.treeListView3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.AutoScroll = true;
            this.splitContainer3.Panel2.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer3.Panel2.Controls.Add(this.panel3);
            this.splitContainer3.Size = new System.Drawing.Size(879, 474);
            this.splitContainer3.SplitterDistance = 713;
            this.splitContainer3.SplitterWidth = 3;
            this.splitContainer3.TabIndex = 0;
            // 
            // seachTextBox3
            // 
            this.seachTextBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.seachTextBox3.Location = new System.Drawing.Point(0, 0);
            this.seachTextBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.seachTextBox3.Name = "seachTextBox3";
            this.seachTextBox3.Size = new System.Drawing.Size(713, 20);
            this.seachTextBox3.TabIndex = 6;
            this.seachTextBox3.TextChanged += new System.EventHandler(this.seachTextBox3_TextChanged);
            // 
            // treeListView3
            // 
            this.treeListView3.AllowColumnReorder = true;
            this.treeListView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeListView3.CellEditUseWholeCell = false;
            this.treeListView3.HideSelection = false;
            this.treeListView3.Location = new System.Drawing.Point(2, 22);
            this.treeListView3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.treeListView3.Name = "treeListView3";
            this.treeListView3.SelectColumnsMenuStaysOpen = false;
            this.treeListView3.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.treeListView3.ShowCommandMenuOnRightClick = true;
            this.treeListView3.ShowGroups = false;
            this.treeListView3.ShowImagesOnSubItems = true;
            this.treeListView3.ShowItemToolTips = true;
            this.treeListView3.Size = new System.Drawing.Size(709, 450);
            this.treeListView3.TabIndex = 5;
            this.treeListView3.UseCompatibleStateImageBehavior = false;
            this.treeListView3.UseFilterIndicator = true;
            this.treeListView3.UseFiltering = true;
            this.treeListView3.UseHotItem = true;
            this.treeListView3.View = System.Windows.Forms.View.Details;
            this.treeListView3.VirtualMode = true;
            this.treeListView3.ItemActivate += new System.EventHandler(this.treeListView_ItemActivate);
            this.treeListView3.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.treeListView_ItemSelectionChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(146, 634);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Location = new System.Drawing.Point(0, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(146, 120);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 26);
            this.button4.TabIndex = 0;
            this.button4.Text = "Open item";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.openItemButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Open
            // 
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(103, 22);
            this.Open.Text = "Open";
            this.Open.Click += new System.EventHandler(this.contextMenuToolStripMenuItem_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.deviceButton);
            this.panel7.Controls.Add(this.button5);
            this.panel7.Controls.Add(this.pricesButton);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(891, 29);
            this.panel7.TabIndex = 1;
            // 
            // deviceButton
            // 
            this.deviceButton.Location = new System.Drawing.Point(61, 1);
            this.deviceButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.deviceButton.Name = "deviceButton";
            this.deviceButton.Size = new System.Drawing.Size(55, 25);
            this.deviceButton.TabIndex = 2;
            this.deviceButton.Text = "Device";
            this.deviceButton.UseVisualStyleBackColor = true;
            this.deviceButton.Click += new System.EventHandler(this.deviceButton_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Location = new System.Drawing.Point(119, 3);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 23);
            this.button5.TabIndex = 1;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // pricesButton
            // 
            this.pricesButton.Location = new System.Drawing.Point(2, 1);
            this.pricesButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pricesButton.Name = "pricesButton";
            this.pricesButton.Size = new System.Drawing.Size(55, 25);
            this.pricesButton.TabIndex = 0;
            this.pricesButton.Text = "Prices";
            this.pricesButton.UseVisualStyleBackColor = true;
            this.pricesButton.Click += new System.EventHandler(this.pricesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 603);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MinimumSize = new System.Drawing.Size(672, 337);
            this.Name = "MainForm";
            this.Text = "Janitor";
            this.tabControl1.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPageParts.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListView2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPageAssemblies.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListView3)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPageParts;
        private BrightIdeasSoftware.TreeListView treeListView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private BrightIdeasSoftware.TreeListView treeListView2;
        private TextBox seachTextBox1;
        private TextBox seachTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label rootChildNodeAssemblyTime;
        private System.Windows.Forms.TabPage tabPageAssemblies;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private BrightIdeasSoftware.TreeListView treeListView3;
        private TextBox seachTextBox3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button pricesButton;
        private TextBox assemblyToParentTextBox;
        private System.Windows.Forms.Label assemblyToParentLabel;
        private TextBox individualComponentsAssemblyTextBox;
        private System.Windows.Forms.Label individualComponentsAssemblyLabel;
        private System.Windows.Forms.Label combinedAssemblyDurationLabel;
        private System.Windows.Forms.Label assemblyCostLabel;
        private System.Windows.Forms.Label totalAssemblyCostLabel;
        private System.Windows.Forms.Label totalPartsLabel;
        private System.Windows.Forms.Label totalPartsCostLabel;
        private System.Windows.Forms.RadioButton useStainlessSteel;
        private System.Windows.Forms.RadioButton useBlackSteel;
        private System.Windows.Forms.Label toolboxPriceLabel;
        private TextBox toolboxWeightTextBox;
        private System.Windows.Forms.Label toolboxWeightLabel;
        private System.Windows.Forms.Label toolboxTypeLabel;
        private System.Windows.Forms.Label toolboxTotalPriceLabel;
        private System.Windows.Forms.Label totalPartsTabCostLabel;
        private System.Windows.Forms.Label totalPartsTabCostGeneralLabel;
        private System.Windows.Forms.Label totalAssemblyCostGeneralLabel;
        private System.Windows.Forms.Label finalPriceLabel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button deviceButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}

