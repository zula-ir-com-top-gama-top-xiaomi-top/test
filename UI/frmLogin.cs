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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Username required!", "My App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("password required!", "My App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UsersApplication.OperationTypes OperationType;

            if (txtUsername.Text.StartsWith("0"))
                OperationType = UsersApplication.OperationTypes.PhoneNumber; // Mobile
            else if (txtUsername.Text.Contains("@"))
                OperationType = UsersApplication.OperationTypes.Email; //Email
            else
                OperationType = UsersApplication.OperationTypes.Username; //Username

            bool AllowLogin = false;

            //if (OperationType == Users.OperationTypes.PhoneNumber)
            //{
            //    AllowLogin = Users.Login(txtUsername.Text, txtPassword.Text, 1);
            //}
            //else if (OperationType == Users.OperationTypes.Email)
            //{
            //    AllowLogin = Users.Login(txtUsername.Text, txtPassword.Text, "");
            //}
            //else
            //{
            //    AllowLogin = Users.Login(txtUsername.Text, txtPassword.Text, false);
            //}


            if (UsersApplication.Login(txtUsername.Text, txtPassword.Text))
            {
                //MessageBox.Show("Login Successfully...", "My App", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();

                frmMain frmMain = new frmMain();
                frmMain.ShowDialog();
            }

            else
            {
                MessageBox.Show("Username or password incorrect!", "My App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
