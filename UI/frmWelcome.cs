using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            prgb.Value++;

            if (prgb.Value == 100)
            {
                MyTimer.Enabled = false;
                this.Hide();

                //frmLogin frm = new frmLogin();
                //frm.ShowDialog();
            }


        }
    }
}
