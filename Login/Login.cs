using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        DB dB = new DB();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtUsername.Text))
            {
                MessageBox.Show("Please Enter Username.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtPassword.Text))
            {
                MessageBox.Show("Please Enter Password.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPassword.Focus();
                return;
            }
            string query = string.Concat("SELECT COUNT(*) FROM login where username = '",this.txtUsername.Text,"' and password = '",this.txtPassword.Text,"'");
            if (Convert.ToInt16(dB.QueryScalar(query))<=0)
            {
                MessageBox.Show("Usernam or Password is incorrect. Please Put valid usernae and password");
                return;
            }
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }
    }
}
