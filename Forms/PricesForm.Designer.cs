namespace Janitor_V1
{
    partial class PricesForm
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
            this.workDataGridView = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.workPriceTabPage = new System.Windows.Forms.TabPage();
            this.materialPriceTabPage = new System.Windows.Forms.TabPage();
            this.materialDataGridView = new System.Windows.Forms.DataGridView();
            this.processingTabPage = new System.Windows.Forms.TabPage();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.processingLabel = new System.Windows.Forms.Label();
            this.processingDataGridView = new System.Windows.Forms.DataGridView();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.processingComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.workDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.workPriceTabPage.SuspendLayout();
            this.materialPriceTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataGridView)).BeginInit();
            this.processingTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // workDataGridView
            // 
            this.workDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workDataGridView.Location = new System.Drawing.Point(3, 2);
            this.workDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.workDataGridView.Name = "workDataGridView";
            this.workDataGridView.RowHeadersWidth = 62;
            this.workDataGridView.RowTemplate.Height = 28;
            this.workDataGridView.Size = new System.Drawing.Size(587, 400);
            this.workDataGridView.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(375, 438);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(103, 33);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(488, 438);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(103, 33);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.workPriceTabPage);
            this.tabControl1.Controls.Add(this.materialPriceTabPage);
            this.tabControl1.Controls.Add(this.processingTabPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(601, 433);
            this.tabControl1.TabIndex = 3;
            // 
            // workPriceTabPage
            // 
            this.workPriceTabPage.Controls.Add(this.workDataGridView);
            this.workPriceTabPage.Location = new System.Drawing.Point(4, 25);
            this.workPriceTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.workPriceTabPage.Name = "workPriceTabPage";
            this.workPriceTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.workPriceTabPage.Size = new System.Drawing.Size(593, 404);
            this.workPriceTabPage.TabIndex = 0;
            this.workPriceTabPage.Text = "Work";
            this.workPriceTabPage.UseVisualStyleBackColor = true;
            // 
            // materialPriceTabPage
            // 
            this.materialPriceTabPage.Controls.Add(this.materialDataGridView);
            this.materialPriceTabPage.Location = new System.Drawing.Point(4, 25);
            this.materialPriceTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialPriceTabPage.Name = "materialPriceTabPage";
            this.materialPriceTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialPriceTabPage.Size = new System.Drawing.Size(593, 404);
            this.materialPriceTabPage.TabIndex = 1;
            this.materialPriceTabPage.Text = "Material";
            this.materialPriceTabPage.UseVisualStyleBackColor = true;
            // 
            // materialDataGridView
            // 
            this.materialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialDataGridView.Location = new System.Drawing.Point(3, 2);
            this.materialDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialDataGridView.Name = "materialDataGridView";
            this.materialDataGridView.RowHeadersWidth = 62;
            this.materialDataGridView.RowTemplate.Height = 28;
            this.materialDataGridView.Size = new System.Drawing.Size(587, 400);
            this.materialDataGridView.TabIndex = 0;
            // 
            // processingTabPage
            // 
            this.processingTabPage.Controls.Add(this.supplierLabel);
            this.processingTabPage.Controls.Add(this.typeLabel);
            this.processingTabPage.Controls.Add(this.materialLabel);
            this.processingTabPage.Controls.Add(this.processingLabel);
            this.processingTabPage.Controls.Add(this.processingDataGridView);
            this.processingTabPage.Controls.Add(this.supplierComboBox);
            this.processingTabPage.Controls.Add(this.typeComboBox);
            this.processingTabPage.Controls.Add(this.materialComboBox);
            this.processingTabPage.Controls.Add(this.processingComboBox);
            this.processingTabPage.Location = new System.Drawing.Point(4, 25);
            this.processingTabPage.Name = "processingTabPage";
            this.processingTabPage.Size = new System.Drawing.Size(593, 404);
            this.processingTabPage.TabIndex = 2;
            this.processingTabPage.Text = "Processing";
            this.processingTabPage.UseVisualStyleBackColor = true;
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Location = new System.Drawing.Point(448, 2);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(57, 16);
            this.supplierLabel.TabIndex = 8;
            this.supplierLabel.Text = "Supplier";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(300, 2);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(39, 16);
            this.typeLabel.TabIndex = 7;
            this.typeLabel.Text = "Type";
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Location = new System.Drawing.Point(152, 2);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(55, 16);
            this.materialLabel.TabIndex = 6;
            this.materialLabel.Text = "Material";
            // 
            // processingLabel
            // 
            this.processingLabel.AutoSize = true;
            this.processingLabel.Location = new System.Drawing.Point(8, 2);
            this.processingLabel.Name = "processingLabel";
            this.processingLabel.Size = new System.Drawing.Size(75, 16);
            this.processingLabel.TabIndex = 5;
            this.processingLabel.Text = "Processing";
            // 
            // processingDataGridView
            // 
            this.processingDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processingDataGridView.Location = new System.Drawing.Point(3, 50);
            this.processingDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.processingDataGridView.Name = "processingDataGridView";
            this.processingDataGridView.RowHeadersWidth = 62;
            this.processingDataGridView.RowTemplate.Height = 28;
            this.processingDataGridView.Size = new System.Drawing.Size(587, 352);
            this.processingDataGridView.TabIndex = 4;
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(448, 21);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(142, 24);
            this.supplierComboBox.TabIndex = 3;
            this.supplierComboBox.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(300, 21);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(142, 24);
            this.typeComboBox.TabIndex = 2;
            this.typeComboBox.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            // 
            // materialComboBox
            // 
            this.materialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(152, 21);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(142, 24);
            this.materialComboBox.TabIndex = 1;
            this.materialComboBox.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            // 
            // processingComboBox
            // 
            this.processingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processingComboBox.FormattingEnabled = true;
            this.processingComboBox.Location = new System.Drawing.Point(4, 21);
            this.processingComboBox.Name = "processingComboBox";
            this.processingComboBox.Size = new System.Drawing.Size(142, 24);
            this.processingComboBox.TabIndex = 0;
            this.processingComboBox.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            // 
            // PricesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 476);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PricesForm";
            this.Text = "Prices";
            ((System.ComponentModel.ISupportInitialize)(this.workDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.workPriceTabPage.ResumeLayout(false);
            this.materialPriceTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialDataGridView)).EndInit();
            this.processingTabPage.ResumeLayout(false);
            this.processingTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processingDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView workDataGridView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage workPriceTabPage;
        private System.Windows.Forms.TabPage materialPriceTabPage;
        private System.Windows.Forms.DataGridView materialDataGridView;
        private System.Windows.Forms.TabPage processingTabPage;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.ComboBox processingComboBox;
        private System.Windows.Forms.DataGridView processingDataGridView;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Label processingLabel;
    }
}