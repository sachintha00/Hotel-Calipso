using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMDMessageBox;
using SMDMySQLDBManager;

namespace HotelCalipso
{
    public partial class frmLogin : Form
    {
        private SmdDbManager dbManager;
        public frmLogin()
        {
            InitializeComponent();
            dbManager = new SmdDbManager("SERVER=127.0.0.1;PORT=3306;DATABASE=hotelcalipso;UID=root;PASSWORD=;");
        }

        private void login()
        {

            if (1 == dbManager.chek("SELECT * FROM `login` WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' "))
            {
                frmAdminMain obj = new frmAdminMain();
                this.Hide();
                obj.Show();
            }
            else if (1 == dbManager.chek("SELECT * FROM `login` WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' "))
            {
                frmAdminMain obj = new frmAdminMain();
                this.Hide();
                obj.Show();
            }
            else
                SMDMessage.show("Error", "Username or Password incorrect", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Error);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}
