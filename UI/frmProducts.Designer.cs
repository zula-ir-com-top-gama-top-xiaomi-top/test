namespace UI
{
    partial class frmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            this.tbl = new System.Windows.Forms.TableLayoutPanel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.cmbColors = new System.Windows.Forms.ComboBox();
            this.tbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl
            // 
            this.tbl.ColumnCount = 2;
            this.tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl.Controls.Add(this.txtTitle, 1, 0);
            this.tbl.Controls.Add(this.lblCount, 0, 1);
            this.tbl.Controls.Add(this.lblTitle, 0, 0);
            this.tbl.Controls.Add(this.lblColor, 0, 2);
            this.tbl.Controls.Add(this.lblPrice, 0, 3);
            this.tbl.Controls.Add(this.btnSave, 1, 5);
            this.tbl.Controls.Add(this.txtCount, 1, 1);
            this.tbl.Controls.Add(this.txtPrice, 1, 3);
            this.tbl.Controls.Add(this.chkAvailable, 1, 4);
            this.tbl.Controls.Add(this.cmbColors, 1, 2);
            this.tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl.Location = new System.Drawing.Point(0, 0);
            this.tbl.Name = "tbl";
            this.tbl.RowCount = 6;
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl.Size = new System.Drawing.Size(937, 332);
            this.tbl.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Location = new System.Drawing.Point(179, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(755, 32);
            this.txtTitle.TabIndex = 0;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCount.Location = new System.Drawing.Point(3, 41);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(170, 41);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "Count";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblColor.Location = new System.Drawing.Point(3, 82);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(170, 41);
            this.lblColor.TabIndex = 0;
            this.lblColor.Text = "Color";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrice.Location = new System.Drawing.Point(3, 123);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(170, 41);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price";
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(653, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(281, 107);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtCount
            // 
            this.txtCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCount.Location = new System.Drawing.Point(179, 44);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(755, 32);
            this.txtCount.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrice.Location = new System.Drawing.Point(179, 126);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(755, 32);
            this.txtPrice.TabIndex = 3;
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAvailable.Location = new System.Drawing.Point(179, 167);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(755, 49);
            this.chkAvailable.TabIndex = 4;
            this.chkAvailable.Text = "Available";
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // cmbColors
            // 
            this.cmbColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbColors.FormattingEnabled = true;
            this.cmbColors.Items.AddRange(new object[] {
            "Red",
            "Purple",
            "Green",
            "Cyan"});
            this.cmbColors.Location = new System.Drawing.Point(179, 85);
            this.cmbColors.Name = "cmbColors";
            this.cmbColors.Size = new System.Drawing.Size(755, 33);
            this.cmbColors.TabIndex = 6;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 332);
            this.Controls.Add(this.tbl);
            this.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProducts";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products Management";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.tbl.ResumeLayout(false);
            this.tbl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbl;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbColors;
        public System.Windows.Forms.TextBox txtTitle;
    }
}