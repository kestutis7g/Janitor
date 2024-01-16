namespace Janitor_V1.Forms
{
    partial class SheetProcessingOptions
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
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.materialLabel = new System.Windows.Forms.Label();
            this.cuttingTypeLabel = new System.Windows.Forms.Label();
            this.cuttingTypeComboBox = new System.Windows.Forms.ComboBox();
            this.punchingTypeLabel = new System.Windows.Forms.Label();
            this.punchingTypeComboBox = new System.Windows.Forms.ComboBox();
            this.paintingTypeLabel = new System.Windows.Forms.Label();
            this.paintingTypeComboBox = new System.Windows.Forms.ComboBox();
            this.bendingTypeLabel = new System.Windows.Forms.Label();
            this.bendingTypeComboBox = new System.Windows.Forms.ComboBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OKButton.Location = new System.Drawing.Point(56, 388);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 32);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(179, 388);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 32);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // materialComboBox
            // 
            this.materialComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(15, 28);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(290, 24);
            this.materialComboBox.TabIndex = 2;
            this.materialComboBox.SelectedValueChanged += new System.EventHandler(this.materialComboBox_SelectedValueChanged);
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Location = new System.Drawing.Point(12, 9);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(127, 16);
            this.materialLabel.TabIndex = 4;
            this.materialLabel.Text = "Sheet part material*:";
            // 
            // cuttingTypeLabel
            // 
            this.cuttingTypeLabel.AutoSize = true;
            this.cuttingTypeLabel.Location = new System.Drawing.Point(12, 60);
            this.cuttingTypeLabel.Name = "cuttingTypeLabel";
            this.cuttingTypeLabel.Size = new System.Drawing.Size(84, 16);
            this.cuttingTypeLabel.TabIndex = 6;
            this.cuttingTypeLabel.Text = "Cutting type*:";
            // 
            // cuttingTypeComboBox
            // 
            this.cuttingTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuttingTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cuttingTypeComboBox.FormattingEnabled = true;
            this.cuttingTypeComboBox.Location = new System.Drawing.Point(15, 79);
            this.cuttingTypeComboBox.Name = "cuttingTypeComboBox";
            this.cuttingTypeComboBox.Size = new System.Drawing.Size(290, 24);
            this.cuttingTypeComboBox.TabIndex = 5;
            // 
            // punchingTypeLabel
            // 
            this.punchingTypeLabel.AutoSize = true;
            this.punchingTypeLabel.Location = new System.Drawing.Point(12, 112);
            this.punchingTypeLabel.Name = "punchingTypeLabel";
            this.punchingTypeLabel.Size = new System.Drawing.Size(99, 16);
            this.punchingTypeLabel.TabIndex = 8;
            this.punchingTypeLabel.Text = "Punching type*:";
            // 
            // punchingTypeComboBox
            // 
            this.punchingTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.punchingTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.punchingTypeComboBox.FormattingEnabled = true;
            this.punchingTypeComboBox.Location = new System.Drawing.Point(15, 131);
            this.punchingTypeComboBox.Name = "punchingTypeComboBox";
            this.punchingTypeComboBox.Size = new System.Drawing.Size(290, 24);
            this.punchingTypeComboBox.TabIndex = 7;
            // 
            // paintingTypeLabel
            // 
            this.paintingTypeLabel.AutoSize = true;
            this.paintingTypeLabel.Location = new System.Drawing.Point(12, 221);
            this.paintingTypeLabel.Name = "paintingTypeLabel";
            this.paintingTypeLabel.Size = new System.Drawing.Size(87, 16);
            this.paintingTypeLabel.TabIndex = 10;
            this.paintingTypeLabel.Text = "Painting type:";
            // 
            // paintingTypeComboBox
            // 
            this.paintingTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paintingTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paintingTypeComboBox.FormattingEnabled = true;
            this.paintingTypeComboBox.Location = new System.Drawing.Point(15, 240);
            this.paintingTypeComboBox.Name = "paintingTypeComboBox";
            this.paintingTypeComboBox.Size = new System.Drawing.Size(290, 24);
            this.paintingTypeComboBox.TabIndex = 9;
            // 
            // bendingTypeLabel
            // 
            this.bendingTypeLabel.AutoSize = true;
            this.bendingTypeLabel.Location = new System.Drawing.Point(12, 166);
            this.bendingTypeLabel.Name = "bendingTypeLabel";
            this.bendingTypeLabel.Size = new System.Drawing.Size(94, 16);
            this.bendingTypeLabel.TabIndex = 12;
            this.bendingTypeLabel.Text = "Bending type*:";
            // 
            // bendingTypeComboBox
            // 
            this.bendingTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bendingTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bendingTypeComboBox.FormattingEnabled = true;
            this.bendingTypeComboBox.Location = new System.Drawing.Point(15, 185);
            this.bendingTypeComboBox.Name = "bendingTypeComboBox";
            this.bendingTypeComboBox.Size = new System.Drawing.Size(290, 24);
            this.bendingTypeComboBox.TabIndex = 11;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(12, 283);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(107, 16);
            this.infoLabel.TabIndex = 13;
            this.infoLabel.Text = "* - required fields";
            // 
            // SheetProcessingOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 432);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.bendingTypeLabel);
            this.Controls.Add(this.bendingTypeComboBox);
            this.Controls.Add(this.paintingTypeLabel);
            this.Controls.Add(this.paintingTypeComboBox);
            this.Controls.Add(this.punchingTypeLabel);
            this.Controls.Add(this.punchingTypeComboBox);
            this.Controls.Add(this.cuttingTypeLabel);
            this.Controls.Add(this.cuttingTypeComboBox);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.materialComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKButton);
            this.Name = "SheetProcessingOptions";
            this.Text = "Sheet Processing Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Label cuttingTypeLabel;
        private System.Windows.Forms.ComboBox cuttingTypeComboBox;
        private System.Windows.Forms.Label punchingTypeLabel;
        private System.Windows.Forms.ComboBox punchingTypeComboBox;
        private System.Windows.Forms.Label paintingTypeLabel;
        private System.Windows.Forms.ComboBox paintingTypeComboBox;
        private System.Windows.Forms.Label bendingTypeLabel;
        private System.Windows.Forms.ComboBox bendingTypeComboBox;
        private System.Windows.Forms.Label infoLabel;
    }
}