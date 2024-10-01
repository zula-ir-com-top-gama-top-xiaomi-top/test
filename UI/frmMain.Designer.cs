namespace UI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Options_Theme = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Products = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Products_Load = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusBar_AppStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Menu_Products_New = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu.SuspendLayout();
            this.StatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.Menu_Options,
            this.Menu_Products});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1692, 53);
            this.Menu.TabIndex = 0;
            // 
            // Menu_File
            // 
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File_Open,
            this.Menu_File_Save,
            this.toolStripSeparator1,
            this.Menu_File_Exit});
            this.Menu_File.Name = "Menu_File";
            this.Menu_File.Size = new System.Drawing.Size(89, 49);
            this.Menu_File.Text = "File";
            // 
            // Menu_File_Open
            // 
            this.Menu_File_Open.Name = "Menu_File_Open";
            this.Menu_File_Open.Size = new System.Drawing.Size(237, 54);
            this.Menu_File_Open.Text = "Open";
            // 
            // Menu_File_Save
            // 
            this.Menu_File_Save.Name = "Menu_File_Save";
            this.Menu_File_Save.Size = new System.Drawing.Size(237, 54);
            this.Menu_File_Save.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(234, 6);
            // 
            // Menu_File_Exit
            // 
            this.Menu_File_Exit.Name = "Menu_File_Exit";
            this.Menu_File_Exit.Size = new System.Drawing.Size(237, 54);
            this.Menu_File_Exit.Text = "Exit";
            // 
            // Menu_Options
            // 
            this.Menu_Options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Options_Theme});
            this.Menu_Options.Name = "Menu_Options";
            this.Menu_Options.Size = new System.Drawing.Size(139, 49);
            this.Menu_Options.Text = "Option";
            // 
            // Menu_Options_Theme
            // 
            this.Menu_Options_Theme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.lightToolStripMenuItem});
            this.Menu_Options_Theme.Name = "Menu_Options_Theme";
            this.Menu_Options_Theme.Size = new System.Drawing.Size(256, 54);
            this.Menu_Options_Theme.Text = "Theme";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(230, 54);
            this.darkToolStripMenuItem.Text = "Dark";
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(230, 54);
            this.lightToolStripMenuItem.Text = "Light";
            // 
            // Menu_Products
            // 
            this.Menu_Products.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Products_Load,
            this.toolStripSeparator2,
            this.Menu_Products_New});
            this.Menu_Products.Name = "Menu_Products";
            this.Menu_Products.Size = new System.Drawing.Size(165, 49);
            this.Menu_Products.Text = "Products";
            // 
            // Menu_Products_Load
            // 
            this.Menu_Products_Load.Name = "Menu_Products_Load";
            this.Menu_Products_Load.Size = new System.Drawing.Size(359, 54);
            this.Menu_Products_Load.Text = "Load";
            this.Menu_Products_Load.Click += new System.EventHandler(this.Menu_Products_Load_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBar_AppStatus});
            this.StatusBar.Location = new System.Drawing.Point(0, 892);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(1692, 42);
            this.StatusBar.TabIndex = 1;
            this.StatusBar.Text = "statusStrip1";
            // 
            // StatusBar_AppStatus
            // 
            this.StatusBar_AppStatus.Name = "StatusBar_AppStatus";
            this.StatusBar_AppStatus.Size = new System.Drawing.Size(133, 32);
            this.StatusBar_AppStatus.Text = "App Ready.";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 53);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 82;
            this.dgv.RowTemplate.Height = 33;
            this.dgv.Size = new System.Drawing.Size(1692, 839);
            this.dgv.TabIndex = 2;
            // 
            // Menu_Products_New
            // 
            this.Menu_Products_New.Name = "Menu_Products_New";
            this.Menu_Products_New.Size = new System.Drawing.Size(359, 54);
            this.Menu_Products_New.Text = "New";
            this.Menu_Products_New.Click += new System.EventHandler(this.Menu_Products_New_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(356, 6);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1692, 934);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.Menu);
            this.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem Menu_File;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_Open;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem Menu_Options;
        private System.Windows.Forms.ToolStripMenuItem Menu_Options_Theme;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusBar_AppStatus;
        private System.Windows.Forms.ToolStripMenuItem Menu_Products;
        private System.Windows.Forms.ToolStripMenuItem Menu_Products_Load;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Menu_Products_New;
    }
}