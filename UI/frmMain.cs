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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Menu_Products_Load_Click(object sender, EventArgs e)
        {
            ProductsApplication products = new ProductsApplication();
            var ProductsCollection = products.Get();

            dgv.DataSource = ProductsCollection;
        }

        private void Menu_Products_New_Click(object sender, EventArgs e)
        {
            frmProducts frm = new frmProducts();
            frm.ShowDialog();
        }
    }
}
