namespace UI
{
    partial class frmWelcome
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
            this.PicBox_Welcome = new System.Windows.Forms.PictureBox();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            this.prgb = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Welcome)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBox_Welcome
            // 
            this.PicBox_Welcome.BackgroundImage = global::UI.Properties.Resources.welcome_picture;
            this.PicBox_Welcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBox_Welcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicBox_Welcome.Location = new System.Drawing.Point(0, 0);
            this.PicBox_Welcome.Name = "PicBox_Welcome";
            this.PicBox_Welcome.Size = new System.Drawing.Size(1142, 615);
            this.PicBox_Welcome.TabIndex = 0;
            this.PicBox_Welcome.TabStop = false;
            // 
            // MyTimer
            // 
            this.MyTimer.Enabled = true;
            this.MyTimer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // prgb
            // 
            this.prgb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prgb.Location = new System.Drawing.Point(0, 615);
            this.prgb.Name = "prgb";
            this.prgb.Size = new System.Drawing.Size(1142, 87);
            this.prgb.TabIndex = 1;
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 702);
            this.ControlBox = false;
            this.Controls.Add(this.PicBox_Welcome);
            this.Controls.Add(this.prgb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWelcome";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmWelcome";
            this.Load += new System.EventHandler(this.frmWelcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Welcome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBox_Welcome;
        private System.Windows.Forms.Timer MyTimer;
        private System.Windows.Forms.ProgressBar prgb;
    }
}