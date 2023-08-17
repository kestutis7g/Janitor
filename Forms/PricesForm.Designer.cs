﻿namespace Janitor_V1
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
            ((System.ComponentModel.ISupportInitialize)(this.workDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.workPriceTabPage.SuspendLayout();
            this.materialPriceTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // workDataGridView
            // 
            this.workDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workDataGridView.Location = new System.Drawing.Point(3, 3);
            this.workDataGridView.Name = "workDataGridView";
            this.workDataGridView.RowHeadersWidth = 62;
            this.workDataGridView.RowTemplate.Height = 28;
            this.workDataGridView.Size = new System.Drawing.Size(663, 503);
            this.workDataGridView.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(421, 548);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(116, 42);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(549, 548);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(116, 42);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.workPriceTabPage);
            this.tabControl1.Controls.Add(this.materialPriceTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(677, 542);
            this.tabControl1.TabIndex = 3;
            // 
            // workPriceTabPage
            // 
            this.workPriceTabPage.Controls.Add(this.workDataGridView);
            this.workPriceTabPage.Location = new System.Drawing.Point(4, 29);
            this.workPriceTabPage.Name = "workPriceTabPage";
            this.workPriceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.workPriceTabPage.Size = new System.Drawing.Size(669, 509);
            this.workPriceTabPage.TabIndex = 0;
            this.workPriceTabPage.Text = "Work";
            this.workPriceTabPage.UseVisualStyleBackColor = true;
            // 
            // materialPriceTabPage
            // 
            this.materialPriceTabPage.Controls.Add(this.materialDataGridView);
            this.materialPriceTabPage.Location = new System.Drawing.Point(4, 29);
            this.materialPriceTabPage.Name = "materialPriceTabPage";
            this.materialPriceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.materialPriceTabPage.Size = new System.Drawing.Size(669, 509);
            this.materialPriceTabPage.TabIndex = 1;
            this.materialPriceTabPage.Text = "Material";
            this.materialPriceTabPage.UseVisualStyleBackColor = true;
            // 
            // materialDataGridView
            // 
            this.materialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialDataGridView.Location = new System.Drawing.Point(3, 3);
            this.materialDataGridView.Name = "materialDataGridView";
            this.materialDataGridView.RowHeadersWidth = 62;
            this.materialDataGridView.RowTemplate.Height = 28;
            this.materialDataGridView.Size = new System.Drawing.Size(663, 503);
            this.materialDataGridView.TabIndex = 0;
            // 
            // PricesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 596);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Name = "PricesForm";
            this.Text = "Prices";
            ((System.ComponentModel.ISupportInitialize)(this.workDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.workPriceTabPage.ResumeLayout(false);
            this.materialPriceTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialDataGridView)).EndInit();
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
    }
}